namespace lesson_1
{
    partial class frmcombo
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
            this.BtnM1 = new System.Windows.Forms.Button();
            this.BtnRmv2Last = new System.Windows.Forms.Button();
            this.BtnRmvName = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRmvIndex = new System.Windows.Forms.Button();
            this.BtnRmvLast = new System.Windows.Forms.Button();
            this.BtnM2 = new System.Windows.Forms.Button();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.BtnM3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnM1
            // 
            this.BtnM1.Location = new System.Drawing.Point(57, 32);
            this.BtnM1.Name = "BtnM1";
            this.BtnM1.Size = new System.Drawing.Size(115, 43);
            this.BtnM1.TabIndex = 0;
            this.BtnM1.Text = "Show Selected Method 1";
            this.BtnM1.UseVisualStyleBackColor = true;
            this.BtnM1.Click += new System.EventHandler(this.BtnM1_Click);
            // 
            // BtnRmv2Last
            // 
            this.BtnRmv2Last.Location = new System.Drawing.Point(424, 149);
            this.BtnRmv2Last.Name = "BtnRmv2Last";
            this.BtnRmv2Last.Size = new System.Drawing.Size(124, 58);
            this.BtnRmv2Last.TabIndex = 1;
            this.BtnRmv2Last.Text = "Remove 2nd last item";
            this.BtnRmv2Last.UseVisualStyleBackColor = true;
            this.BtnRmv2Last.Click += new System.EventHandler(this.BtnRmv2Last_Click);
            // 
            // BtnRmvName
            // 
            this.BtnRmvName.Location = new System.Drawing.Point(178, 218);
            this.BtnRmvName.Name = "BtnRmvName";
            this.BtnRmvName.Size = new System.Drawing.Size(140, 35);
            this.BtnRmvName.TabIndex = 2;
            this.BtnRmvName.Text = "Remove by Name";
            this.BtnRmvName.UseVisualStyleBackColor = true;
            this.BtnRmvName.Click += new System.EventHandler(this.BtnRmvName_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(424, 213);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(106, 45);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRmvIndex
            // 
            this.BtnRmvIndex.Location = new System.Drawing.Point(50, 218);
            this.BtnRmvIndex.Name = "BtnRmvIndex";
            this.BtnRmvIndex.Size = new System.Drawing.Size(122, 35);
            this.BtnRmvIndex.TabIndex = 4;
            this.BtnRmvIndex.Text = "Remove by Index";
            this.BtnRmvIndex.UseVisualStyleBackColor = true;
            this.BtnRmvIndex.Click += new System.EventHandler(this.BtnRmvIndex_Click);
            // 
            // BtnRmvLast
            // 
            this.BtnRmvLast.Location = new System.Drawing.Point(424, 80);
            this.BtnRmvLast.Name = "BtnRmvLast";
            this.BtnRmvLast.Size = new System.Drawing.Size(124, 63);
            this.BtnRmvLast.TabIndex = 5;
            this.BtnRmvLast.Text = "Remove last item";
            this.BtnRmvLast.UseVisualStyleBackColor = true;
            this.BtnRmvLast.Click += new System.EventHandler(this.BtnRmvLast_Click);
            // 
            // BtnM2
            // 
            this.BtnM2.Location = new System.Drawing.Point(178, 32);
            this.BtnM2.Name = "BtnM2";
            this.BtnM2.Size = new System.Drawing.Size(119, 43);
            this.BtnM2.TabIndex = 6;
            this.BtnM2.Text = "Show Selected Method 2";
            this.BtnM2.UseVisualStyleBackColor = true;
            this.BtnM2.Click += new System.EventHandler(this.BtnM2_Click);
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(57, 95);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 21);
            this.cmbDays.TabIndex = 7;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // BtnM3
            // 
            this.BtnM3.Location = new System.Drawing.Point(303, 32);
            this.BtnM3.Name = "BtnM3";
            this.BtnM3.Size = new System.Drawing.Size(119, 43);
            this.BtnM3.TabIndex = 8;
            this.BtnM3.Text = "Show Selected Method 3";
            this.BtnM3.UseVisualStyleBackColor = true;
            this.BtnM3.Click += new System.EventHandler(this.BtnM3_Click);
            // 
            // frmcombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.BtnM3);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.BtnM2);
            this.Controls.Add(this.BtnRmvLast);
            this.Controls.Add(this.BtnRmvIndex);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRmvName);
            this.Controls.Add(this.BtnRmv2Last);
            this.Controls.Add(this.BtnM1);
            this.Name = "frmcombo";
            this.Text = "frmcombo";
            this.Load += new System.EventHandler(this.frmcombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnM1;
        private System.Windows.Forms.Button BtnRmv2Last;
        private System.Windows.Forms.Button BtnRmvName;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRmvIndex;
        private System.Windows.Forms.Button BtnRmvLast;
        private System.Windows.Forms.Button BtnM2;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Button BtnM3;
    }
}