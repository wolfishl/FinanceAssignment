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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recalculateButton = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(466, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // recalculateButton
            // 
            this.recalculateButton.Location = new System.Drawing.Point(523, 201);
            this.recalculateButton.Name = "recalculateButton";
            this.recalculateButton.Size = new System.Drawing.Size(99, 23);
            this.recalculateButton.TabIndex = 8;
            this.recalculateButton.Text = "Recalculate";
            this.recalculateButton.UseVisualStyleBackColor = true;
            this.recalculateButton.Click += new System.EventHandler(this.recalculateButton_Click);
            // 
            // PnLReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 236);
            this.Controls.Add(this.recalculateButton);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button recalculateButton;
    }
}