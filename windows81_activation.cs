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
    public partial class windows81_activation : Form
    {
        public windows81_activation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            if (Professional.Checked == true)
            {
                startInfo.Arguments = "/C slmgr /skms kms.cangshui.net && slmgr /ipk FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4 && slmgr /ato";
            }
            else if (Home.Checked == true)
            {

                startInfo.Arguments = "/C slmgr /skms kms.cangshui.net && slmgr /ipk 6V3G-9DB2T-BD4VC-44JVQ-6BVR2 && slmgr /ato";
            }
            else if (Enterprise.Checked == true)
            {
                startInfo.Arguments = "/C slmgr /skms kms.cangshui.net && slmgr /ipk MM7DF-G8XWM-J2VRG-4M3C4-GR27X && slmgr /ato";
            }

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
