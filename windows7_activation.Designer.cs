
namespace Silicon_Hertz_Tool
{
    partial class windows7_activation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windows7_activation));
            this.Professional = new System.Windows.Forms.RadioButton();
            this.Ultimate = new System.Windows.Forms.RadioButton();
            this.Home = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Professional
            // 
            this.Professional.AutoSize = true;
            this.Professional.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Professional.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Professional.Location = new System.Drawing.Point(12, 400);
            this.Professional.Name = "Professional";
            this.Professional.Size = new System.Drawing.Size(271, 32);
            this.Professional.TabIndex = 0;
            this.Professional.TabStop = true;
            this.Professional.Text = "Widows 7 Professional";
            this.Professional.UseVisualStyleBackColor = true;
            // 
            // Ultimate
            // 
            this.Ultimate.AutoSize = true;
            this.Ultimate.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ultimate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ultimate.Location = new System.Drawing.Point(289, 400);
            this.Ultimate.Name = "Ultimate";
            this.Ultimate.Size = new System.Drawing.Size(249, 32);
            this.Ultimate.TabIndex = 1;
            this.Ultimate.TabStop = true;
            this.Ultimate.Text = "Windows 7 Ultimate";
            this.Ultimate.UseVisualStyleBackColor = true;
            this.Ultimate.CheckedChanged += new System.EventHandler(this.Ultimate_CheckedChanged);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Century", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home.Location = new System.Drawing.Point(556, 400);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(216, 32);
            this.Home.TabIndex = 2;
            this.Home.TabStop = true;
            this.Home.Text = "Windows 7 Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.CheckedChanged += new System.EventHandler(this.Home_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.button1.Font = new System.Drawing.Font("Javanese Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(309, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pictureBox1.Image = global::Silicon_Hertz_Tool.Properties.Resources.windows7;
            this.pictureBox1.Location = new System.Drawing.Point(243, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(303, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 33);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "WINDOWS 7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(264, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Operating System Model";
            // 
            // windows7_activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Ultimate);
            this.Controls.Add(this.Professional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "windows7_activation";
            this.Text = "Windows 7 Activator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Professional;
        private System.Windows.Forms.RadioButton Ultimate;
        private System.Windows.Forms.RadioButton Home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}