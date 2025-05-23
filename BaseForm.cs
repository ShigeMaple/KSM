﻿using System;
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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.blueBox.Location = new Point(1280 - 191, 0);
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            this.headerPanel.Width = control.Width;
            this.splitPanel.Width = control.Width;

            this.displayId.Location = new Point((control.Width - this.displayId.Width) / 2, 15);
            this.blueBox.Location = new Point(control.Width - 191, 0);
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
