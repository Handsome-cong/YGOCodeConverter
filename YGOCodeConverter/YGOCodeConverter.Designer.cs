
namespace YGOCodeConverter
{
    partial class YGOCodeConverter
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ydkText = new System.Windows.Forms.TextBox();
            this.btnygm2ydk = new System.Windows.Forms.Button();
            this.btnydk2ygm = new System.Windows.Forms.Button();
            this.ygmLabel = new System.Windows.Forms.Label();
            this.ydkLabel = new System.Windows.Forms.Label();
            this.ygmText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ydkText
            // 
            this.ydkText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ydkText.Location = new System.Drawing.Point(585, 34);
            this.ydkText.Multiline = true;
            this.ydkText.Name = "ydkText";
            this.ydkText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ydkText.Size = new System.Drawing.Size(400, 483);
            this.ydkText.TabIndex = 1;
            this.ydkText.Enter += new System.EventHandler(this.Text_Enter);
            this.ydkText.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // btnygm2ydk
            // 
            this.btnygm2ydk.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.btnygm2ydk.Location = new System.Drawing.Point(438, 34);
            this.btnygm2ydk.Name = "btnygm2ydk";
            this.btnygm2ydk.Size = new System.Drawing.Size(123, 52);
            this.btnygm2ydk.TabIndex = 2;
            this.btnygm2ydk.Text = "转ydk>>";
            this.btnygm2ydk.UseVisualStyleBackColor = true;
            this.btnygm2ydk.Click += new System.EventHandler(this.btnygm2ydk_Click);
            // 
            // btnydk2ygm
            // 
            this.btnydk2ygm.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.btnydk2ygm.Location = new System.Drawing.Point(438, 92);
            this.btnydk2ygm.Name = "btnydk2ygm";
            this.btnydk2ygm.Size = new System.Drawing.Size(123, 52);
            this.btnydk2ygm.TabIndex = 3;
            this.btnydk2ygm.Text = "<<转ygm";
            this.btnydk2ygm.UseVisualStyleBackColor = true;
            this.btnydk2ygm.Click += new System.EventHandler(this.btnydk2ygm_Click);
            // 
            // ygmLabel
            // 
            this.ygmLabel.AutoSize = true;
            this.ygmLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ygmLabel.Location = new System.Drawing.Point(171, 8);
            this.ygmLabel.Name = "ygmLabel";
            this.ygmLabel.Size = new System.Drawing.Size(50, 23);
            this.ygmLabel.TabIndex = 4;
            this.ygmLabel.Text = "ygm:";
            // 
            // ydkLabel
            // 
            this.ydkLabel.AutoSize = true;
            this.ydkLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ydkLabel.Location = new System.Drawing.Point(743, 8);
            this.ydkLabel.Name = "ydkLabel";
            this.ydkLabel.Size = new System.Drawing.Size(43, 23);
            this.ydkLabel.TabIndex = 5;
            this.ydkLabel.Text = "ydk:";
            // 
            // ygmText
            // 
            this.ygmText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ygmText.Location = new System.Drawing.Point(12, 34);
            this.ygmText.Multiline = true;
            this.ygmText.Name = "ygmText";
            this.ygmText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ygmText.Size = new System.Drawing.Size(400, 483);
            this.ygmText.TabIndex = 0;
            this.ygmText.Enter += new System.EventHandler(this.Text_Enter);
            this.ygmText.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // YGOCodeConverter
            // 
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.ydkLabel);
            this.Controls.Add(this.ygmLabel);
            this.Controls.Add(this.btnydk2ygm);
            this.Controls.Add(this.btnygm2ydk);
            this.Controls.Add(this.ydkText);
            this.Controls.Add(this.ygmText);
            this.Name = "YGOCodeConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ydkText;
        private System.Windows.Forms.Button btnygm2ydk;
        private System.Windows.Forms.Button btnydk2ygm;
        private System.Windows.Forms.Label ygmLabel;
        private System.Windows.Forms.Label ydkLabel;
        private System.Windows.Forms.TextBox ygmText;
    }
}

