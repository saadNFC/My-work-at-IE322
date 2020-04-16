namespace lesson_1
{
    partial class frmPicture
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
            this.picleft = new System.Windows.Forms.PictureBox();
            this.picright = new System.Windows.Forms.PictureBox();
            this.BtnImagrFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picright)).BeginInit();
            this.SuspendLayout();
            // 
            // picleft
            // 
            this.picleft.Location = new System.Drawing.Point(236, 12);
            this.picleft.Name = "picleft";
            this.picleft.Size = new System.Drawing.Size(250, 297);
            this.picleft.TabIndex = 0;
            this.picleft.TabStop = false;
            this.picleft.Click += new System.EventHandler(this.picleft_Click);
            // 
            // picright
            // 
            this.picright.Location = new System.Drawing.Point(514, 12);
            this.picright.Name = "picright";
            this.picright.Size = new System.Drawing.Size(274, 297);
            this.picright.TabIndex = 1;
            this.picright.TabStop = false;
            // 
            // BtnImagrFile
            // 
            this.BtnImagrFile.Location = new System.Drawing.Point(22, 26);
            this.BtnImagrFile.Name = "BtnImagrFile";
            this.BtnImagrFile.Size = new System.Drawing.Size(135, 37);
            this.BtnImagrFile.TabIndex = 2;
            this.BtnImagrFile.Text = "Image from file";
            this.BtnImagrFile.UseVisualStyleBackColor = true;
            this.BtnImagrFile.Click += new System.EventHandler(this.BtnImagrFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(697, 327);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnImagrFile);
            this.Controls.Add(this.picright);
            this.Controls.Add(this.picleft);
            this.Name = "frmPicture";
            this.Text = "frmPicture";
            ((System.ComponentModel.ISupportInitialize)(this.picleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picright)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picleft;
        private System.Windows.Forms.PictureBox picright;
        private System.Windows.Forms.Button BtnImagrFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnBack;
    }
}