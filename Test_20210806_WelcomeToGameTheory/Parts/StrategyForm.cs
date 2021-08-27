using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;

namespace Test_20210806_WelcomeToGameTheory
{
    public partial class StrategyForm : UserControl
    {
        CreatePart create;
        string[] players;   // playerの名前を格納した配列
        int N;                              // playerの人数を格納した配列
        string[][] S;                   // playerの戦略を格納した配列
        int[,,] profitMatrix;               // profitMatrix[player,player1の戦略,player2の戦略]
        string[] S1;
        string[] S2;
        string[] DomiSt, WDomiSt;

        public StrategyForm(CreatePart create)
        {
            InitializeComponent();
            this.create = create;
            p1Box.DoubleClick += playerBox_DoubleClick;
            p2Box.DoubleClick += playerBox_DoubleClick;
        }

        private void playerBox_DoubleClick(object sender, EventArgs e)
        {
            string playerName = Interaction.InputBox("プレイヤー名を入力してください。");
            ((GroupBox)sender).Text = playerName;
        }

        private void NashButton_Click(object sender, EventArgs e)
        {
            // 必要な値を代入する
            Substitution2();

            // 利得行列を読み込む
            ReadProfitMatrix2();

            // 
            AddSeparate();

            //支配戦略を求める
            FindDominantStrategy();


            if (DomiSt.All(dominant => dominant != ""))
            {
                string str = create.ConsoleBox.Text;
                create.ConsoleBox.Text = "ナッシュ均衡は(" + DomiSt[0] + "," + DomiSt[1] + ")です。" + "\r\n" + str;

                return;
            }
            else if(DomiSt.Any(dominant => dominant != ""))
            {
                //ナッシュ均衡を求める();
                FindPureNashequilibrium();

                return;
            }
            else if(WDomiSt.All(dominant => dominant != ""))
            {
                string str = create.ConsoleBox.Text;
                create.ConsoleBox.Text = "ナッシュ均衡は(" + WDomiSt[0] + "," + WDomiSt[1] + ")です。" + "\r\n" + str;

                return;
            }
            else if(WDomiSt.Any(dominant => dominant != ""))
            {
                //ナッシュ均衡を求める();
                FindPureNashequilibrium();

                return;
            }

            //ナッシュ均衡を求める();
            FindPureNashequilibrium();

            // 混合戦略のナッシュ均衡を求める
            FindMixedNashequilibrium();


        }

        private void Substitution2()
        {
            // 利得行列の行と列を代入
            // (行の数) = (player1の戦略の数)
            // (列の数) = (player2の戦略の数)
            S1 = new string[profitMatrixTable.RowCount];
            S2 = new string[profitMatrixTable.ColumnCount];

            // プレイヤーの名前を代入
            players = new string[2];
            players[0] = p1Box.Text;
            players[1] = p2Box.Text;

            // プレイヤーの人数を代入
            N = players.Length;

            // プレイヤー1の戦略の代入
            try
            {
                S1[0] = p1Box.Controls[0].Text;
                S1[1] = p1Box.Controls[1].Text;
            }
            catch (ArgumentNullException) when (S1[0] == null || S1[1] == null || S1[0] == "" || S1[1] == "")
            {
                MessageBox.Show("戦略を記入してください。");
            }

            // プレイヤー2の戦略の代入
            try
            {
                S2[0] = p2Box.Controls[0].Text;
                S2[1] = p2Box.Controls[1].Text;
            }
            catch(ArgumentNullException) when (S2[0] == null || S2[1] == null || S2[0] == "" || S2[1] == "")
            {
                MessageBox.Show("戦略を記入してください。");
            }

            S = new string[][] { S1, S2 };
        }

        private void ReadProfitMatrix2()
        {
            int p1StNum = profitMatrixTable.RowCount;
            int p2StNum = profitMatrixTable.ColumnCount;

            profitMatrix = new int[p1StNum, p2StNum, N];

            // profitMatrixPanelの各cellのテキストを配列で取得
            string[,] ReadCells = new string[p1StNum, p2StNum];

            for (int ind_i = 0; ind_i < ReadCells.GetLength(0); ind_i++)
            {
                for (int ind_j = 0; ind_j < ReadCells.GetLength(1); ind_j++)
                {
                    try
                    {
                        ReadCells[ind_i, ind_j] = profitMatrixTable.GetControlFromPosition(ind_j, ind_i).Text;
                    }
                    catch(FormatException) when (!Regex.IsMatch(ReadCells[ind_i, ind_j], "[+-][1-9]+,[+-][1-9]+"))
                    {
                        MessageBox.Show("入力値を確認してください。");
                    }

                }
            }

            // 利得行列の値を代入
            for (int ind_i = 0; ind_i < profitMatrix.GetLength(0); ind_i++)
            {
                for (int ind_j = 0; ind_j < profitMatrix.GetLength(1); ind_j++)
                {
                    string[] profits = ReadCells[ind_i, ind_j].Split(',');
                    for (int ind_k = 0; ind_k < profitMatrix.GetLength(2); ind_k++)
                    {
                        profitMatrix[ind_i, ind_j, ind_k] = int.Parse(profits[ind_k]);
                    }
                }
            }
        }

        private void FindDominantStrategy()
        {

            // それぞれのプレイヤーを表す整数値
            int p1 = 0;
            int p2 = 1;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // p1が利得行列を比較する用の変数
            int[] p1Pro = new int[profitMatrix.GetLength(0)];
            bool[] p1DomJudge = new bool[profitMatrix.GetLength(1)];//p1ComSt[0] > p1ComSt[1]を比較した結果が入る
            bool[] p1WDomJudge = new bool[profitMatrix.GetLength(1)];
            int[] DomSt = new int[profitMatrix.GetLength(2)];

            // 利得行列を比較
            for (int p2St = 0; p2St < profitMatrix.GetLength(1); p2St++)
            {
                for (int p1St = 0; p1St < profitMatrix.GetLength(0); p1St++)
                {
                    p1Pro[p1St] = profitMatrix[p1St, p2St, p1];
                }

                // p2Stを固定して、p1の利得を比較する。
                if (p1Pro[0] > p1Pro[1])
                {
                    p1DomJudge[p2St] = true;
                }
                else
                {
                    p1DomJudge[p2St] = false;
                }

                // p2Stを固定して、p1の利得を比較する。
                if (p1Pro[0] >= p1Pro[1])
                {
                    p1WDomJudge[p2St] = true;
                }
                else
                {
                    p1WDomJudge[p2St] = false;
                }
            }

            string p1Dom = "";
            string p1WDom = "";

            // 支配戦略を代入

            // a1 > a2 ,a3 > a4の比較
            if (p1DomJudge.All(boolvalue => boolvalue == true)) p1Dom = S1[0];

            // a1 < a2 ,a3 < a4の比較
            if (p1WDomJudge.All(boolvalue => boolvalue == false)) p1Dom = S1[1];

            // a1 >= a2 ,a3 >= a4の比較
            if (p1WDomJudge.All(boolvalue => boolvalue == true) && p1DomJudge.Any(boolvalue => boolvalue == true)) p1WDom = S1[0];

            // a1 <= a2 ,a3 <= a4の比較
            if (p1DomJudge.All(boolvalue => boolvalue == false) && p1DomJudge.Any(boolvalue => boolvalue == false)) p1WDom = S1[1];

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // p1が利得行列を比較する用の変数
            int[] p2Pro = new int[profitMatrix.GetLength(0)];
            bool[] p2DomJudge = new bool[profitMatrix.GetLength(0)];//p2ComSt[0] > p2ComSt[1]を比較した結果が入る
            bool[] p2WDomJudge = new bool[profitMatrix.GetLength(0)];

            for (int p1St = 0; p1St < profitMatrix.GetLength(1); p1St++)
            {
                for (int p2St = 0; p2St < profitMatrix.GetLength(1); p2St++)
                {
                    p2Pro[p2St] = profitMatrix[p1St, p2St, p2];
                }

                // 支配関係を見る。
                // p2Stを固定して、p1の利得を比較する。
                if (p2Pro[0] > p2Pro[1])
                {
                    p2DomJudge[p1St] = true;
                }
                else
                {
                    p2DomJudge[p1St] = false;
                }

                // 弱支配関係を見る。
                // p2Stを固定して、p1の利得を比較する。
                if (p2Pro[0] >= p2Pro[1])
                {
                    p2WDomJudge[p1St] = true;
                }
                else
                {
                    p2WDomJudge[p1St] = false;
                }
            }

            string p2Dom = "";
            string p2WDom = "";

            // 支配戦略の存在判定
            // b1 > b2 ,b3 > b4の比較
            if (p2DomJudge.All(boolvalue => boolvalue == true)) p2Dom = S2[0];

            // b1 < b2 ,b3 < b4の比較
            if (p2WDomJudge.All(boolvalue => boolvalue == false))
                p2Dom = S2[1];

            // 弱支配戦略の存在判定
            // b1 >= b2 ,b3 >= b4の比較
            if (p2WDomJudge.All(boolvalue => boolvalue == true) && p2DomJudge.Any(boolvalue => boolvalue == true))
                p2WDom = S2[0];

            // b1 <= b2 ,b3 <= b4の比較
            if (p2DomJudge.All(boolvalue => boolvalue == false) && p2DomJudge.Any(boolvalue => boolvalue == false))
                p2WDom = S2[1];


            DomiSt = new string []{ p1Dom, p2Dom };
            WDomiSt = new string[] { p1WDom, p2WDom };

            for (int p = 0; p < profitMatrix.GetLength(2); p++)
            {
                if (S[p].Any(s => s == DomiSt[p]))
                {
                    string str = create.ConsoleBox.Text;
                    create.ConsoleBox.Text = "player" + players[p] + "の支配戦略は" + DomiSt[p] + "です。" + "\r\n" + str;
                }
                else if (S[p].Any(s => s == WDomiSt[p]))
                {
                    string str = create.ConsoleBox.Text;
                    create.ConsoleBox.Text = "player" + players[p] + "の弱支配戦略は" + WDomiSt[p] + "です。" + "\r\n" + str;
                }
            }
        }

        private void FindPureNashequilibrium()
        {
            // 比較する2つの利得を入れる配列。
            int[] comProfit = new int[2];
            // nash均衡かを判断する配列
            bool[,] nashJudge =
                new bool[profitMatrix.GetLength(0), profitMatrix.GetLength(1)];

            for (int p1St = 0; p1St < profitMatrix.GetLength(0); p1St++)
            {
                for (int p2St = 0; p2St < profitMatrix.GetLength(1); p2St++)
                {
                    int BSJudgeNum = (profitMatrix.GetLength(0) - 1) + (profitMatrix.GetLength(1) - 1);
                    bool[] BSJudge = new bool[BSJudgeNum];

                    for (int p = 0; p < profitMatrix.GetLength(2); p++)
                    {
                        comProfit[0] = profitMatrix[p1St, p2St, p];
                        BSJudge[p] = false;
                        if (p == 0)
                        {
                            int varSt = p1St;
                            if (p1St == 0) varSt = 1;
                            else if (p1St == 1) varSt = 0;

                            comProfit[1] = profitMatrix[varSt, p2St, p];

                        }
                        if (p == 1)
                        {
                            int varSt = p2St;
                            if (p2St == 0) varSt = 1;
                            else if (p2St == 1) varSt = 0;

                            comProfit[1] = profitMatrix[p1St, varSt, p];
                        }

                        // 誰か一人のプレイヤーの戦略を替えても利得が高くならないことを示す。
                        if (comProfit[0] >= comProfit[1])
                        {
                            BSJudge[p] = true;
                        }
                    }
                    if (BSJudge.All(judge => judge == true))
                    {
                        nashJudge[p1St, p2St] = true;
                    }
                }
            }

            for (int p1St = 0; p1St < profitMatrix.GetLength(0); p1St++)
            {
                for (int p2St = 0; p2St < profitMatrix.GetLength(1); p2St++)
                {
                    if (nashJudge[p1St, p2St] == true)
                    {
                        string str = create.ConsoleBox.Text;
                        create.ConsoleBox.Text = "戦略の組(" + S1[p1St] + "," + S2[p2St] + ")はナッシュ均衡です。" + "\r\n" + str;
                    }
                }
            }
        }

        private void FindMixedNashequilibrium()
        {
            // それぞれのプレイヤーを表す整数値
            int p1 = 0;
            int p2 = 1;

            double u1, v1, u2, v2;
            double q11,q12,q21,q22;

            u1 = (double)profitMatrix[0, 0, p1] - (double)profitMatrix[1, 0, p1];
            v1 = (double)profitMatrix[1, 1, p1] - (double)profitMatrix[0, 1, p1];

            u2 = (double)profitMatrix[0, 0, p2] - (double)profitMatrix[0, 1, p2];
            v2 = (double)profitMatrix[1, 1, p2] - (double)profitMatrix[1, 0, p2];

            q11 = v2 / (u2 + v2);
            q12 = u2 / (u2 + v2);
            q21 = v1 / (u1 + v1);
            q22 = u1 / (u1 + v1);

            string str = create.ConsoleBox.Text;
            create.ConsoleBox.Text = "混合戦略の組q1 = (" + q11.ToString("0.00") + "," + q12.ToString("0.00") + ")," +
                "q2 = (" + q21.ToString("0.00") + "," + q22.ToString("0.00") + ")" + "はナッシュ均衡です。" + "\r\n" + str;
        }



        private void AddSeparate()
        {
            string str = create.ConsoleBox.Text;

            if (str == "") return;
            create.ConsoleBox.Text = "---------------------------------------------------------------------------------------\r\n" + str;
        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            // 代入
            Substitution2();

            // 利得行列を読み込む
            ReadProfitMatrix2();

            // 骨組み作成の描画
            // VisualizePanelと同じ大きさのビットマップオブジェクトを作成
            Bitmap canvas = new Bitmap(250, 250);

            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);
            VisualizeFrame(canvas,g);


            // 支配戦略があるかどうか
            bool existDomi = IsThereDomi();
            
            if (existDomi)
            {
                // 支配戦略があるときの描画
                VisualizeDomi();
            }
            else
            {
                // 支配戦略がないときの描画
                // 境界値
                double[] pros = getProbabilties();
                VisualizeBS(pros);
            }

            g.Dispose();


        }

        private double[] getProbabilties()
        {
            // それぞれのプレイヤーを表す整数値
            int p1 = 0;
            int p2 = 1;

            double u1, v1, u2, v2;
            double q11, q12, q21, q22;

            u1 = (double)profitMatrix[0, 0, p1] - (double)profitMatrix[1, 0, p1];
            v1 = (double)profitMatrix[1, 1, p1] - (double)profitMatrix[0, 1, p1];

            u2 = (double)profitMatrix[0, 0, p2] - (double)profitMatrix[0, 1, p2];
            v2 = (double)profitMatrix[1, 1, p2] - (double)profitMatrix[1, 0, p2];

            q11 = v2 / (u2 + v2);
            q12 = u2 / (u2 + v2);
            q21 = v1 / (u1 + v1);
            q22 = u1 / (u1 + v1);

            return new double[] { q11, q21 };
        }

        private bool IsThereDomi()
        {
            bool existDomi = false;

            // それぞれのプレイヤーを表す整数値
            int p1 = 0;
            int p2 = 1;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // p1が利得行列を比較する用の変数
            int[] p1Pro = new int[profitMatrix.GetLength(0)];
            bool[] p1DomJudge = new bool[profitMatrix.GetLength(1)];//p1ComSt[0] > p1ComSt[1]を比較した結果が入る
            bool[] p1WDomJudge = new bool[profitMatrix.GetLength(1)];
            int[] DomSt = new int[profitMatrix.GetLength(2)];

            // 利得行列を比較
            for (int p2St = 0; p2St < profitMatrix.GetLength(1); p2St++)
            {
                for (int p1St = 0; p1St < profitMatrix.GetLength(0); p1St++)
                {
                    p1Pro[p1St] = profitMatrix[p1St, p2St, p1];
                }

                // p2Stを固定して、p1の利得を比較する。
                if (p1Pro[0] > p1Pro[1])
                {
                    p1DomJudge[p2St] = true;
                }
                else
                {
                    p1DomJudge[p2St] = false;
                }

                // p2Stを固定して、p1の利得を比較する。
                if (p1Pro[0] >= p1Pro[1])
                {
                    p1WDomJudge[p2St] = true;
                }
                else
                {
                    p1WDomJudge[p2St] = false;
                }
            }

            string p1Dom = "";
            string p1WDom = "";

            // 支配戦略を代入

            // a1 > a2 ,a3 > a4の比較
            if (p1DomJudge.All(boolvalue => boolvalue == true))
            {
                p1Dom = S1[0];
                existDomi = true;
            }

            // a1 < a2 ,a3 < a4の比較
            if (p1WDomJudge.All(boolvalue => boolvalue == false))
            {
                p1Dom = S1[1];
                existDomi = true;
            }
                
            // a1 >= a2 ,a3 >= a4の比較
            if (p1WDomJudge.All(boolvalue => boolvalue == true) && p1DomJudge.Any(boolvalue => boolvalue == true))
            {
                p1WDom = S1[0];
                existDomi = true;
            }
                
            // a1 <= a2 ,a3 <= a4の比較
            if (p1DomJudge.All(boolvalue => boolvalue == false) && p1DomJudge.Any(boolvalue => boolvalue == false))
            {
                p1WDom = S1[1];
                existDomi = true;
            }
                

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // p1が利得行列を比較する用の変数
            int[] p2Pro = new int[profitMatrix.GetLength(0)];
            bool[] p2DomJudge = new bool[profitMatrix.GetLength(0)];//p2ComSt[0] > p2ComSt[1]を比較した結果が入る
            bool[] p2WDomJudge = new bool[profitMatrix.GetLength(0)];

            for (int p1St = 0; p1St < profitMatrix.GetLength(1); p1St++)
            {
                for (int p2St = 0; p2St < profitMatrix.GetLength(1); p2St++)
                {
                    p2Pro[p2St] = profitMatrix[p1St, p2St, p2];
                }

                // 支配関係を見る。
                // p2Stを固定して、p1の利得を比較する。
                if (p2Pro[0] > p2Pro[1])
                {
                    p2DomJudge[p1St] = true;
                }
                else
                {
                    p2DomJudge[p1St] = false;
                }

                // 弱支配関係を見る。
                // p2Stを固定して、p1の利得を比較する。
                if (p2Pro[0] >= p2Pro[1])
                {
                    p2WDomJudge[p1St] = true;
                }
                else
                {
                    p2WDomJudge[p1St] = false;
                }
            }

            string p2Dom = "";
            string p2WDom = "";

            // 支配戦略の存在判定
            // b1 > b2 ,b3 > b4の比較
            if (p2DomJudge.All(boolvalue => boolvalue == true))
            {
                p2Dom = S2[0];
                existDomi = true;
            }
                
            // b1 < b2 ,b3 < b4の比較
            if (p2WDomJudge.All(boolvalue => boolvalue == false))
            {
                p2Dom = S2[1];
                existDomi = true;
            }
                

            // 弱支配戦略の存在判定
            // b1 >= b2 ,b3 >= b4の比較
            if (p2WDomJudge.All(boolvalue => boolvalue == true) && p2DomJudge.Any(boolvalue => boolvalue == true))
            {
                p2WDom = S2[0];
                existDomi = true;
            }
                
            // b1 <= b2 ,b3 <= b4の比較
            if (p2DomJudge.All(boolvalue => boolvalue == false) && p2DomJudge.Any(boolvalue => boolvalue == false))
            {
                p2WDom = S2[1];
                existDomi = true;
            }

            DomiSt = new string[] { p1Dom, p2Dom };
            WDomiSt = new string[] { p1WDom, p2WDom };

            return existDomi;
        }

        private void VisualizeFrame(Bitmap canvas, Graphics g)
        {
            ////penの作成////
            Pen blackPen = new Pen(Color.Black, 1);
            Pen arrowPen = new Pen(Color.Black, 1);
            Pen boldPen = new Pen(Color.Black, 3);

            // arrowPenの終点を矢印化
            AdjustableArrowCap myArrow = new AdjustableArrowCap(3, 3, false);
            arrowPen.CustomEndCap = myArrow;

            ////位置の指定////
            //矢印の位置指定
            Point arrowFrom = new Point(10, canvas.Height - 10);
            Point arrowToLeftTop = new Point(10, 20);
            Point arrowToRightButtom = new Point(canvas.Width - 20, canvas.Height - 10);

            //四角形の位置指定
            Point rectFromLeftTop = new Point(10, 30);
            Point rectFromRightButtom = new Point(canvas.Width - 30, canvas.Height - 10);
            Point rectToRightTop = new Point(canvas.Width - 30, 30);

            ////外枠の作成////
            // 矢印部分の描画
            g.DrawLine(arrowPen, arrowFrom, arrowToLeftTop);
            g.DrawLine(arrowPen, arrowFrom, arrowToRightButtom);

            // 四角形部分の描画
            g.DrawLine(blackPen, rectFromLeftTop, rectToRightTop);
            g.DrawLine(blackPen, rectFromRightButtom, rectToRightTop);

            //PictureBox1に表示する
            create.VisualizeBox.Image = canvas;
        }

        private void VisualizeBS(double[] pros)
        {

            //double p1_st0_Profit = 
            //double p1_st1_Profit = 
        }

        private void VisualizeDomi()
        {
            // 支配戦略を特定する

            
        }
    }
}
