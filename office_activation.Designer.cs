﻿
namespace Silicon_Hertz_Tool
{
    partial class office_activation
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
            this.office_act_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // office_act_btn
            // 
            this.office_act_btn.BackColor = System.Drawing.Color.Indigo;
            this.office_act_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.office_act_btn.FlatAppearance.BorderSize = 0;
            this.office_act_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.office_act_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.office_act_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.office_act_btn.Location = new System.Drawing.Point(247, 293);
            this.office_act_btn.Name = "office_act_btn";
            this.office_act_btn.Size = new System.Drawing.Size(89, 35);
            this.office_act_btn.TabIndex = 0;
            this.office_act_btn.Text = "Activate";
            this.office_act_btn.UseVisualStyleBackColor = false;
            this.office_act_btn.Click += new System.EventHandler(this.office_act_btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(57, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(471, 204);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Welcome to the Silicon Hertz Tool for Activaton of the Office 2019 . Press the Ac" +
    "tivate Button ...\n";
            // 
            // office_activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(587, 366);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.office_act_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "office_activation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Office 2019 Activator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button office_act_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}