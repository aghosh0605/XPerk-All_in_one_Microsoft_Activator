using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silicon_Hertz_Tool
{
    public partial class check_os : Form
    {
        public check_os()
        {
            InitializeComponent();
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

            // if (exitCode == 1)
            // {
            //  MessageBox.Show("Command Failed!");
            // }
            // else
            // {
            // MessageBox.Show("Command Success!");
            // }


            //richTextBox1.AppendText(output);
            richTextBox1.Text = output;
            process.Close();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            richTextBox1.Text = "Please wait.....";
            ExecuteCommand("systeminfo | findstr OS && echo ___________________________________________________________________________");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
