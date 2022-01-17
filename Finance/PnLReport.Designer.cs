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
            this.displayDate = new System.Windows.Forms.DateTimePicker();
            this.portfolioValLbl = new System.Windows.Forms.Label();
            this.totalPortfolioValue = new System.Windows.Forms.TextBox();
            this.recalculateButton = new System.Windows.Forms.Button();
            this.labelRTU = new System.Windows.Forms.Label();
            this.textBoxRTU = new System.Windows.Forms.TextBox();
            this.textBoxPredictedPnL = new System.Windows.Forms.TextBox();
            this.labelPredictedPnL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // displayDate
            // 
            this.displayDate.Location = new System.Drawing.Point(15, 25);
            this.displayDate.Name = "displayDate";
            this.displayDate.Size = new System.Drawing.Size(184, 20);
            this.displayDate.TabIndex = 1;
            this.displayDate.ValueChanged += new System.EventHandler(this.displayDate_ValueChanged);
            // 
            // portfolioValLbl
            // 
            this.portfolioValLbl.AutoSize = true;
            this.portfolioValLbl.Location = new System.Drawing.Point(222, 9);
            this.portfolioValLbl.Name = "portfolioValLbl";
            this.portfolioValLbl.Size = new System.Drawing.Size(78, 13);
            this.portfolioValLbl.TabIndex = 2;
            this.portfolioValLbl.Text = "Portfolio Value:";
            // 
            // totalPortfolioValue
            // 
            this.totalPortfolioValue.Location = new System.Drawing.Point(225, 25);
            this.totalPortfolioValue.Name = "totalPortfolioValue";
            this.totalPortfolioValue.Size = new System.Drawing.Size(130, 20);
            this.totalPortfolioValue.TabIndex = 3;
            this.totalPortfolioValue.TextChanged += new System.EventHandler(this.totalPortfolioValue_TextChanged);
            // 
            // recalculateButton
            // 
            this.recalculateButton.Location = new System.Drawing.Point(681, 163);
            this.recalculateButton.Name = "recalculateButton";
            this.recalculateButton.Size = new System.Drawing.Size(87, 25);
            this.recalculateButton.TabIndex = 4;
            this.recalculateButton.Text = "Recalculate";
            this.recalculateButton.UseVisualStyleBackColor = true;
            this.recalculateButton.Click += new System.EventHandler(this.recalculateButton_Click);
            // 
            // labelRTU
            // 
            this.labelRTU.AutoSize = true;
            this.labelRTU.Location = new System.Drawing.Point(401, 9);
            this.labelRTU.Name = "labelRTU";
            this.labelRTU.Size = new System.Drawing.Size(62, 13);
            this.labelRTU.TabIndex = 5;
            this.labelRTU.Text = "RTU move:";
            // 
            // textBoxRTU
            // 
            this.textBoxRTU.Location = new System.Drawing.Point(404, 25);
            this.textBoxRTU.Name = "textBoxRTU";
            this.textBoxRTU.Size = new System.Drawing.Size(121, 20);
            this.textBoxRTU.TabIndex = 6;
            this.textBoxRTU.TextChanged += new System.EventHandler(this.textBoxRTU_TextChanged);
            // 
            // textBoxPredictedPnL
            // 
            this.textBoxPredictedPnL.Location = new System.Drawing.Point(572, 25);
            this.textBoxPredictedPnL.Name = "textBoxPredictedPnL";
            this.textBoxPredictedPnL.Size = new System.Drawing.Size(134, 20);
            this.textBoxPredictedPnL.TabIndex = 7;
            // 
            // labelPredictedPnL
            // 
            this.labelPredictedPnL.AutoSize = true;
            this.labelPredictedPnL.Location = new System.Drawing.Point(569, 9);
            this.labelPredictedPnL.Name = "labelPredictedPnL";
            this.labelPredictedPnL.Size = new System.Drawing.Size(74, 13);
            this.labelPredictedPnL.TabIndex = 8;
            this.labelPredictedPnL.Text = "Prediced PnL:";
            // 
            // PnLReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 191);
            this.Controls.Add(this.labelPredictedPnL);
            this.Controls.Add(this.textBoxPredictedPnL);
            this.Controls.Add(this.textBoxRTU);
            this.Controls.Add(this.labelRTU);
            this.Controls.Add(this.recalculateButton);
            this.Controls.Add(this.totalPortfolioValue);
            this.Controls.Add(this.portfolioValLbl);
            this.Controls.Add(this.displayDate);
            this.Controls.Add(this.dateLabel);
            this.Name = "PnLReport";
            this.Text = "PnLReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker displayDate;
        private System.Windows.Forms.Label portfolioValLbl;
        private System.Windows.Forms.TextBox totalPortfolioValue;
        private System.Windows.Forms.Button recalculateButton;
        private System.Windows.Forms.Label labelRTU;
        private System.Windows.Forms.TextBox textBoxRTU;
        private System.Windows.Forms.TextBox textBoxPredictedPnL;
        private System.Windows.Forms.Label labelPredictedPnL;
    }
}