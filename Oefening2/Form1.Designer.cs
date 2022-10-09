namespace Oefening2
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
            this.btnGeluid = new System.Windows.Forms.Button();
            this.cbKoe = new System.Windows.Forms.CheckBox();
            this.cbVarken = new System.Windows.Forms.CheckBox();
            this.cbSlang = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGeluid
            // 
            this.btnGeluid.Location = new System.Drawing.Point(369, 292);
            this.btnGeluid.Name = "btnGeluid";
            this.btnGeluid.Size = new System.Drawing.Size(75, 23);
            this.btnGeluid.TabIndex = 0;
            this.btnGeluid.Text = "Laat horen";
            this.btnGeluid.UseVisualStyleBackColor = true;
            this.btnGeluid.Click += new System.EventHandler(this.btnGeluid_Click);
            // 
            // cbKoe
            // 
            this.cbKoe.AutoSize = true;
            this.cbKoe.Location = new System.Drawing.Point(190, 135);
            this.cbKoe.Name = "cbKoe";
            this.cbKoe.Size = new System.Drawing.Size(46, 19);
            this.cbKoe.TabIndex = 1;
            this.cbKoe.Text = "Koe";
            this.cbKoe.UseVisualStyleBackColor = true;
            // 
            // cbVarken
            // 
            this.cbVarken.AutoSize = true;
            this.cbVarken.Location = new System.Drawing.Point(369, 135);
            this.cbVarken.Name = "cbVarken";
            this.cbVarken.Size = new System.Drawing.Size(61, 19);
            this.cbVarken.TabIndex = 2;
            this.cbVarken.Text = "Varken";
            this.cbVarken.UseVisualStyleBackColor = true;
            // 
            // cbSlang
            // 
            this.cbSlang.AutoSize = true;
            this.cbSlang.Location = new System.Drawing.Point(530, 135);
            this.cbSlang.Name = "cbSlang";
            this.cbSlang.Size = new System.Drawing.Size(55, 19);
            this.cbSlang.TabIndex = 3;
            this.cbSlang.Text = "Slang";
            this.cbSlang.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSlang);
            this.Controls.Add(this.cbVarken);
            this.Controls.Add(this.cbKoe);
            this.Controls.Add(this.btnGeluid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGeluid;
        private CheckBox cbKoe;
        private CheckBox cbVarken;
        private CheckBox cbSlang;
    }
}