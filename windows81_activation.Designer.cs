
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Professional
            // 
            this.Professional.AutoSize = true;
            this.Professional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Professional.Location = new System.Drawing.Point(13, 40);
            this.Professional.Name = "Professional";
            this.Professional.Size = new System.Drawing.Size(188, 21);
            this.Professional.TabIndex = 1;
            this.Professional.TabStop = true;
            this.Professional.Text = "Windows 8.1 Professional";
            this.Professional.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(13, 86);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(147, 21);
            this.Home.TabIndex = 2;
            this.Home.TabStop = true;
            this.Home.Text = "Windows 8.1 Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Enterprise
            // 
            this.Enterprise.AutoSize = true;
            this.Enterprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterprise.Location = new System.Drawing.Point(13, 132);
            this.Enterprise.Name = "Enterprise";
            this.Enterprise.Size = new System.Drawing.Size(175, 21);
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
            this.button1.Location = new System.Drawing.Point(166, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // windows81_activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enterprise);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Professional);
            this.Controls.Add(this.pictureBox1);
            this.Name = "windows81_activation";
            this.Text = "windows81_activation";
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
    }
}