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
            this.tickerLbl1.Size = new System.Drawing.Size(0, 13);
            this.tickerLbl1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // PnLReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 236);
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
    }
}