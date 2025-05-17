using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KSM
{
    public partial class LearningHistory : BaseForm
    {
        public LearningHistory()
        {
            InitializeComponent();
            // タイトルのラベル文字列を「採点結果入力」に変更
            base.UpdateDisplayID(this);
            
            // 初回起動時にグラフ一覧を選択
            radioButton2.Select();
        }

        private void ScoreEntry_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            this.contentPanel.Width = control.Width;
            this.contentPanel.Height = control.Height - 39 - 80;
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ChangeStudent();
            form.ShowDialog();
        }

        private void SetContent(Form form)
        {
            panel3.Controls.Clear();
            //StudentList sl = new StudentList();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            form.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetContent(new ScoreListForm());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetContent(new ScoreGraphForm());
        }
    }
}
