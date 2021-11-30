using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace W10O_GUI
{
    public partial class CUSTOM : Form
    {
        public CUSTOM()
        {
            InitializeComponent();
        }

        private void CUSTOM_Load(object sender, EventArgs e)
        {

        }

        //Kill Windows Defender
        private void DEF_Click(object sender, EventArgs e)
        {

            //Start DEF.bat (Kill Windows Defender)
            string exe = "DEF.bat";
            var psi = new ProcessStartInfo();
            psi.WorkingDirectory = "DEF";
            psi.CreateNoWindow = true;
            psi.FileName = @"cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/C " + exe;
            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {
                
            }
        }

        //Kill Windows UpDate 
        private void WUD_Click(object sender, EventArgs e)
        {

            //Start WUD.bat (Kill Windows UpDate)
            string exe = "WUD.bat";
            var psi = new ProcessStartInfo();
            psi.WorkingDirectory = "WUD";
            psi.CreateNoWindow = true;
            psi.FileName = @"cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/C " + exe;
            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {
                
            }
        }


        //Configure Power Managemant
        private void PWRMGMT_Click(object sender, EventArgs e)
        {

            //Start PWRMGMT.bat
            string exe = "PWRMGMT.bat";
            var psi = new ProcessStartInfo();
            psi.CreateNoWindow = true;
            psi.FileName = @"cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/C " + exe;
            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {
                
            }
        }

        //Remove BloatWare
        private void RBW_Click(object sender, EventArgs e)
        {

            //Start RBW.bat (Remove BloatWare)
            string exe = "RBW.bat";
            var psi = new ProcessStartInfo();
            psi.CreateNoWindow = true;
            psi.FileName = @"cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/C " + exe;
            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {
                
            }
        }

        //Remove Remaining Files
        private void RRF_Click(object sender, EventArgs e)
        {

            //Start RRF.bat (Remove Reemaining Files)
            string exe = "RRF.bat";
            var psi = new ProcessStartInfo();
            psi.CreateNoWindow = true;
            psi.FileName = @"cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/C " + exe;
            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
