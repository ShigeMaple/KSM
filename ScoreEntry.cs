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
    public partial class ScoreEntry : BaseForm
    {
        public ScoreEntry()
        {
            InitializeComponent();
            // タイトルのラベル文字列を「採点結果入力」に変更
            base.UpdateDisplayID(this);
            ChangeTabCtlColor();
        }

        private void ScoreEntry_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            this.contentPanel.Width = control.Width;
            this.contentPanel.Height = control.Height - 39 - 80;
        }

        private void ChangeTabCtlColor() 
        {
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(100, 40); // 幅100px、高さ40pxに設定
            tabControl1.SizeMode = TabSizeMode.Fixed;
            this.tabControl1.DrawItem += new DrawItemEventHandler(TabControl1_DrawItem);
        }

        private void TabControl1_DrawItem(Object sender, DrawItemEventArgs e) 
        {
            TabControl tab = (TabControl)sender;
            string txt = tab.TabPages[e.Index].Text;
            //タブのテキストと背景を描画するためのブラシを決定する
            Brush foreBrush, backBrush;

            // タブごとの色を設定（ここで自由に変更可能）
            Color[] tabBackColors = { Color.FromArgb(219, 100, 120), Color.FromArgb(14, 130, 190), Color.FromArgb(50, 179, 109) };
            Color[] tabTextColors = { Color.White, Color.White, Color.White };

            // デフォルト色（インデックスが範囲外の場合）
            Color backColor = (e.Index < tabBackColors.Length) ? tabBackColors[e.Index] : Color.Gray;
            Brush textBrush = (e.Index < tabTextColors.Length) ? new SolidBrush(tabTextColors[e.Index]) : Brushes.Black;

            tabControl1.Font = new Font("HGS創英角ﾎﾟｯﾌﾟ体", 20, FontStyle.Regular);

            //if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            //{
            //    //選択されているタブのテキストを赤、背景を青とする
            //    foreBrush = Brushes.Red;
            //    backBrush = Brushes.Blue;
            //}
            //else
            //{
            //    //選択されていないタブのテキストは灰色、背景を白とする
            //    foreBrush = Brushes.Gray;
            //    backBrush = Brushes.White;
            //}

            //StringFormatを作成
            StringFormat sf = new StringFormat();
            //中央に表示する
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            ////背景の描画
            //e.Graphics.FillRectangle(backBrush, e.Bounds);

            ////Textの描画
            //e.Graphics.DrawString(txt, e.Font, foreBrush, e.Bounds, sf);

            //背景の描画
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            //Textの描画
            e.Graphics.DrawString(txt, e.Font, textBrush, e.Bounds, sf);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ChangeStudent();
            form.ShowDialog();
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
