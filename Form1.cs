using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silicon_Hertz_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void win_act_Click(object sender, EventArgs e)
        {
            var myForm = new win_act();
            myForm.Show();
        }
        private static void RunThisAsAdmin()
        {
            if (!IsAdministrator())
            {
                var exe = Process.GetCurrentProcess().MainModule.FileName;
                var startInfo = new ProcessStartInfo(exe)
                {
                    UseShellExecute = true,
                    Verb = "runas",
                    WindowStyle = ProcessWindowStyle.Normal,
                    CreateNoWindow = false
                };
                Process.Start(startInfo);
                Process.GetCurrentProcess().Kill();
            }
        }
        private static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RunThisAsAdmin();
        }

        private void office_act_Click(object sender, EventArgs e)
        {
            var myform2 = new office_activation();
            myform2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myform3 = new windows7_activation();
            myform3.Show();
        }
    }
}
