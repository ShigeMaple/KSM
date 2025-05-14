using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSM
{
    public partial class MainForm : Form
    {
        // =====================
        const int MENU_ROWS = 4;
        // =====================
        public MainForm()
        {
            InitializeComponent();

            this.displayId.Location = new Point((1280 - this.displayId.Width) / 2, 15);
            this.blueBox.Location = new Point(1280 - 191, 0);
            SetContent(new StudentList(this));
            
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            this.headerPanel.Width = control.Width;
            this.splitPanel.Width = control.Width;

            //this.menuPanel.Width = control.Width / 5;
            this.menuPanel.Height = control.Height - 39 - 80;

            //this.contentPanel.Location = new Point(control.Width / 5, 80);
            this.contentPanel.Location = new Point(contentPanel.Location.X, 80);
            //this.contentPanel.Width = control.Width * 4 / 5;
            this.contentPanel.Width = control.Width - menuPanel.Width;
            this.contentPanel.Height = control.Height - 39 - 80;

            this.displayId.Location = new Point((control.Width - this.displayId.Width) / 2, 15);
            this.blueBox.Location = new Point(control.Width - 191, 0);
        }

        /// <summary>
        /// 右下のContentsエリアにフォームを配置。
        /// フォームのタイトルバーとタイトルも更新。
        /// </summary>
        /// <param name="form">設定するフォームのインスタンス</param>
        private void SetContent(Form form) 
        {
            contentPanel.Controls.Clear();
            //StudentList sl = new StudentList();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(form);
            form.Show();
            Text = form.Text;
            UpdateDisplayID(form);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 押された自身のオブジェクトをsenderから取得
            ChangeLinkColor(sender as LinkLabel);
            SetContent(new StudentList(this));
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeLinkColor(sender as LinkLabel);
            SetContent(new StudentInfo(this));
        }

        /// <summary>
        /// 遷移先のメニュー名を青色にし、それ以外を黒色にする関数。
        /// </summary>
        /// <param name="ll">クリックされたLinlLabelのオブジェクト</param>
        private void ChangeLinkColor(LinkLabel ll) 
        {
            for (int i = 0; i < MENU_ROWS; i++) 
            {
                string linkLabelName = "linkLabel" + (i + 1).ToString();
                //LinkLabel ctl = (LinkLabel)this.Controls[linkLabelName];
                LinkLabel ctl = this.menuPanel.Controls[linkLabelName] as LinkLabel;

                // 遷移先は青色
                if (ctl == ll) 
                    ctl.LinkColor = Color.FromArgb(0,0, 255);
                
                // それ以外は黒
                else
                    ctl.LinkColor = Color.FromArgb(0, 0, 0);
            }
        }

        /// <summary>
        /// form.Textを基に画面タイトル(ラベル)の文字列を更新する関数。
        /// </summary>
        /// <param name="form">自クラス(FormObject)</param>
        protected void UpdateDisplayID(Form form)
        {
            this.displayId.Text = form.Text;
            this.displayId.Location = new Point((1280 - this.displayId.Width) / 2, 15);
        }
    }
}
