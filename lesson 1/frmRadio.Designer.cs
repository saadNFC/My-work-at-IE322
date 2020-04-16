namespace lesson_1
{
    partial class frmRadio
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioRed2 = new System.Windows.Forms.RadioButton();
            this.RadioGreen2 = new System.Windows.Forms.RadioButton();
            this.RadioBlue2 = new System.Windows.Forms.RadioButton();
            this.RadioYellow2 = new System.Windows.Forms.RadioButton();
            this.BtnBack = new System.Windows.Forms.Button();
            this.RadioRed1 = new System.Windows.Forms.RadioButton();
            this.RadioYellow1 = new System.Windows.Forms.RadioButton();
            this.RadioBlue1 = new System.Windows.Forms.RadioButton();
            this.RadioGreen1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(171, 113);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 0;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioRed2);
            this.groupBox1.Controls.Add(this.RadioGreen2);
            this.groupBox1.Controls.Add(this.RadioBlue2);
            this.groupBox1.Controls.Add(this.RadioYellow2);
            this.groupBox1.Location = new System.Drawing.Point(254, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radio Buttons";
            // 
            // RadioRed2
            // 
            this.RadioRed2.AutoSize = true;
            this.RadioRed2.Location = new System.Drawing.Point(6, 23);
            this.RadioRed2.Name = "RadioRed2";
            this.RadioRed2.Size = new System.Drawing.Size(44, 17);
            this.RadioRed2.TabIndex = 7;
            this.RadioRed2.TabStop = true;
            this.RadioRed2.Text = "Red";
            this.RadioRed2.UseVisualStyleBackColor = true;
            this.RadioRed2.CheckedChanged += new System.EventHandler(this.RadioRed2_CheckedChanged);
            // 
            // RadioGreen2
            // 
            this.RadioGreen2.AutoSize = true;
            this.RadioGreen2.Location = new System.Drawing.Point(6, 46);
            this.RadioGreen2.Name = "RadioGreen2";
            this.RadioGreen2.Size = new System.Drawing.Size(54, 17);
            this.RadioGreen2.TabIndex = 6;
            this.RadioGreen2.TabStop = true;
            this.RadioGreen2.Text = "Green";
            this.RadioGreen2.UseVisualStyleBackColor = true;
            this.RadioGreen2.CheckedChanged += new System.EventHandler(this.RadioGreen2_CheckedChanged);
            // 
            // RadioBlue2
            // 
            this.RadioBlue2.AutoSize = true;
            this.RadioBlue2.Location = new System.Drawing.Point(6, 69);
            this.RadioBlue2.Name = "RadioBlue2";
            this.RadioBlue2.Size = new System.Drawing.Size(45, 17);
            this.RadioBlue2.TabIndex = 5;
            this.RadioBlue2.TabStop = true;
            this.RadioBlue2.Text = "Blue";
            this.RadioBlue2.UseVisualStyleBackColor = true;
            this.RadioBlue2.CheckedChanged += new System.EventHandler(this.RadioBlue2_CheckedChanged);
            // 
            // RadioYellow2
            // 
            this.RadioYellow2.AutoSize = true;
            this.RadioYellow2.Location = new System.Drawing.Point(6, 92);
            this.RadioYellow2.Name = "RadioYellow2";
            this.RadioYellow2.Size = new System.Drawing.Size(55, 17);
            this.RadioYellow2.TabIndex = 4;
            this.RadioYellow2.TabStop = true;
            this.RadioYellow2.Text = "Yellow";
            this.RadioYellow2.UseVisualStyleBackColor = true;
            this.RadioYellow2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(171, 234);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // RadioRed1
            // 
            this.RadioRed1.AutoSize = true;
            this.RadioRed1.Location = new System.Drawing.Point(171, 142);
            this.RadioRed1.Name = "RadioRed1";
            this.RadioRed1.Size = new System.Drawing.Size(44, 17);
            this.RadioRed1.TabIndex = 3;
            this.RadioRed1.TabStop = true;
            this.RadioRed1.Text = "Red";
            this.RadioRed1.UseVisualStyleBackColor = true;
            this.RadioRed1.CheckedChanged += new System.EventHandler(this.RadioRed1_CheckedChanged);
            // 
            // RadioYellow1
            // 
            this.RadioYellow1.AutoSize = true;
            this.RadioYellow1.Location = new System.Drawing.Point(171, 211);
            this.RadioYellow1.Name = "RadioYellow1";
            this.RadioYellow1.Size = new System.Drawing.Size(55, 17);
            this.RadioYellow1.TabIndex = 8;
            this.RadioYellow1.TabStop = true;
            this.RadioYellow1.Text = "Yellow";
            this.RadioYellow1.UseVisualStyleBackColor = true;
            this.RadioYellow1.CheckedChanged += new System.EventHandler(this.RadioYellow1_CheckedChanged);
            // 
            // RadioBlue1
            // 
            this.RadioBlue1.AutoSize = true;
            this.RadioBlue1.Location = new System.Drawing.Point(172, 188);
            this.RadioBlue1.Name = "RadioBlue1";
            this.RadioBlue1.Size = new System.Drawing.Size(45, 17);
            this.RadioBlue1.TabIndex = 9;
            this.RadioBlue1.TabStop = true;
            this.RadioBlue1.Text = "Blue";
            this.RadioBlue1.UseVisualStyleBackColor = true;
            this.RadioBlue1.CheckedChanged += new System.EventHandler(this.RadioBlue1_CheckedChanged);
            // 
            // RadioGreen1
            // 
            this.RadioGreen1.AutoSize = true;
            this.RadioGreen1.Location = new System.Drawing.Point(171, 165);
            this.RadioGreen1.Name = "RadioGreen1";
            this.RadioGreen1.Size = new System.Drawing.Size(54, 17);
            this.RadioGreen1.TabIndex = 10;
            this.RadioGreen1.TabStop = true;
            this.RadioGreen1.Text = "Green";
            this.RadioGreen1.UseVisualStyleBackColor = true;
            this.RadioGreen1.CheckedChanged += new System.EventHandler(this.RadioGreen1_CheckedChanged);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 294);
            this.Controls.Add(this.RadioGreen1);
            this.Controls.Add(this.RadioBlue1);
            this.Controls.Add(this.RadioYellow1);
            this.Controls.Add(this.RadioRed1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnReset);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioRed2;
        private System.Windows.Forms.RadioButton RadioGreen2;
        private System.Windows.Forms.RadioButton RadioBlue2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.RadioButton RadioRed1;
        private System.Windows.Forms.RadioButton RadioYellow2;
        private System.Windows.Forms.RadioButton RadioYellow1;
        private System.Windows.Forms.RadioButton RadioBlue1;
        private System.Windows.Forms.RadioButton RadioGreen1;
    }
}