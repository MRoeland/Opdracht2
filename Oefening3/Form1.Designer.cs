namespace Oefening3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUSD = new System.Windows.Forms.TextBox();
            this.lblUsd = new System.Windows.Forms.Label();
            this.lblBP = new System.Windows.Forms.Label();
            this.tbBP = new System.Windows.Forms.TextBox();
            this.lblEu = new System.Windows.Forms.Label();
            this.tbEu = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lblRu = new System.Windows.Forms.Label();
            this.tbRu = new System.Windows.Forms.TextBox();
            this.lblFr = new System.Windows.Forms.Label();
            this.tbFr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUSD
            // 
            this.tbUSD.Location = new System.Drawing.Point(152, 57);
            this.tbUSD.Name = "tbUSD";
            this.tbUSD.Size = new System.Drawing.Size(100, 23);
            this.tbUSD.TabIndex = 0;
            this.tbUSD.TextChanged += new System.EventHandler(this.tbUSD_TextChanged);
            // 
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.Location = new System.Drawing.Point(51, 57);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(68, 15);
            this.lblUsd.TabIndex = 1;
            this.lblUsd.Text = "USD Dollars";
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Location = new System.Drawing.Point(51, 108);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(83, 15);
            this.lblBP.TabIndex = 3;
            this.lblBP.Text = "British Pounds";
            // 
            // tbBP
            // 
            this.tbBP.Location = new System.Drawing.Point(152, 105);
            this.tbBP.Name = "tbBP";
            this.tbBP.Size = new System.Drawing.Size(100, 23);
            this.tbBP.TabIndex = 2;
            this.tbBP.TextChanged += new System.EventHandler(this.tbBP_TextChanged);
            // 
            // lblEu
            // 
            this.lblEu.AutoSize = true;
            this.lblEu.Location = new System.Drawing.Point(51, 161);
            this.lblEu.Name = "lblEu";
            this.lblEu.Size = new System.Drawing.Size(31, 15);
            this.lblEu.TabIndex = 5;
            this.lblEu.Text = "Euro";
            // 
            // tbEu
            // 
            this.tbEu.Location = new System.Drawing.Point(152, 158);
            this.tbEu.Name = "tbEu";
            this.tbEu.Size = new System.Drawing.Size(100, 23);
            this.tbEu.TabIndex = 4;
            this.tbEu.TextChanged += new System.EventHandler(this.tbEu_TextChanged);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(51, 219);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(26, 15);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Yen";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(152, 216);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 23);
            this.tbY.TabIndex = 6;
            this.tbY.TextChanged += new System.EventHandler(this.tbY_TextChanged);
            // 
            // lblRu
            // 
            this.lblRu.AutoSize = true;
            this.lblRu.Location = new System.Drawing.Point(51, 275);
            this.lblRu.Name = "lblRu";
            this.lblRu.Size = new System.Drawing.Size(45, 15);
            this.lblRu.TabIndex = 9;
            this.lblRu.Text = "Rupees";
            // 
            // tbRu
            // 
            this.tbRu.Location = new System.Drawing.Point(152, 272);
            this.tbRu.Name = "tbRu";
            this.tbRu.Size = new System.Drawing.Size(100, 23);
            this.tbRu.TabIndex = 8;
            this.tbRu.TextChanged += new System.EventHandler(this.tbRu_TextChanged);
            // 
            // lblFr
            // 
            this.lblFr.AutoSize = true;
            this.lblFr.Location = new System.Drawing.Point(51, 328);
            this.lblFr.Name = "lblFr";
            this.lblFr.Size = new System.Drawing.Size(49, 15);
            this.lblFr.TabIndex = 11;
            this.lblFr.Text = "Franken";
            // 
            // tbFr
            // 
            this.tbFr.Location = new System.Drawing.Point(152, 325);
            this.tbFr.Name = "tbFr";
            this.tbFr.Size = new System.Drawing.Size(100, 23);
            this.tbFr.TabIndex = 10;
            this.tbFr.TextChanged += new System.EventHandler(this.tbFr_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 399);
            this.Controls.Add(this.lblFr);
            this.Controls.Add(this.tbFr);
            this.Controls.Add(this.lblRu);
            this.Controls.Add(this.tbRu);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.lblEu);
            this.Controls.Add(this.tbEu);
            this.Controls.Add(this.lblBP);
            this.Controls.Add(this.tbBP);
            this.Controls.Add(this.lblUsd);
            this.Controls.Add(this.tbUSD);
            this.Name = "Form1";
            this.Text = "CurrencyConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbUSD;
        private Label lblUsd;
        private Label lblBP;
        private TextBox tbBP;
        private Label lblEu;
        private TextBox tbEu;
        private Label lblY;
        private TextBox tbY;
        private Label lblRu;
        private TextBox tbRu;
        private Label lblFr;
        private TextBox tbFr;
    }
}