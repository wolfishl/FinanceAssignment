namespace Finance
{
    partial class PnLReport
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.portfolioValueLbl = new System.Windows.Forms.Label();
            this.portfolioValueTxtBox = new System.Windows.Forms.TextBox();
            this.rtuMoveLbl = new System.Windows.Forms.Label();
            this.rtuMoveTxtBox = new System.Windows.Forms.TextBox();
            this.predictedPnLLbl = new System.Windows.Forms.Label();
            this.tickersLbl = new System.Windows.Forms.Label();
            this.tickerLbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.qtyLbl1 = new System.Windows.Forms.Label();
            this.qtyLbl2 = new System.Windows.Forms.Label();
            this.qtyLbl3 = new System.Windows.Forms.Label();
            this.qtyLbl4 = new System.Windows.Forms.Label();
            this.qtyLbl5 = new System.Windows.Forms.Label();
            this.valueLbl = new System.Windows.Forms.Label();
            this.valueLbl1 = new System.Windows.Forms.Label();
            this.valueLbl2 = new System.Windows.Forms.Label();
            this.valueLbl3 = new System.Windows.Forms.Label();
            this.valueLbl4 = new System.Windows.Forms.Label();
            this.valueLbl5 = new System.Windows.Forms.Label();
            this.betaLabel = new System.Windows.Forms.Label();
            this.betaLbl1 = new System.Windows.Forms.Label();
            this.betaLbl2 = new System.Windows.Forms.Label();
            this.betaLbl3 = new System.Windows.Forms.Label();
            this.betaLbl4 = new System.Windows.Forms.Label();
            this.betaLbl5 = new System.Windows.Forms.Label();
            this.correlationLabel = new System.Windows.Forms.Label();
            this.predictedMoveLbl = new System.Windows.Forms.Label();
            this.PnLLabel = new System.Windows.Forms.Label();
            this.corrLbl1 = new System.Windows.Forms.Label();
            this.corrLbl2 = new System.Windows.Forms.Label();
            this.corrLbl3 = new System.Windows.Forms.Label();
            this.corrLbl4 = new System.Windows.Forms.Label();
            this.corrLbl5 = new System.Windows.Forms.Label();
            this.predMovLbl1 = new System.Windows.Forms.Label();
            this.predMoveLbl2 = new System.Windows.Forms.Label();
            this.predMoveLbl3 = new System.Windows.Forms.Label();
            this.predMoveLbl4 = new System.Windows.Forms.Label();
            this.predMoveLbl5 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Label();
            this.pnl3 = new System.Windows.Forms.Label();
            this.pnl4 = new System.Windows.Forms.Label();
            this.pnl5 = new System.Windows.Forms.Label();
            this.predictedTotalPnL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // portfolioValueLbl
            // 
            this.portfolioValueLbl.AutoSize = true;
            this.portfolioValueLbl.Location = new System.Drawing.Point(211, 9);
            this.portfolioValueLbl.Name = "portfolioValueLbl";
            this.portfolioValueLbl.Size = new System.Drawing.Size(78, 13);
            this.portfolioValueLbl.TabIndex = 2;
            this.portfolioValueLbl.Text = "Portfolio Value:";
            // 
            // portfolioValueTxtBox
            // 
            this.portfolioValueTxtBox.Location = new System.Drawing.Point(214, 25);
            this.portfolioValueTxtBox.Name = "portfolioValueTxtBox";
            this.portfolioValueTxtBox.Size = new System.Drawing.Size(100, 20);
            this.portfolioValueTxtBox.TabIndex = 3;
            this.portfolioValueTxtBox.TextChanged += new System.EventHandler(this.portfolioValueTxtBox_TextChanged);
            // 
            // rtuMoveLbl
            // 
            this.rtuMoveLbl.AutoSize = true;
            this.rtuMoveLbl.Location = new System.Drawing.Point(330, 9);
            this.rtuMoveLbl.Name = "rtuMoveLbl";
            this.rtuMoveLbl.Size = new System.Drawing.Size(63, 13);
            this.rtuMoveLbl.TabIndex = 4;
            this.rtuMoveLbl.Text = "RTU Move:";
            // 
            // rtuMoveTxtBox
            // 
            this.rtuMoveTxtBox.Location = new System.Drawing.Point(333, 25);
            this.rtuMoveTxtBox.Name = "rtuMoveTxtBox";
            this.rtuMoveTxtBox.Size = new System.Drawing.Size(100, 20);
            this.rtuMoveTxtBox.TabIndex = 5;
            this.rtuMoveTxtBox.TextChanged += new System.EventHandler(this.rtuMoveTxtBox_TextChanged);
            // 
            // predictedPnLLbl
            // 
            this.predictedPnLLbl.AutoSize = true;
            this.predictedPnLLbl.Location = new System.Drawing.Point(463, 9);
            this.predictedPnLLbl.Name = "predictedPnLLbl";
            this.predictedPnLLbl.Size = new System.Drawing.Size(77, 13);
            this.predictedPnLLbl.TabIndex = 6;
            this.predictedPnLLbl.Text = "Predicted PnL:";
            // 
            // tickersLbl
            // 
            this.tickersLbl.AutoSize = true;
            this.tickersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickersLbl.Location = new System.Drawing.Point(12, 66);
            this.tickersLbl.Name = "tickersLbl";
            this.tickersLbl.Size = new System.Drawing.Size(49, 13);
            this.tickersLbl.TabIndex = 9;
            this.tickersLbl.Text = "Tickers";
            this.tickersLbl.Click += new System.EventHandler(this.tickersLbl_Click);
            // 
            // tickerLbl1
            // 
            this.tickerLbl1.AutoSize = true;
            this.tickerLbl1.Location = new System.Drawing.Point(9, 88);
            this.tickerLbl1.Name = "tickerLbl1";
            this.tickerLbl1.Size = new System.Drawing.Size(46, 13);
            this.tickerLbl1.TabIndex = 10;
            this.tickerLbl1.Text = "Ticker 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ticker 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ticker 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ticker 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ticker 5";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(92, 66);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(54, 13);
            this.quantityLbl.TabIndex = 16;
            this.quantityLbl.Text = "Quantity";
            this.quantityLbl.Click += new System.EventHandler(this.quantityLbl_Click);
            // 
            // qtyLbl1
            // 
            this.qtyLbl1.AutoSize = true;
            this.qtyLbl1.Location = new System.Drawing.Point(92, 88);
            this.qtyLbl1.Name = "qtyLbl1";
            this.qtyLbl1.Size = new System.Drawing.Size(55, 13);
            this.qtyLbl1.TabIndex = 17;
            this.qtyLbl1.Text = "Quantity 1";
            // 
            // qtyLbl2
            // 
            this.qtyLbl2.AutoSize = true;
            this.qtyLbl2.Location = new System.Drawing.Point(92, 113);
            this.qtyLbl2.Name = "qtyLbl2";
            this.qtyLbl2.Size = new System.Drawing.Size(55, 13);
            this.qtyLbl2.TabIndex = 18;
            this.qtyLbl2.Text = "Quantity 2";
            // 
            // qtyLbl3
            // 
            this.qtyLbl3.AutoSize = true;
            this.qtyLbl3.Location = new System.Drawing.Point(92, 137);
            this.qtyLbl3.Name = "qtyLbl3";
            this.qtyLbl3.Size = new System.Drawing.Size(55, 13);
            this.qtyLbl3.TabIndex = 19;
            this.qtyLbl3.Text = "Quantity 3";
            // 
            // qtyLbl4
            // 
            this.qtyLbl4.AutoSize = true;
            this.qtyLbl4.Location = new System.Drawing.Point(92, 160);
            this.qtyLbl4.Name = "qtyLbl4";
            this.qtyLbl4.Size = new System.Drawing.Size(55, 13);
            this.qtyLbl4.TabIndex = 20;
            this.qtyLbl4.Text = "Quantity 4";
            // 
            // qtyLbl5
            // 
            this.qtyLbl5.AutoSize = true;
            this.qtyLbl5.Location = new System.Drawing.Point(92, 185);
            this.qtyLbl5.Name = "qtyLbl5";
            this.qtyLbl5.Size = new System.Drawing.Size(55, 13);
            this.qtyLbl5.TabIndex = 21;
            this.qtyLbl5.Text = "Quantity 5";
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLbl.Location = new System.Drawing.Point(176, 66);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(39, 13);
            this.valueLbl.TabIndex = 22;
            this.valueLbl.Text = "Value";
            this.valueLbl.Click += new System.EventHandler(this.valueLbl_Click);
            // 
            // valueLbl1
            // 
            this.valueLbl1.AutoSize = true;
            this.valueLbl1.Location = new System.Drawing.Point(176, 88);
            this.valueLbl1.Name = "valueLbl1";
            this.valueLbl1.Size = new System.Drawing.Size(43, 13);
            this.valueLbl1.TabIndex = 23;
            this.valueLbl1.Text = "Value 1";
            // 
            // valueLbl2
            // 
            this.valueLbl2.AutoSize = true;
            this.valueLbl2.Location = new System.Drawing.Point(176, 113);
            this.valueLbl2.Name = "valueLbl2";
            this.valueLbl2.Size = new System.Drawing.Size(43, 13);
            this.valueLbl2.TabIndex = 24;
            this.valueLbl2.Text = "Value 2";
            // 
            // valueLbl3
            // 
            this.valueLbl3.AutoSize = true;
            this.valueLbl3.Location = new System.Drawing.Point(176, 137);
            this.valueLbl3.Name = "valueLbl3";
            this.valueLbl3.Size = new System.Drawing.Size(43, 13);
            this.valueLbl3.TabIndex = 25;
            this.valueLbl3.Text = "Value 3";
            // 
            // valueLbl4
            // 
            this.valueLbl4.AutoSize = true;
            this.valueLbl4.Location = new System.Drawing.Point(176, 160);
            this.valueLbl4.Name = "valueLbl4";
            this.valueLbl4.Size = new System.Drawing.Size(43, 13);
            this.valueLbl4.TabIndex = 26;
            this.valueLbl4.Text = "Value 4";
            // 
            // valueLbl5
            // 
            this.valueLbl5.AutoSize = true;
            this.valueLbl5.Location = new System.Drawing.Point(176, 185);
            this.valueLbl5.Name = "valueLbl5";
            this.valueLbl5.Size = new System.Drawing.Size(43, 13);
            this.valueLbl5.TabIndex = 27;
            this.valueLbl5.Text = "Value 5";
            // 
            // betaLabel
            // 
            this.betaLabel.AutoSize = true;
            this.betaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betaLabel.Location = new System.Drawing.Point(236, 66);
            this.betaLabel.Name = "betaLabel";
            this.betaLabel.Size = new System.Drawing.Size(78, 13);
            this.betaLabel.TabIndex = 28;
            this.betaLabel.Text = "Beta to RTU";
            this.betaLabel.Click += new System.EventHandler(this.betaLabel_Click);
            // 
            // betaLbl1
            // 
            this.betaLbl1.AutoSize = true;
            this.betaLbl1.Location = new System.Drawing.Point(236, 88);
            this.betaLbl1.Name = "betaLbl1";
            this.betaLbl1.Size = new System.Drawing.Size(38, 13);
            this.betaLbl1.TabIndex = 29;
            this.betaLbl1.Text = "Beta 1";
            // 
            // betaLbl2
            // 
            this.betaLbl2.AutoSize = true;
            this.betaLbl2.Location = new System.Drawing.Point(233, 113);
            this.betaLbl2.Name = "betaLbl2";
            this.betaLbl2.Size = new System.Drawing.Size(38, 13);
            this.betaLbl2.TabIndex = 30;
            this.betaLbl2.Text = "Beta 2";
            // 
            // betaLbl3
            // 
            this.betaLbl3.AutoSize = true;
            this.betaLbl3.Location = new System.Drawing.Point(233, 137);
            this.betaLbl3.Name = "betaLbl3";
            this.betaLbl3.Size = new System.Drawing.Size(38, 13);
            this.betaLbl3.TabIndex = 31;
            this.betaLbl3.Text = "Beta 3";
            // 
            // betaLbl4
            // 
            this.betaLbl4.AutoSize = true;
            this.betaLbl4.Location = new System.Drawing.Point(233, 160);
            this.betaLbl4.Name = "betaLbl4";
            this.betaLbl4.Size = new System.Drawing.Size(38, 13);
            this.betaLbl4.TabIndex = 32;
            this.betaLbl4.Text = "Beta 4";
            // 
            // betaLbl5
            // 
            this.betaLbl5.AutoSize = true;
            this.betaLbl5.Location = new System.Drawing.Point(233, 185);
            this.betaLbl5.Name = "betaLbl5";
            this.betaLbl5.Size = new System.Drawing.Size(38, 13);
            this.betaLbl5.TabIndex = 33;
            this.betaLbl5.Text = "Beta 5";
            // 
            // correlationLabel
            // 
            this.correlationLabel.AutoSize = true;
            this.correlationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correlationLabel.Location = new System.Drawing.Point(330, 66);
            this.correlationLabel.Name = "correlationLabel";
            this.correlationLabel.Size = new System.Drawing.Size(68, 13);
            this.correlationLabel.TabIndex = 34;
            this.correlationLabel.Text = "Correlation";
            this.correlationLabel.Click += new System.EventHandler(this.correlationLabel_Click);
            // 
            // predictedMoveLbl
            // 
            this.predictedMoveLbl.AutoSize = true;
            this.predictedMoveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictedMoveLbl.Location = new System.Drawing.Point(417, 66);
            this.predictedMoveLbl.Name = "predictedMoveLbl";
            this.predictedMoveLbl.Size = new System.Drawing.Size(96, 13);
            this.predictedMoveLbl.TabIndex = 35;
            this.predictedMoveLbl.Text = "Predicted Move";
            this.predictedMoveLbl.Click += new System.EventHandler(this.predictedMoveLbl_Click);
            // 
            // PnLLabel
            // 
            this.PnLLabel.AutoSize = true;
            this.PnLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnLLabel.Location = new System.Drawing.Point(535, 66);
            this.PnLLabel.Name = "PnLLabel";
            this.PnLLabel.Size = new System.Drawing.Size(29, 13);
            this.PnLLabel.TabIndex = 36;
            this.PnLLabel.Text = "PnL";
            this.PnLLabel.Click += new System.EventHandler(this.PnLLabel_Click);
            // 
            // corrLbl1
            // 
            this.corrLbl1.AutoSize = true;
            this.corrLbl1.Location = new System.Drawing.Point(330, 88);
            this.corrLbl1.Name = "corrLbl1";
            this.corrLbl1.Size = new System.Drawing.Size(66, 13);
            this.corrLbl1.TabIndex = 37;
            this.corrLbl1.Text = "Correlation 1";
            // 
            // corrLbl2
            // 
            this.corrLbl2.AutoSize = true;
            this.corrLbl2.Location = new System.Drawing.Point(330, 113);
            this.corrLbl2.Name = "corrLbl2";
            this.corrLbl2.Size = new System.Drawing.Size(66, 13);
            this.corrLbl2.TabIndex = 38;
            this.corrLbl2.Text = "Correlation 2";
            // 
            // corrLbl3
            // 
            this.corrLbl3.AutoSize = true;
            this.corrLbl3.Location = new System.Drawing.Point(330, 137);
            this.corrLbl3.Name = "corrLbl3";
            this.corrLbl3.Size = new System.Drawing.Size(66, 13);
            this.corrLbl3.TabIndex = 39;
            this.corrLbl3.Text = "Correlation 3";
            // 
            // corrLbl4
            // 
            this.corrLbl4.AutoSize = true;
            this.corrLbl4.Location = new System.Drawing.Point(330, 160);
            this.corrLbl4.Name = "corrLbl4";
            this.corrLbl4.Size = new System.Drawing.Size(66, 13);
            this.corrLbl4.TabIndex = 40;
            this.corrLbl4.Text = "Correlation 4";
            // 
            // corrLbl5
            // 
            this.corrLbl5.AutoSize = true;
            this.corrLbl5.Location = new System.Drawing.Point(330, 185);
            this.corrLbl5.Name = "corrLbl5";
            this.corrLbl5.Size = new System.Drawing.Size(66, 13);
            this.corrLbl5.TabIndex = 41;
            this.corrLbl5.Text = "Correlation 5";
            // 
            // predMovLbl1
            // 
            this.predMovLbl1.AutoSize = true;
            this.predMovLbl1.Location = new System.Drawing.Point(417, 88);
            this.predMovLbl1.Name = "predMovLbl1";
            this.predMovLbl1.Size = new System.Drawing.Size(68, 13);
            this.predMovLbl1.TabIndex = 42;
            this.predMovLbl1.Text = "Pred Move 1";
            // 
            // predMoveLbl2
            // 
            this.predMoveLbl2.AutoSize = true;
            this.predMoveLbl2.Location = new System.Drawing.Point(417, 113);
            this.predMoveLbl2.Name = "predMoveLbl2";
            this.predMoveLbl2.Size = new System.Drawing.Size(68, 13);
            this.predMoveLbl2.TabIndex = 43;
            this.predMoveLbl2.Text = "Pred Move 2";
            // 
            // predMoveLbl3
            // 
            this.predMoveLbl3.AutoSize = true;
            this.predMoveLbl3.Location = new System.Drawing.Point(417, 137);
            this.predMoveLbl3.Name = "predMoveLbl3";
            this.predMoveLbl3.Size = new System.Drawing.Size(68, 13);
            this.predMoveLbl3.TabIndex = 44;
            this.predMoveLbl3.Text = "Pred Move 3";
            // 
            // predMoveLbl4
            // 
            this.predMoveLbl4.AutoSize = true;
            this.predMoveLbl4.Location = new System.Drawing.Point(417, 160);
            this.predMoveLbl4.Name = "predMoveLbl4";
            this.predMoveLbl4.Size = new System.Drawing.Size(68, 13);
            this.predMoveLbl4.TabIndex = 45;
            this.predMoveLbl4.Text = "Pred Move 4";
            // 
            // predMoveLbl5
            // 
            this.predMoveLbl5.AutoSize = true;
            this.predMoveLbl5.Location = new System.Drawing.Point(417, 185);
            this.predMoveLbl5.Name = "predMoveLbl5";
            this.predMoveLbl5.Size = new System.Drawing.Size(68, 13);
            this.predMoveLbl5.TabIndex = 46;
            this.predMoveLbl5.Text = "Pred Move 5";
            // 
            // pnl1
            // 
            this.pnl1.AutoSize = true;
            this.pnl1.Location = new System.Drawing.Point(535, 88);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(35, 13);
            this.pnl1.TabIndex = 47;
            this.pnl1.Text = "PnL 1";
            // 
            // pnl2
            // 
            this.pnl2.AutoSize = true;
            this.pnl2.Location = new System.Drawing.Point(535, 113);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(35, 13);
            this.pnl2.TabIndex = 48;
            this.pnl2.Text = "PnL 2";
            // 
            // pnl3
            // 
            this.pnl3.AutoSize = true;
            this.pnl3.Location = new System.Drawing.Point(535, 137);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(35, 13);
            this.pnl3.TabIndex = 49;
            this.pnl3.Text = "PnL 3";
            // 
            // pnl4
            // 
            this.pnl4.AutoSize = true;
            this.pnl4.Location = new System.Drawing.Point(535, 160);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(32, 13);
            this.pnl4.TabIndex = 50;
            this.pnl4.Text = "PnL4";
            // 
            // pnl5
            // 
            this.pnl5.AutoSize = true;
            this.pnl5.Location = new System.Drawing.Point(535, 185);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(35, 13);
            this.pnl5.TabIndex = 51;
            this.pnl5.Text = "PnL 5";
            // 
            // predictedTotalPnL
            // 
            this.predictedTotalPnL.Location = new System.Drawing.Point(466, 25);
            this.predictedTotalPnL.Name = "predictedTotalPnL";
            this.predictedTotalPnL.Size = new System.Drawing.Size(100, 20);
            this.predictedTotalPnL.TabIndex = 52;
            this.predictedTotalPnL.TextChanged += new System.EventHandler(this.predictedTotalPnL_TextChanged);
            // 
            // PnLReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 236);
            this.Controls.Add(this.predictedTotalPnL);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.predMoveLbl5);
            this.Controls.Add(this.predMoveLbl4);
            this.Controls.Add(this.predMoveLbl3);
            this.Controls.Add(this.predMoveLbl2);
            this.Controls.Add(this.predMovLbl1);
            this.Controls.Add(this.corrLbl5);
            this.Controls.Add(this.corrLbl4);
            this.Controls.Add(this.corrLbl3);
            this.Controls.Add(this.corrLbl2);
            this.Controls.Add(this.corrLbl1);
            this.Controls.Add(this.PnLLabel);
            this.Controls.Add(this.predictedMoveLbl);
            this.Controls.Add(this.correlationLabel);
            this.Controls.Add(this.betaLbl5);
            this.Controls.Add(this.betaLbl4);
            this.Controls.Add(this.betaLbl3);
            this.Controls.Add(this.betaLbl2);
            this.Controls.Add(this.betaLbl1);
            this.Controls.Add(this.betaLabel);
            this.Controls.Add(this.valueLbl5);
            this.Controls.Add(this.valueLbl4);
            this.Controls.Add(this.valueLbl3);
            this.Controls.Add(this.valueLbl2);
            this.Controls.Add(this.valueLbl1);
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.qtyLbl5);
            this.Controls.Add(this.qtyLbl4);
            this.Controls.Add(this.qtyLbl3);
            this.Controls.Add(this.qtyLbl2);
            this.Controls.Add(this.qtyLbl1);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tickerLbl1);
            this.Controls.Add(this.tickersLbl);
            this.Controls.Add(this.predictedPnLLbl);
            this.Controls.Add(this.rtuMoveTxtBox);
            this.Controls.Add(this.rtuMoveLbl);
            this.Controls.Add(this.portfolioValueTxtBox);
            this.Controls.Add(this.portfolioValueLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateLabel);
            this.Name = "PnLReport";
            this.Text = "PnLReport";
            this.Load += new System.EventHandler(this.PnLReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label portfolioValueLbl;
        private System.Windows.Forms.TextBox portfolioValueTxtBox;
        private System.Windows.Forms.Label rtuMoveLbl;
        private System.Windows.Forms.TextBox rtuMoveTxtBox;
        private System.Windows.Forms.Label predictedPnLLbl;
        private System.Windows.Forms.Label tickersLbl;
        private System.Windows.Forms.Label tickerLbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label qtyLbl1;
        private System.Windows.Forms.Label qtyLbl2;
        private System.Windows.Forms.Label qtyLbl3;
        private System.Windows.Forms.Label qtyLbl4;
        private System.Windows.Forms.Label qtyLbl5;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.Label valueLbl1;
        private System.Windows.Forms.Label valueLbl2;
        private System.Windows.Forms.Label valueLbl3;
        private System.Windows.Forms.Label valueLbl4;
        private System.Windows.Forms.Label valueLbl5;
        private System.Windows.Forms.Label betaLabel;
        private System.Windows.Forms.Label betaLbl1;
        private System.Windows.Forms.Label betaLbl2;
        private System.Windows.Forms.Label betaLbl3;
        private System.Windows.Forms.Label betaLbl4;
        private System.Windows.Forms.Label betaLbl5;
        private System.Windows.Forms.Label correlationLabel;
        private System.Windows.Forms.Label predictedMoveLbl;
        private System.Windows.Forms.Label PnLLabel;
        private System.Windows.Forms.Label corrLbl1;
        private System.Windows.Forms.Label corrLbl2;
        private System.Windows.Forms.Label corrLbl3;
        private System.Windows.Forms.Label corrLbl4;
        private System.Windows.Forms.Label corrLbl5;
        private System.Windows.Forms.Label predMovLbl1;
        private System.Windows.Forms.Label predMoveLbl2;
        private System.Windows.Forms.Label predMoveLbl3;
        private System.Windows.Forms.Label predMoveLbl4;
        private System.Windows.Forms.Label predMoveLbl5;
        private System.Windows.Forms.Label pnl1;
        private System.Windows.Forms.Label pnl2;
        private System.Windows.Forms.Label pnl3;
        private System.Windows.Forms.Label pnl4;
        private System.Windows.Forms.Label pnl5;
        private System.Windows.Forms.TextBox predictedTotalPnL;
    }
}