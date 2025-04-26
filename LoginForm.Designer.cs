namespace KSM
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitPanel = new System.Windows.Forms.Panel();
            this.displayId = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.TextBox();
            this.PassWordLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.NewRegisterLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReRegisterPassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitPanel
            // 
            this.splitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(154)))), ((int)(((byte)(214)))));
            this.splitPanel.Location = new System.Drawing.Point(-451, 93);
            this.splitPanel.Name = "splitPanel";
            this.splitPanel.Size = new System.Drawing.Size(845, 10);
            this.splitPanel.TabIndex = 4;
            this.splitPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.splitPanel_Paint);
            // 
            // displayId
            // 
            this.displayId.AutoSize = true;
            this.displayId.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.displayId.ForeColor = System.Drawing.Color.Black;
            this.displayId.Location = new System.Drawing.Point(159, 33);
            this.displayId.Name = "displayId";
            this.displayId.Size = new System.Drawing.Size(93, 40);
            this.displayId.TabIndex = 5;
            this.displayId.Text = "KSM";
            this.displayId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // icon
            // 
            this.icon.Image = global::KSM.Properties.Resources.Icon;
            this.icon.ImageLocation = "";
            this.icon.Location = new System.Drawing.Point(83, 18);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(70, 70);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 6;
            this.icon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ユーザID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.Location = new System.Drawing.Point(105, 172);
            this.UserIDLabel.Multiline = true;
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(186, 28);
            this.UserIDLabel.TabIndex = 9;
            // 
            // PassWordLabel
            // 
            this.PassWordLabel.Location = new System.Drawing.Point(106, 242);
            this.PassWordLabel.Multiline = true;
            this.PassWordLabel.Name = "PassWordLabel";
            this.PassWordLabel.Size = new System.Drawing.Size(186, 28);
            this.PassWordLabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(163, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "パスワード";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(154)))), ((int)(((byte)(214)))));
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(105, 312);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(186, 31);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "ログイン";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewRegisterLabel
            // 
            this.NewRegisterLabel.AutoSize = true;
            this.NewRegisterLabel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NewRegisterLabel.ForeColor = System.Drawing.Color.Black;
            this.NewRegisterLabel.Location = new System.Drawing.Point(164, 376);
            this.NewRegisterLabel.Name = "NewRegisterLabel";
            this.NewRegisterLabel.Size = new System.Drawing.Size(61, 20);
            this.NewRegisterLabel.TabIndex = 13;
            this.NewRegisterLabel.Text = "新規登録";
            this.NewRegisterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(170, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "または";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReRegisterPassLabel
            // 
            this.ReRegisterPassLabel.AutoSize = true;
            this.ReRegisterPassLabel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReRegisterPassLabel.ForeColor = System.Drawing.Color.Black;
            this.ReRegisterPassLabel.Location = new System.Drawing.Point(121, 424);
            this.ReRegisterPassLabel.Name = "ReRegisterPassLabel";
            this.ReRegisterPassLabel.Size = new System.Drawing.Size(152, 20);
            this.ReRegisterPassLabel.TabIndex = 15;
            this.ReRegisterPassLabel.Text = "パスワードを忘れた場合";
            this.ReRegisterPassLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(393, 506);
            this.Controls.Add(this.ReRegisterPassLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewRegisterLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassWordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.displayId);
            this.Controls.Add(this.splitPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel splitPanel;
        private System.Windows.Forms.Label displayId;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserIDLabel;
        private System.Windows.Forms.TextBox PassWordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label NewRegisterLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ReRegisterPassLabel;
    }
}