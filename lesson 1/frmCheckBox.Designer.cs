namespace lesson_1
{
    partial class frmCheckBox
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChBrownie = new System.Windows.Forms.CheckBox();
            this.ChDonut = new System.Windows.Forms.CheckBox();
            this.ChCoffee = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(201, 62);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(326, 197);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChBrownie);
            this.groupBox1.Controls.Add(this.ChDonut);
            this.groupBox1.Controls.Add(this.ChCoffee);
            this.groupBox1.Location = new System.Drawing.Point(201, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ChBrownie
            // 
            this.ChBrownie.AutoSize = true;
            this.ChBrownie.Location = new System.Drawing.Point(7, 65);
            this.ChBrownie.Name = "ChBrownie";
            this.ChBrownie.Size = new System.Drawing.Size(64, 17);
            this.ChBrownie.TabIndex = 2;
            this.ChBrownie.Text = "Brownie";
            this.ChBrownie.UseVisualStyleBackColor = true;
            this.ChBrownie.CheckedChanged += new System.EventHandler(this.ChBrownie_CheckedChanged);
            // 
            // ChDonut
            // 
            this.ChDonut.AutoSize = true;
            this.ChDonut.Location = new System.Drawing.Point(6, 43);
            this.ChDonut.Name = "ChDonut";
            this.ChDonut.Size = new System.Drawing.Size(55, 17);
            this.ChDonut.TabIndex = 1;
            this.ChDonut.Text = "Donut";
            this.ChDonut.UseVisualStyleBackColor = true;
            // 
            // ChCoffee
            // 
            this.ChCoffee.AutoSize = true;
            this.ChCoffee.Location = new System.Drawing.Point(7, 20);
            this.ChCoffee.Name = "ChCoffee";
            this.ChCoffee.Size = new System.Drawing.Size(59, 17);
            this.ChCoffee.TabIndex = 0;
            this.ChCoffee.Text = "Coffee";
            this.ChCoffee.UseVisualStyleBackColor = true;
            this.ChCoffee.CheckedChanged += new System.EventHandler(this.ChCoffee_CheckedChanged);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Name = "frmCheckBox";
            this.Text = "frmCheckBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChBrownie;
        private System.Windows.Forms.CheckBox ChDonut;
        private System.Windows.Forms.CheckBox ChCoffee;
    }
}