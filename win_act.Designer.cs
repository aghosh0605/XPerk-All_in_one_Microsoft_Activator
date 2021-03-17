
namespace Silicon_Hertz_Tool
{
    partial class win_act
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
            this.button1 = new System.Windows.Forms.Button();
            this.professional = new System.Windows.Forms.RadioButton();
            this.Home = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(111, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // professional
            // 
            this.professional.AutoSize = true;
            this.professional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.professional.Location = new System.Drawing.Point(35, 24);
            this.professional.Name = "professional";
            this.professional.Size = new System.Drawing.Size(82, 17);
            this.professional.TabIndex = 6;
            this.professional.TabStop = true;
            this.professional.Text = "Professional";
            this.professional.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Home.Location = new System.Drawing.Point(223, 24);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(53, 17);
            this.Home.TabIndex = 7;
            this.Home.TabStop = true;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // win_act
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(343, 238);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.professional);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "win_act";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Windows 10 Activation";
            this.Load += new System.EventHandler(this.win_act_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton professional;
        private System.Windows.Forms.RadioButton Home;
    }
}