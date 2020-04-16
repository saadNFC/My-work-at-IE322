namespace lesson_1
{
    partial class frmRandom
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
            this.BtnRC = new System.Windows.Forms.Button();
            this.BtnRN = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TextRGB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRC
            // 
            this.BtnRC.Location = new System.Drawing.Point(52, 29);
            this.BtnRC.Name = "BtnRC";
            this.BtnRC.Size = new System.Drawing.Size(244, 51);
            this.BtnRC.TabIndex = 0;
            this.BtnRC.Text = "Generate Random Color";
            this.BtnRC.UseVisualStyleBackColor = true;
            this.BtnRC.Click += new System.EventHandler(this.BtnRC_Click);
            // 
            // BtnRN
            // 
            this.BtnRN.Location = new System.Drawing.Point(49, 142);
            this.BtnRN.Name = "BtnRN";
            this.BtnRN.Size = new System.Drawing.Size(148, 51);
            this.BtnRN.TabIndex = 1;
            this.BtnRN.Text = "Random Number";
            this.BtnRN.UseVisualStyleBackColor = true;
            this.BtnRN.Click += new System.EventHandler(this.BtnRN_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(186, 306);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(110, 41);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TextRGB
            // 
            this.TextRGB.AutoSize = true;
            this.TextRGB.Location = new System.Drawing.Point(166, 98);
            this.TextRGB.Name = "TextRGB";
            this.TextRGB.Size = new System.Drawing.Size(31, 13);
            this.TextRGB.TabIndex = 3;
            this.TextRGB.Text = "r-g-b";
            this.TextRGB.Click += new System.EventHandler(this.TextRGB_Click);
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextRGB);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRN);
            this.Controls.Add(this.BtnRC);
            this.Name = "frmRandom";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.Random_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRC;
        private System.Windows.Forms.Button BtnRN;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label TextRGB;
    }
}