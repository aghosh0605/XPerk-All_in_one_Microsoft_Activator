
namespace Silicon_Hertz_Tool
{
    partial class windows81_activation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windows81_activation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Professional = new System.Windows.Forms.RadioButton();
            this.Home = new System.Windows.Forms.RadioButton();
            this.Enterprise = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Professional
            // 
            this.Professional.AutoSize = true;
            this.Professional.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Professional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.Professional.Location = new System.Drawing.Point(12, 70);
            this.Professional.Name = "Professional";
            this.Professional.Size = new System.Drawing.Size(209, 32);
            this.Professional.TabIndex = 1;
            this.Professional.TabStop = true;
            this.Professional.Text = "Windows 8.1 Pro";
            this.Professional.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.Home.Location = new System.Drawing.Point(542, 70);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(235, 32);
            this.Home.TabIndex = 2;
            this.Home.TabStop = true;
            this.Home.Text = "Windows 8.1 Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Enterprise
            // 
            this.Enterprise.AutoSize = true;
            this.Enterprise.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterprise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.Enterprise.Location = new System.Drawing.Point(238, 70);
            this.Enterprise.Name = "Enterprise";
            this.Enterprise.Size = new System.Drawing.Size(287, 32);
            this.Enterprise.TabIndex = 3;
            this.Enterprise.TabStop = true;
            this.Enterprise.Text = "Windows 8.1 Enterprise";
            this.Enterprise.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(302, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Operating System Model";
            // 
            // windows81_activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enterprise);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Professional);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "windows81_activation";
            this.Text = "Windows 8.1 Activator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Professional;
        private System.Windows.Forms.RadioButton Home;
        private System.Windows.Forms.RadioButton Enterprise;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}