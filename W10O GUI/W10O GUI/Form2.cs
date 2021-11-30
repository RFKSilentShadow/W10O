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
    public partial class TYPIC : Form
    {
        public TYPIC()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //Start full optimazition
        private void button1_Click(object sender, EventArgs e)
        {
            full();
            reboot();
        }

        //Start post optimazition
        private void button2_Click(object sender, EventArgs e)
        {
            post();
            reboot();
        }

        //Restart after optimization?
        public void reboot()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want reboot the computer?", "W10O GUI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("shutdown.exe", "-r -t 0");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        //Full optimization
        public void full()
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

            //Start RBW.bat (Remove BloatWare)
            exe = "RBW";
            psi = new ProcessStartInfo();
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

            //Start post optimization section
            post();
        }

        //Post optimization
        public void post()
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

            //Start WUD.bat (Kill Windows UpDate)
            exe = "WUD.bat";
            psi = new ProcessStartInfo();
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

            //Start RRF.bat (Remove Reemaining Files)
            exe = "RRF.bat";
            psi = new ProcessStartInfo();
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
