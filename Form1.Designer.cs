
namespace Silicon_Hertz_Tool
{
    partial class Form1
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
            this.win_act = new System.Windows.Forms.Button();
            this.office_act = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // win_act
            // 
            this.win_act.BackColor = System.Drawing.Color.Indigo;
            this.win_act.FlatAppearance.BorderSize = 0;
            this.win_act.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.win_act.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win_act.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.win_act.Location = new System.Drawing.Point(12, 12);
            this.win_act.Name = "win_act";
            this.win_act.Size = new System.Drawing.Size(131, 48);
            this.win_act.TabIndex = 0;
            this.win_act.Text = "Windows 10 Activate";
            this.win_act.UseVisualStyleBackColor = false;
            this.win_act.Click += new System.EventHandler(this.win_act_Click);
            // 
            // office_act
            // 
            this.office_act.BackColor = System.Drawing.Color.Crimson;
            this.office_act.FlatAppearance.BorderSize = 0;
            this.office_act.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.office_act.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.office_act.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.office_act.Location = new System.Drawing.Point(12, 66);
            this.office_act.Name = "office_act";
            this.office_act.Size = new System.Drawing.Size(131, 48);
            this.office_act.TabIndex = 1;
            this.office_act.Text = "Office 2019 Activate";
            this.office_act.UseVisualStyleBackColor = false;
            this.office_act.Click += new System.EventHandler(this.office_act_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Silicon_Hertz_Tool.Properties.Resources.pandasecurity_How_do_hackers_pick_their_targets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(771, 487);
            this.Controls.Add(this.office_act);
            this.Controls.Add(this.win_act);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Silicon Hertz Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button win_act;
        private System.Windows.Forms.Button office_act;
    }
}

