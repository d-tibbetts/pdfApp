using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //this still needs to be tested w/o Adobe reader.
            RegistryKey software = Registry.LocalMachine.OpenSubKey("Software");

            if (software != null)
            {
                RegistryKey adobe=null;

                // Try to get 64bit versions of adobe
                if (Environment.Is64BitOperatingSystem)
                {
                    RegistryKey software64 = software.OpenSubKey("Wow6432Node");

                    if (software64 != null)
                        adobe = software64.OpenSubKey("Adobe");
                }

                // If a 64bit version is not installed, try to get a 32bit version
                if (adobe == null)
                    adobe = software.OpenSubKey("Adobe");

                // If no 64bit or 32bit version can be found, chances are adobe reader is not installed.
                if (adobe != null)
                {
                    RegistryKey acroRead = adobe.OpenSubKey("Acrobat Reader");

                    if (acroRead != null)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());
                    }
                    else
                    {
                       DialogResult result= MessageBox.Show("Adobe Reader is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                       if(result == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                        
                }
                else
                {
                    DialogResult result = MessageBox.Show("Adobe Reader is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            
        }
    }
}
