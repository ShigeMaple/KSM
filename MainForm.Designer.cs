namespace KSM
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.poweroffIcon = new System.Windows.Forms.PictureBox();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.kumonIcon = new System.Windows.Forms.PictureBox();
            this.powerOffBtn = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginUserNameBtn = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.displayId = new System.Windows.Forms.Label();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.blueLine = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.splitPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poweroffIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kumonIcon)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.contentPanel.Location = new System.Drawing.Point(256, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1008, 601);
            this.contentPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.poweroffIcon);
            this.menuPanel.Controls.Add(this.logoutIcon);
            this.menuPanel.Controls.Add(this.kumonIcon);
            this.menuPanel.Controls.Add(this.powerOffBtn);
            this.menuPanel.Controls.Add(this.logoutBtn);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.loginUserNameBtn);
            this.menuPanel.Controls.Add(this.linkLabel4);
            this.menuPanel.Controls.Add(this.linkLabel3);
            this.menuPanel.Controls.Add(this.linkLabel2);
            this.menuPanel.Controls.Add(this.linkLabel1);
            this.menuPanel.Location = new System.Drawing.Point(0, 80);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(256, 601);
            this.menuPanel.TabIndex = 1;
            // 
            // poweroffIcon
            // 
            this.poweroffIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.poweroffIcon.Image = global::KSM.Properties.Resources.poweroff_logo;
            this.poweroffIcon.Location = new System.Drawing.Point(25, 536);
            this.poweroffIcon.Name = "poweroffIcon";
            this.poweroffIcon.Size = new System.Drawing.Size(28, 27);
            this.poweroffIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.poweroffIcon.TabIndex = 11;
            this.poweroffIcon.TabStop = false;
            // 
            // logoutIcon
            // 
            this.logoutIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutIcon.Image = global::KSM.Properties.Resources.logout_logo;
            this.logoutIcon.Location = new System.Drawing.Point(22, 492);
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.Size = new System.Drawing.Size(39, 38);
            this.logoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoutIcon.TabIndex = 10;
            this.logoutIcon.TabStop = false;
            // 
            // kumonIcon
            // 
            this.kumonIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kumonIcon.Image = global::KSM.Properties.Resources.kumon_logo;
            this.kumonIcon.Location = new System.Drawing.Point(25, 463);
            this.kumonIcon.Name = "kumonIcon";
            this.kumonIcon.Size = new System.Drawing.Size(28, 23);
            this.kumonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kumonIcon.TabIndex = 9;
            this.kumonIcon.TabStop = false;
            // 
            // powerOffBtn
            // 
            this.powerOffBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.powerOffBtn.AutoSize = true;
            this.powerOffBtn.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.powerOffBtn.Location = new System.Drawing.Point(67, 544);
            this.powerOffBtn.Name = "powerOffBtn";
            this.powerOffBtn.Size = new System.Drawing.Size(39, 16);
            this.powerOffBtn.TabIndex = 8;
            this.powerOffBtn.Text = "終了";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.logoutBtn.Location = new System.Drawing.Point(67, 507);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(87, 16);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "ログアウト";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(123, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // loginUserNameBtn
            // 
            this.loginUserNameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginUserNameBtn.AutoSize = true;
            this.loginUserNameBtn.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginUserNameBtn.Location = new System.Drawing.Point(67, 468);
            this.loginUserNameBtn.Name = "loginUserNameBtn";
            this.loginUserNameBtn.Size = new System.Drawing.Size(98, 16);
            this.loginUserNameBtn.TabIndex = 5;
            this.loginUserNameBtn.Text = "公文A　さん";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(66, 227);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(120, 22);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "データ出力";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(66, 169);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(142, 22);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "スタッフ情報";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(66, 113);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(98, 22);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "生徒情報";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(66, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 22);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "生徒一覧";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.displayId);
            this.headerPanel.Controls.Add(this.blueBox);
            this.headerPanel.Controls.Add(this.blueLine);
            this.headerPanel.Controls.Add(this.icon);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1264, 70);
            this.headerPanel.TabIndex = 2;
            // 
            // displayId
            // 
            this.displayId.AutoSize = true;
            this.displayId.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.displayId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(95)))), ((int)(((byte)(154)))));
            this.displayId.Location = new System.Drawing.Point(580, 15);
            this.displayId.Name = "displayId";
            this.displayId.Size = new System.Drawing.Size(110, 40);
            this.displayId.TabIndex = 3;
            this.displayId.Text = "トップ";
            this.displayId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blueBox
            // 
            this.blueBox.Image = global::KSM.Properties.Resources.BlueBoxes;
            this.blueBox.Location = new System.Drawing.Point(1050, 0);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(175, 70);
            this.blueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueBox.TabIndex = 2;
            this.blueBox.TabStop = false;
            // 
            // blueLine
            // 
            this.blueLine.Image = global::KSM.Properties.Resources.BlueLines;
            this.blueLine.Location = new System.Drawing.Point(70, 0);
            this.blueLine.Name = "blueLine";
            this.blueLine.Size = new System.Drawing.Size(189, 70);
            this.blueLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueLine.TabIndex = 1;
            this.blueLine.TabStop = false;
            // 
            // icon
            // 
            this.icon.Image = global::KSM.Properties.Resources.Icon;
            this.icon.ImageLocation = "";
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(70, 70);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // splitPanel
            // 
            this.splitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(154)))), ((int)(((byte)(214)))));
            this.splitPanel.Location = new System.Drawing.Point(0, 70);
            this.splitPanel.Name = "splitPanel";
            this.splitPanel.Size = new System.Drawing.Size(1264, 10);
            this.splitPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "ver 1.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.contentPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poweroffIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kumonIcon)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel splitPanel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox blueLine;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.Label displayId;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label powerOffBtn;
        private System.Windows.Forms.Label logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginUserNameBtn;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.PictureBox kumonIcon;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.PictureBox poweroffIcon;
        private System.Windows.Forms.Label label2;
    }
}

