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
    public partial class ScoreEntry : BaseForm
    {
        public ScoreEntry()
        {
            InitializeComponent();
            // タイトルのラベル文字列を「採点結果入力」に変更
            base.UpdateDisplayID(this);
        }

        private void ScoreEntry_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            this.contentPanel.Width = control.Width;
            this.contentPanel.Height = control.Height - 39 - 80;
        }
    }
}
