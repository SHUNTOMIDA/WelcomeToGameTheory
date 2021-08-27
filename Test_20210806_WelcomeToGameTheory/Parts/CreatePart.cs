using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_20210806_WelcomeToGameTheory
{
    public partial class CreatePart : UserControl
    {
        public Panel editPanel; // ゲーム編集画面
        public TextBox ConsoleBox { get { return consoleTextBox; } }　// 分析結果が出力される
        public PictureBox VisualizeBox { get { return visualizeBox; } }
        public CreatePart()
        {
            InitializeComponent();
            editPanel = splitContainer3.Panel1;
        }

        //コントロール内にドラッグされたとき実行される
        private void splitContainer3_Panel1_DragEnter(object sender, DragEventArgs e)
        {
            //ドラッグされたデータ形式を調べ、文字列のときはコピーとする
            if (e.Data.GetDataPresent(typeof(String)))
            {
                e.Effect = DragDropEffects.Copy;
            }

            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void splitContainer3_Panel1_DragDrop(object sender, DragEventArgs e)
        {
            //ドロップされたデータ(string型)を取得
            string gameType = (string)e.Data.GetData(typeof(string));
            switch (gameType)
            {
                case "$000":
                    StrategyForm stForm = new StrategyForm(this);
                    editPanel.Controls.Add(stForm);
                    editPanel.BackColor = Color.White;
                    break;
                default:
                    return;
            }
        }

        private void helpTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // ヘルプページを作成
            WebBrowser helpBrowser = new WebBrowser();
            TabPage helpPage = new TabPage();

            // htmlに使うを宣言
            string url = "";
            string title = e.Node.Text;
            string judge = "";
            try
            {
                judge = e.Node.Tag.ToString();
            }
            catch(NullReferenceException ex) when(e.Node.Tag.ToString()==null)
            {
                throw ex;
            }

            switch (judge)
            {
                case "#00": // 使い方
                    url = @"..\..\HTML\AboutApp.html";
                    break;
                case "#0000":
                    url = @"..\..\HTML\GameUsage.html";
                    break;
                case "#010000":
                    url = @"..\..\HTML\StrategyForm.html";
                    break;
                default:
                    return;
                    break;
            }
            // urlを指定
            helpBrowser.Url = new Uri(Path.GetFullPath(url));

            // タイトルを追加
            helpPage.Text = title;

            //タブに追加
            helpPage.Controls.Add(helpBrowser);
            helpPage.Controls[0].Dock = DockStyle.Fill;
            Main.MainTabControl.TabPages.Add(helpPage);
            Main.MainTabControl.SelectedTab = helpPage;
        }

        private void toolTree_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            //タグにデータがある場合はタグを文字列としてコピー
            if (e.Node.Tag != null)
            {
                string data = e.Node.Tag.ToString();
                DoDragDrop(data, DragDropEffects.Copy);
            }
        }
    }
}
