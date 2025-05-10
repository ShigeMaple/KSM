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
        public MainForm()
        {
            InitializeComponent();

            this.displayId.Location = new Point((1280 - this.displayId.Width) / 2, 15);
            this.blueBox.Location = new Point(1280 - 191, 0);
            SetContent(new StudentList());
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

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

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
            displayId.Text = form.Text;
            Text = form.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
