using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silicon_Hertz_Tool
{
    public partial class win_act : Form
    {
        public win_act()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            if (professional.Checked == true)
            {
                startInfo.Arguments = "/C slmgr /skms kms8.msguides.com && slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX && slmgr /ato";
            }
            else if (Home.Checked == true)
            {

            startInfo.Arguments = "/C slmgr /skms kms8.msguides.com && slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 && slmgr /ato";
            }

            process.StartInfo = startInfo;
            process.Start();
        }

        private void win_act_Load(object sender, EventArgs e)
        {

        }
    }
}
