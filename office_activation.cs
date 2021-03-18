using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Silicon_Hertz_Tool
{
    public partial class office_activation : Form
    {
        public office_activation()
        {
            InitializeComponent();
        }

        private void office_act_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Working Please Wait.......";
                ExecuteCommand("Office_2019.bat");
            

        }

        private void ExecuteCommand(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            //Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            //Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            // Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");

            if (exitCode == 1)
            {
                MessageBox.Show("Failed,Try Again","Office 2019 Activation");
            }
            else
            {
                MessageBox.Show("Sucessfully Process Completed", "Office 2019 Activation");
            }


            richTextBox1.AppendText(output);
            process.Close();
        }

    }
}
