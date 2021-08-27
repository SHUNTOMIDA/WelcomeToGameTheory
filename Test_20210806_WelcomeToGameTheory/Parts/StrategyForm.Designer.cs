
namespace Test_20210806_WelcomeToGameTheory
{
    partial class StrategyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrategyForm));
            this.profitMatrixTable = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.p1_0_TextBox = new System.Windows.Forms.TextBox();
            this.p1_1_TextBox = new System.Windows.Forms.TextBox();
            this.p1Box = new System.Windows.Forms.GroupBox();
            this.p2Box = new System.Windows.Forms.GroupBox();
            this.p2_0_TextBox = new System.Windows.Forms.TextBox();
            this.p2_1_TextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NashButton = new System.Windows.Forms.ToolStripButton();
            this.visualizeButton = new System.Windows.Forms.ToolStripButton();
            this.profitMatrixTable.SuspendLayout();
            this.p1Box.SuspendLayout();
            this.p2Box.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profitMatrixTable
            // 
            this.profitMatrixTable.ColumnCount = 2;
            this.profitMatrixTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.profitMatrixTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.profitMatrixTable.Controls.Add(this.textBox3, 0, 1);
            this.profitMatrixTable.Controls.Add(this.textBox2, 1, 0);
            this.profitMatrixTable.Controls.Add(this.textBox4, 1, 1);
            this.profitMatrixTable.Controls.Add(this.textBox1, 0, 0);
            this.profitMatrixTable.Location = new System.Drawing.Point(144, 109);
            this.profitMatrixTable.Name = "profitMatrixTable";
            this.profitMatrixTable.RowCount = 2;
            this.profitMatrixTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.profitMatrixTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.profitMatrixTable.Size = new System.Drawing.Size(324, 114);
            this.profitMatrixTable.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("メイリオ", 12F);
            this.textBox3.Location = new System.Drawing.Point(3, 60);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 51);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "1,-1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("メイリオ", 12F);
            this.textBox2.Location = new System.Drawing.Point(165, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 51);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "1,-1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("メイリオ", 12F);
            this.textBox4.Location = new System.Drawing.Point(165, 60);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 51);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "-1,1";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 51);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "-1,1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p1_0_TextBox
            // 
            this.p1_0_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_0_TextBox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.p1_0_TextBox.Location = new System.Drawing.Point(10, 35);
            this.p1_0_TextBox.Name = "p1_0_TextBox";
            this.p1_0_TextBox.Size = new System.Drawing.Size(92, 24);
            this.p1_0_TextBox.TabIndex = 1;
            this.p1_0_TextBox.Tag = "0";
            this.p1_0_TextBox.Text = "表";
            this.p1_0_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p1_1_TextBox
            // 
            this.p1_1_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_1_TextBox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.p1_1_TextBox.Location = new System.Drawing.Point(10, 85);
            this.p1_1_TextBox.Name = "p1_1_TextBox";
            this.p1_1_TextBox.Size = new System.Drawing.Size(92, 24);
            this.p1_1_TextBox.TabIndex = 2;
            this.p1_1_TextBox.Tag = "1";
            this.p1_1_TextBox.Text = "裏";
            this.p1_1_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p1Box
            // 
            this.p1Box.BackColor = System.Drawing.Color.Red;
            this.p1Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p1Box.Controls.Add(this.p1_0_TextBox);
            this.p1Box.Controls.Add(this.p1_1_TextBox);
            this.p1Box.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.p1Box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p1Box.Location = new System.Drawing.Point(10, 99);
            this.p1Box.Name = "p1Box";
            this.p1Box.Size = new System.Drawing.Size(119, 124);
            this.p1Box.TabIndex = 2;
            this.p1Box.TabStop = false;
            this.p1Box.Text = "A";
            // 
            // p2Box
            // 
            this.p2Box.BackColor = System.Drawing.Color.Blue;
            this.p2Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p2Box.Controls.Add(this.p2_0_TextBox);
            this.p2Box.Controls.Add(this.p2_1_TextBox);
            this.p2Box.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.p2Box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2Box.Location = new System.Drawing.Point(147, 28);
            this.p2Box.Name = "p2Box";
            this.p2Box.Size = new System.Drawing.Size(318, 56);
            this.p2Box.TabIndex = 2;
            this.p2Box.TabStop = false;
            this.p2Box.Text = "B";
            // 
            // p2_0_TextBox
            // 
            this.p2_0_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_0_TextBox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.p2_0_TextBox.Location = new System.Drawing.Point(28, 22);
            this.p2_0_TextBox.Name = "p2_0_TextBox";
            this.p2_0_TextBox.Size = new System.Drawing.Size(92, 24);
            this.p2_0_TextBox.TabIndex = 1;
            this.p2_0_TextBox.Tag = "0";
            this.p2_0_TextBox.Text = "表";
            this.p2_0_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2_1_TextBox
            // 
            this.p2_1_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_1_TextBox.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.p2_1_TextBox.Location = new System.Drawing.Point(188, 22);
            this.p2_1_TextBox.Name = "p2_1_TextBox";
            this.p2_1_TextBox.Size = new System.Drawing.Size(92, 24);
            this.p2_1_TextBox.TabIndex = 1;
            this.p2_1_TextBox.Tag = "1";
            this.p2_1_TextBox.Text = "裏";
            this.p2_1_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Azure;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NashButton,
            this.visualizeButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NashButton
            // 
            this.NashButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NashButton.ForeColor = System.Drawing.Color.Black;
            this.NashButton.Image = ((System.Drawing.Image)(resources.GetObject("NashButton.Image")));
            this.NashButton.ImageTransparentColor = System.Drawing.Color.Linen;
            this.NashButton.Name = "NashButton";
            this.NashButton.Size = new System.Drawing.Size(23, 22);
            this.NashButton.Text = "P";
            this.NashButton.Click += new System.EventHandler(this.NashButton_Click);
            // 
            // visualizeButton
            // 
            this.visualizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.visualizeButton.ForeColor = System.Drawing.Color.Black;
            this.visualizeButton.Image = ((System.Drawing.Image)(resources.GetObject("visualizeButton.Image")));
            this.visualizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(23, 22);
            this.visualizeButton.Text = "V";
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // StrategyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.p2Box);
            this.Controls.Add(this.p1Box);
            this.Controls.Add(this.profitMatrixTable);
            this.Name = "StrategyForm";
            this.Size = new System.Drawing.Size(497, 255);
            this.profitMatrixTable.ResumeLayout(false);
            this.profitMatrixTable.PerformLayout();
            this.p1Box.ResumeLayout(false);
            this.p1Box.PerformLayout();
            this.p2Box.ResumeLayout(false);
            this.p2Box.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel profitMatrixTable;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox p1_0_TextBox;
        private System.Windows.Forms.TextBox p1_1_TextBox;
        private System.Windows.Forms.GroupBox p1Box;
        private System.Windows.Forms.GroupBox p2Box;
        private System.Windows.Forms.TextBox p2_0_TextBox;
        private System.Windows.Forms.TextBox p2_1_TextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NashButton;
        private System.Windows.Forms.ToolStripButton visualizeButton;
    }
}
