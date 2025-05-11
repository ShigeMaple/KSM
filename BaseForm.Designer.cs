namespace KSM
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.displayId = new System.Windows.Forms.Label();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.blueLine = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.splitPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
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
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "BaseForm";
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel splitPanel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox blueLine;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.Label displayId;
    }
}

