using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOCodeConverter
{
    class Deck
    {
        Dictionary<string, int> main = new Dictionary<string, int>();
        Dictionary<string, int> extra = new Dictionary<string, int>();
        Dictionary<string, int> side = new Dictionary<string, int>();

        void AddCards(Dictionary<string, int> deck, string[] cards)
        {
            deck.Clear();
            foreach (string card in cards)
            {
                int multiple = 1;
                string cardCode = card;
                if (card[card.Length - 2] == '*')
                {
                    int.TryParse(card.Substring(card.Length - 1, 1), out multiple);
                    cardCode = card.Substring(0, card.Length - 2);
                }
                deck.AddCard(cardCode, multiple);
            }
        }

        public void Fromygm(string ygm)
        {
            int mainIndex = ygm.IndexOf("main=");
            int extraIndex = ygm.IndexOf("&extra=");
            int sideIndex = ygm.IndexOf("&side=");
            int start, end;
            string[] cards;
            char[] splitChars = new char[] { '_', ' ' };
            if (mainIndex > 0)
            {
                start = mainIndex + 5;
                end = extraIndex > 0 ? extraIndex : (sideIndex > 0 ? sideIndex : ygm.Length);
                cards = ygm.Substring(start, end - start).Split(splitChars,StringSplitOptions.RemoveEmptyEntries);
                AddCards(main, cards);
            }
            if (extraIndex > 0)
            {
                start = extraIndex + 7;
                end = sideIndex > 0 ? sideIndex : ygm.Length;
                cards = ygm.Substring(start, end - start).Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
                AddCards(extra, cards);
            }
            if (sideIndex > 0)
            {
                start = sideIndex + 6;
                end = ygm.Length;
                cards = ygm.Substring(start, end - start).Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
                AddCards(side, cards);
            }
        }

        public string Toygm()
        {
            StringBuilder ygm = new StringBuilder(1024);
            ygm.Append(@"ygo://deck?main=");
            ygm.AppendygmCards(main);
            ygm.Append(@"&extra=");
            ygm.AppendygmCards(extra);
            ygm.Append(@"&side=");
            ygm.AppendygmCards(side);
            return ygm.ToString();
        }

        public void Fromydk(string ydk)
        {
            string[] cards = ydk.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var deck = main;
            main.Clear();
            extra.Clear();
            side.Clear();
            foreach (string card in cards)
            {
                if (!char.IsDigit(card[0]))
                {
                    switch (card)
                    {
                        case "#main":
                            deck = main;
                            break;
                        case "#extra":
                            deck = extra;
                            break;
                        case "!side":
                            deck = side;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    deck.AddCard(card);
                }
            }
        }


        public string Toydk()
        {
            StringBuilder ydk = new StringBuilder(1024);
            ydk.AppendLine(@"#created by ygopro2");
            ydk.AppendLine(@"#main");
            ydk.AppendydkCards(main);
            ydk.AppendLine(@"#extra");
            ydk.AppendydkCards(extra);
            ydk.AppendLine(@"!side");
            ydk.AppendydkCards(side);
            return ydk.ToString();
        }
    }
}

static class DeckExtension
{
    public static void AddCard(this Dictionary<string, int> deck, string card, int count = 1)
    {
        if (deck.ContainsKey(card))
            deck[card] += count;
        else
            deck[card] = count;
    }

    public static void AppendydkCards(this StringBuilder sb, Dictionary<string, int> deck)
    {
        foreach (var card in deck)
        {
            for (int i = 0; i < card.Value; i++)
            {
                sb.AppendLine(card.Key);
            }
        }
    }

    public static void AppendygmCards(this StringBuilder ygm, Dictionary<string, int> deck)
    {
        bool first = true;
        foreach (var card in deck)
        {
            ygm.Append(first ? "" : "_");
            first = false;
            ygm.Append(card.Key);
            ygm.Append(card.Value > 1 ? "*" + card.Value : "");
        }
    }
}