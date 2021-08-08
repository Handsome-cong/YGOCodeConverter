using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGOCodeConverter
{
    public partial class YGOCodeConverter : Form
    {
        //readonly string defaultText = @"ygo://deck?main=10000020_72443568_72989439_37267041_46986414_71703785_29904964_16589042_7841921_70781052_38033121_14778250_71413901_87564352_52077741_78010363_7913375_41175645*2_15180041_15613529_65240384_34710660_16404809_26202165_31305911_45141844_31560081_40640057_70828912_47222536_87567063_53046408_44968459_5318639_99789342_83764718_79571449_75500286_72892473_72302403_63391643_55144522_24096228_5758500_5556668_2314238_1784686_3819470_48680970_18807108_81210420_35563539&extra=11901678_41721210_75380687_98502113_43892409_43892408_13722870&side=78193832_95286165_18563744_53129443_24094653_19613556_6390406_4031928_62279055_44095762_24874630";
        Dictionary<TextBox, bool> hasContent = new Dictionary<TextBox, bool>();
        Dictionary<TextBox, string> defaultText = new Dictionary<TextBox, string>();
        Deck deck = new Deck();
        public YGOCodeConverter()
        {
            InitializeComponent();
            hasContent.Add(ygmText, false);
            defaultText.Add(ygmText, @"ygo://deck?main=10000020_72443568_72989439_37267041_46986414_71703785_29904964_16589042_7841921_70781052_38033121_14778250_71413901_87564352_52077741_78010363_7913375_41175645*2_15180041_15613529_65240384_34710660_16404809_26202165_31305911_45141844_31560081_40640057_70828912_47222536_87567063_53046408_44968459_5318639_99789342_83764718_79571449_75500286_72892473_72302403_63391643_55144522_24096228_5758500_5556668_2314238_1784686_3819470_48680970_18807108_81210420_35563539&extra=11901678_41721210_75380687_98502113_43892409_43892408_13722870&side=78193832_95286165_18563744_53129443_24094653_19613556_6390406_4031928_62279055_44095762_24874630");
            SetDefaultText(ygmText);
            hasContent.Add(ydkText, false);
            defaultText.Add(ydkText, "");
            SetDefaultText(ydkText);
        }

        private void SetDefaultText(TextBox text)
        {
            text.Text = defaultText[text];
            text.ForeColor = Color.Gray;
        }

        private void CheckContent()
        {
            hasContent[ygmText] = !string.IsNullOrEmpty(ygmText.Text);
            ygmText.ForeColor = hasContent[ygmText] ? Color.Black : Color.Gray;
            hasContent[ydkText] = !string.IsNullOrEmpty(ydkText.Text);
            ydkText.ForeColor = hasContent[ydkText] ? Color.Black : Color.Gray;
        }

        private void Text_Enter(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            if(!hasContent[text])
            {
                text.Text = "";
                text.ForeColor = Color.Black;
            }
        }

        private void Text_Leave(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            if (text.Text == "")
            {
                hasContent[text] = false;
                SetDefaultText(text);
            }
            else
                hasContent[text] = true;
        }

        private void btnygm2ydk_Click(object sender, EventArgs e)
        {
            deck.Fromygm(ygmText.Text);
            ydkText.Text = deck.Toydk();
            if (hasContent[ydkText]= !string.IsNullOrEmpty(ydkText.Text))
                Clipboard.SetText(ydkText.Text);
            CheckContent();
        }

        private void btnydk2ygm_Click(object sender, EventArgs e)
        {
            deck.Fromydk(ydkText.Text);
            ygmText.Text = deck.Toygm();
            if (hasContent[ygmText] = !string.IsNullOrEmpty(ygmText.Text))
                Clipboard.SetText(ygmText.Text);
            CheckContent();
        }
    }
}
