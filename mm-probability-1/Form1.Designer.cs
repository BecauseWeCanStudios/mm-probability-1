namespace mm_probability_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimeSpent21LBL = new System.Windows.Forms.Label();
            this.EstError21LBL = new System.Windows.Forms.Label();
            this.ProbEst21LBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.N21NUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TrueProb21LBL = new System.Windows.Forms.Label();
            this.Calculate21Btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CalculatePointsBtn = new System.Windows.Forms.Button();
            this.TimeSpentPointsLBL = new System.Windows.Forms.Label();
            this.ErrorEstPointsLBL = new System.Windows.Forms.Label();
            this.EstProbPointsLBL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NPointsNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TrueProbPointsLBL = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SegmentLengthTB = new System.Windows.Forms.TextBox();
            this.KCoeffTB = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N21NUD)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPointsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(913, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "21 очко";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TimeSpent21LBL, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.EstError21LBL, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ProbEst21LBL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.N21NUD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TrueProb21LBL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Calculate21Btn, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 429);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // TimeSpent21LBL
            // 
            this.TimeSpent21LBL.AutoSize = true;
            this.TimeSpent21LBL.Location = new System.Drawing.Point(456, 92);
            this.TimeSpent21LBL.Name = "TimeSpent21LBL";
            this.TimeSpent21LBL.Size = new System.Drawing.Size(60, 20);
            this.TimeSpent21LBL.TabIndex = 9;
            this.TimeSpent21LBL.Text = "label14";
            // 
            // EstError21LBL
            // 
            this.EstError21LBL.AutoSize = true;
            this.EstError21LBL.Location = new System.Drawing.Point(456, 72);
            this.EstError21LBL.Name = "EstError21LBL";
            this.EstError21LBL.Size = new System.Drawing.Size(60, 20);
            this.EstError21LBL.TabIndex = 8;
            this.EstError21LBL.Text = "label13";
            // 
            // ProbEst21LBL
            // 
            this.ProbEst21LBL.AutoSize = true;
            this.ProbEst21LBL.Location = new System.Drawing.Point(456, 52);
            this.ProbEst21LBL.Name = "ProbEst21LBL";
            this.ProbEst21LBL.Size = new System.Drawing.Size(60, 20);
            this.ProbEst21LBL.TabIndex = 7;
            this.ProbEst21LBL.Text = "label12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество экспериментов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Затраченное время";
            // 
            // N21NUD
            // 
            this.N21NUD.Location = new System.Drawing.Point(456, 3);
            this.N21NUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.N21NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N21NUD.Name = "N21NUD";
            this.N21NUD.Size = new System.Drawing.Size(120, 26);
            this.N21NUD.TabIndex = 0;
            this.N21NUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ошибка оценки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Истинная вероятность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Оценённая вероятность";
            // 
            // TrueProb21LBL
            // 
            this.TrueProb21LBL.AutoSize = true;
            this.TrueProb21LBL.Location = new System.Drawing.Point(456, 32);
            this.TrueProb21LBL.Name = "TrueProb21LBL";
            this.TrueProb21LBL.Size = new System.Drawing.Size(60, 20);
            this.TrueProb21LBL.TabIndex = 6;
            this.TrueProb21LBL.Text = "label11";
            // 
            // Calculate21Btn
            // 
            this.Calculate21Btn.Location = new System.Drawing.Point(3, 115);
            this.Calculate21Btn.Name = "Calculate21Btn";
            this.Calculate21Btn.Size = new System.Drawing.Size(126, 41);
            this.Calculate21Btn.TabIndex = 10;
            this.Calculate21Btn.Text = "Расчитать";
            this.Calculate21Btn.UseVisualStyleBackColor = true;
            this.Calculate21Btn.Click += new System.EventHandler(this.Calculate21Btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(913, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расстояние между точками";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CalculatePointsBtn, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.TimeSpentPointsLBL, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.ErrorEstPointsLBL, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.EstProbPointsLBL, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.NPointsNUD, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TrueProbPointsLBL, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SegmentLengthTB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.KCoeffTB, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(907, 429);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // CalculatePointsBtn
            // 
            this.CalculatePointsBtn.Location = new System.Drawing.Point(3, 179);
            this.CalculatePointsBtn.Name = "CalculatePointsBtn";
            this.CalculatePointsBtn.Size = new System.Drawing.Size(126, 41);
            this.CalculatePointsBtn.TabIndex = 14;
            this.CalculatePointsBtn.Text = "Расчитать";
            this.CalculatePointsBtn.UseVisualStyleBackColor = true;
            this.CalculatePointsBtn.Click += new System.EventHandler(this.CalculatePointsBtn_Click);
            // 
            // TimeSpentPointsLBL
            // 
            this.TimeSpentPointsLBL.AutoSize = true;
            this.TimeSpentPointsLBL.Location = new System.Drawing.Point(456, 156);
            this.TimeSpentPointsLBL.Name = "TimeSpentPointsLBL";
            this.TimeSpentPointsLBL.Size = new System.Drawing.Size(60, 20);
            this.TimeSpentPointsLBL.TabIndex = 9;
            this.TimeSpentPointsLBL.Text = "label14";
            // 
            // ErrorEstPointsLBL
            // 
            this.ErrorEstPointsLBL.AutoSize = true;
            this.ErrorEstPointsLBL.Location = new System.Drawing.Point(456, 136);
            this.ErrorEstPointsLBL.Name = "ErrorEstPointsLBL";
            this.ErrorEstPointsLBL.Size = new System.Drawing.Size(60, 20);
            this.ErrorEstPointsLBL.TabIndex = 8;
            this.ErrorEstPointsLBL.Text = "label13";
            // 
            // EstProbPointsLBL
            // 
            this.EstProbPointsLBL.AutoSize = true;
            this.EstProbPointsLBL.Location = new System.Drawing.Point(456, 116);
            this.EstProbPointsLBL.Name = "EstProbPointsLBL";
            this.EstProbPointsLBL.Size = new System.Drawing.Size(60, 20);
            this.EstProbPointsLBL.TabIndex = 7;
            this.EstProbPointsLBL.Text = "label12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Количество экспериментов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Затраченное время";
            // 
            // NPointsNUD
            // 
            this.NPointsNUD.Location = new System.Drawing.Point(456, 3);
            this.NPointsNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NPointsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NPointsNUD.Name = "NPointsNUD";
            this.NPointsNUD.Size = new System.Drawing.Size(120, 26);
            this.NPointsNUD.TabIndex = 0;
            this.NPointsNUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ошибка оценки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Истинная вероятность";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Оценённая вероятность";
            // 
            // TrueProbPointsLBL
            // 
            this.TrueProbPointsLBL.AutoSize = true;
            this.TrueProbPointsLBL.Location = new System.Drawing.Point(456, 96);
            this.TrueProbPointsLBL.Name = "TrueProbPointsLBL";
            this.TrueProbPointsLBL.Size = new System.Drawing.Size(60, 20);
            this.TrueProbPointsLBL.TabIndex = 6;
            this.TrueProbPointsLBL.Text = "label11";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Длина отрезка";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Коэффициент k";
            // 
            // SegmentLengthTB
            // 
            this.SegmentLengthTB.Location = new System.Drawing.Point(456, 35);
            this.SegmentLengthTB.Name = "SegmentLengthTB";
            this.SegmentLengthTB.Size = new System.Drawing.Size(100, 26);
            this.SegmentLengthTB.TabIndex = 12;
            this.SegmentLengthTB.Text = "1";
            // 
            // KCoeffTB
            // 
            this.KCoeffTB.Location = new System.Drawing.Point(456, 67);
            this.KCoeffTB.Name = "KCoeffTB";
            this.KCoeffTB.Size = new System.Drawing.Size(100, 26);
            this.KCoeffTB.TabIndex = 13;
            this.KCoeffTB.Text = "0.5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Математическое моделирование. ЛР №7";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N21NUD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPointsNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown N21NUD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TimeSpent21LBL;
        private System.Windows.Forms.Label EstError21LBL;
        private System.Windows.Forms.Label ProbEst21LBL;
        private System.Windows.Forms.Label TrueProb21LBL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label TimeSpentPointsLBL;
        private System.Windows.Forms.Label ErrorEstPointsLBL;
        private System.Windows.Forms.Label EstProbPointsLBL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NPointsNUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TrueProbPointsLBL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox SegmentLengthTB;
        private System.Windows.Forms.TextBox KCoeffTB;
        private System.Windows.Forms.Button Calculate21Btn;
        private System.Windows.Forms.Button CalculatePointsBtn;
    }
}

