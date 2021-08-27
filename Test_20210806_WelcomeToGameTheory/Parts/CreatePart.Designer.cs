
namespace Test_20210806_WelcomeToGameTheory
{
    partial class CreatePart
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("戦略形(有限)");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("戦略形(無限)");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("戦略形", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("展開形(有限)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("無限繰り返しゲーム");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("展開形", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("非協力ゲーム", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("コア");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("市場ゲーム");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("投票ゲーム");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("シャープレイ値");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("協力ゲーム", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("進化ゲーム");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("ゲーム画面の使い方");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("このアプリについて", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("戦略形");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("展開形");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("非協力ゲーム", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("協力ゲーム");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("進化ゲーム");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("ゲーム理論", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolTree = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.helpTree = new System.Windows.Forms.TreeView();
            this.visualizeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(925, 620);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolTree
            // 
            this.toolTree.AllowDrop = true;
            this.toolTree.BackColor = System.Drawing.Color.White;
            this.toolTree.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toolTree.ItemHeight = 18;
            this.toolTree.Location = new System.Drawing.Point(0, 0);
            this.toolTree.Name = "toolTree";
            treeNode1.BackColor = System.Drawing.Color.Transparent;
            treeNode1.ForeColor = System.Drawing.Color.Red;
            treeNode1.Name = "StForm_finite";
            treeNode1.Tag = "$000";
            treeNode1.Text = "戦略形(有限)";
            treeNode2.Name = "StForm_Infinite";
            treeNode2.Text = "戦略形(無限)";
            treeNode3.Name = "StForm";
            treeNode3.Text = "戦略形";
            treeNode4.Name = "exForm_Finite";
            treeNode4.Text = "展開形(有限)";
            treeNode5.Name = "repeatForm";
            treeNode5.Text = "無限繰り返しゲーム";
            treeNode6.Name = "exForm";
            treeNode6.Tag = "#001";
            treeNode6.Text = "展開形";
            treeNode7.ForeColor = System.Drawing.Color.Black;
            treeNode7.Name = "NonCoop";
            treeNode7.NodeFont = new System.Drawing.Font("メイリオ", 9F);
            treeNode7.Tag = "";
            treeNode7.Text = "非協力ゲーム";
            treeNode8.Name = "core";
            treeNode8.Text = "コア";
            treeNode9.Name = "ノード1";
            treeNode9.Text = "市場ゲーム";
            treeNode10.Name = "ノード2";
            treeNode10.Text = "投票ゲーム";
            treeNode11.Name = "ノード3";
            treeNode11.Text = "シャープレイ値";
            treeNode12.Name = "coop";
            treeNode12.Text = "協力ゲーム";
            treeNode13.Name = "evoGame";
            treeNode13.Text = "進化ゲーム";
            this.toolTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode12,
            treeNode13});
            this.toolTree.Size = new System.Drawing.Size(124, 616);
            this.toolTree.TabIndex = 0;
            this.toolTree.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.toolTree_NodeMouseHover);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(793, 620);
            this.splitContainer2.SplitterDistance = 543;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AllowDrop = true;
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer3.Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitContainer3_Panel1_DragDrop);
            this.splitContainer3.Panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.splitContainer3_Panel1_DragEnter);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.consoleTextBox);
            this.splitContainer3.Size = new System.Drawing.Size(543, 620);
            this.splitContainer3.SplitterDistance = 491;
            this.splitContainer3.TabIndex = 0;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.White;
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTextBox.Enabled = false;
            this.consoleTextBox.Location = new System.Drawing.Point(0, 0);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleTextBox.Size = new System.Drawing.Size(539, 121);
            this.consoleTextBox.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.helpTree);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.AutoScroll = true;
            this.splitContainer4.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer4.Panel2.Controls.Add(this.visualizeBox);
            this.splitContainer4.Panel2MinSize = 0;
            this.splitContainer4.Size = new System.Drawing.Size(246, 620);
            this.splitContainer4.SplitterDistance = 366;
            this.splitContainer4.TabIndex = 0;
            // 
            // helpTree
            // 
            this.helpTree.BackColor = System.Drawing.Color.White;
            this.helpTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpTree.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.helpTree.ItemHeight = 18;
            this.helpTree.Location = new System.Drawing.Point(0, 0);
            this.helpTree.Name = "helpTree";
            treeNode14.ForeColor = System.Drawing.Color.DodgerBlue;
            treeNode14.Name = "gameUsage";
            treeNode14.NodeFont = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            treeNode14.Tag = "#0000";
            treeNode14.Text = "ゲーム画面の使い方";
            treeNode15.ForeColor = System.Drawing.Color.DodgerBlue;
            treeNode15.Name = "aboutThisApp";
            treeNode15.NodeFont = new System.Drawing.Font("メイリオ", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            treeNode15.Tag = "#00";
            treeNode15.Text = "このアプリについて";
            treeNode16.ForeColor = System.Drawing.Color.DodgerBlue;
            treeNode16.Name = "stForm";
            treeNode16.NodeFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            treeNode16.Tag = "#010000";
            treeNode16.Text = "戦略形";
            treeNode17.Name = "exForm";
            treeNode17.Text = "展開形";
            treeNode18.Name = "nonCoop";
            treeNode18.Text = "非協力ゲーム";
            treeNode19.Name = "ノード4";
            treeNode19.Text = "協力ゲーム";
            treeNode20.Name = "ノード5";
            treeNode20.Text = "進化ゲーム";
            treeNode21.Name = "gameTheory";
            treeNode21.Text = "ゲーム理論";
            this.helpTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode21});
            this.helpTree.Size = new System.Drawing.Size(242, 362);
            this.helpTree.TabIndex = 0;
            this.helpTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.helpTree_NodeMouseDoubleClick);
            // 
            // visualizeBox
            // 
            this.visualizeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizeBox.Location = new System.Drawing.Point(0, 0);
            this.visualizeBox.Name = "visualizeBox";
            this.visualizeBox.Size = new System.Drawing.Size(242, 246);
            this.visualizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visualizeBox.TabIndex = 0;
            this.visualizeBox.TabStop = false;
            // 
            // CreatePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreatePart";
            this.Size = new System.Drawing.Size(925, 620);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visualizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView toolTree;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.TreeView helpTree;
        private System.Windows.Forms.PictureBox visualizeBox;
    }
}
