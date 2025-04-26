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
    }
}
