
namespace Silicon_Hertz_Tool
{
    partial class win8_acti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win8_acti));
            this.Professional = new System.Windows.Forms.RadioButton();
            this.Home = new System.Windows.Forms.RadioButton();
            this.Enterprise = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Professional
            // 
            this.Professional.AutoSize = true;
            this.Professional.BackColor = System.Drawing.Color.Aqua;
            this.Professional.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Professional.Location = new System.Drawing.Point(12, 66);
            this.Professional.Name = "Professional";
            this.Professional.Size = new System.Drawing.Size(190, 32);
            this.Professional.TabIndex = 0;
            this.Professional.TabStop = true;
            this.Professional.Text = "Windows 8 Pro";
            this.Professional.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.Color.Aqua;
            this.Home.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(556, 66);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(216, 32);
            this.Home.TabIndex = 1;
            this.Home.TabStop = true;
            this.Home.Text = "Windows 8 Home";
            this.Home.UseVisualStyleBackColor = false;
            // 
            // Enterprise
            // 
            this.Enterprise.AutoSize = true;
            this.Enterprise.BackColor = System.Drawing.Color.Aqua;
            this.Enterprise.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterprise.Location = new System.Drawing.Point(244, 66);
            this.Enterprise.Name = "Enterprise";
            this.Enterprise.Size = new System.Drawing.Size(268, 32);
            this.Enterprise.TabIndex = 2;
            this.Enterprise.TabStop = true;
            this.Enterprise.Text = "Windows 8 Enterprise";
            this.Enterprise.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(267, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Operating System Model";
            // 
            // win8_acti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Professional);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Enterprise);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "win8_acti";
            this.Text = "Windows 8 Activator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Professional;
        private System.Windows.Forms.RadioButton Home;
        private System.Windows.Forms.RadioButton Enterprise;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}