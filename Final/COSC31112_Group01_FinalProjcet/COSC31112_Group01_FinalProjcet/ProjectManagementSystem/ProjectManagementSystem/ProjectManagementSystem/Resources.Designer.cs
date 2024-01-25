namespace ProjectManagementSystem
{
    partial class Resources
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
            this.total = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.completeProjCount = new System.Windows.Forms.Label();
            this.projCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Maroon;
            this.total.Location = new System.Drawing.Point(870, 468);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 36);
            this.total.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(690, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 41);
            this.button2.TabIndex = 37;
            this.button2.Text = "Resource Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(481, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 41);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add Resources";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(727, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 49);
            this.label3.TabIndex = 34;
            this.label3.Text = "Welcome to Resources";
            // 
            // completeProjCount
            // 
            this.completeProjCount.AutoSize = true;
            this.completeProjCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeProjCount.Location = new System.Drawing.Point(732, 369);
            this.completeProjCount.Name = "completeProjCount";
            this.completeProjCount.Size = new System.Drawing.Size(0, 32);
            this.completeProjCount.TabIndex = 33;
            // 
            // projCount
            // 
            this.projCount.AutoSize = true;
            this.projCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projCount.Location = new System.Drawing.Point(666, 260);
            this.projCount.Name = "projCount";
            this.projCount.Size = new System.Drawing.Size(0, 32);
            this.projCount.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(786, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 31;
            this.label1.Text = "Total Resources ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectManagementSystem.Properties.Resources.steptodown_com198352;
            this.pictureBox1.Location = new System.Drawing.Point(224, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 691);
            this.Controls.Add(this.total);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.completeProjCount);
            this.Controls.Add(this.projCount);
            this.Controls.Add(this.label1);
            this.Name = "Resources";
            this.Text = "Resources";
            this.Load += new System.EventHandler(this.Resources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label total;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label completeProjCount;
        public System.Windows.Forms.Label projCount;
        public System.Windows.Forms.Label label1;
    }
}