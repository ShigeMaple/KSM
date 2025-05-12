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
    }
}
