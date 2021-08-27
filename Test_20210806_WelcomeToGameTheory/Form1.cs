using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20210806_WelcomeToGameTheory
{
    public partial class Main : Form
    {
        public static TabControl mainTabControl;
        public static TabControl MainTabControl {get { return mainTabControl; } }
        public Main()
        {
            InitializeComponent();
            mainTabControl = tabControl;
        }

        private void newGameMenuItem_Click(object sender, EventArgs e)
        {
            // ヘルプページを作成
            TabPage gamePage = new TabPage();
            CreatePart createPart = new CreatePart();

            String title = "game";
            gamePage.Text = title;

            gamePage.Controls.Add(createPart);
            gamePage.Controls[0].Dock = DockStyle.Fill;
            tabControl.TabPages.Add(gamePage);
            tabControl.SelectedTab = gamePage;
        }
    }
}
