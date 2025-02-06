using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTCCoficial
{
    static class Program
    {
        /// <summary>            
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            
            frmLogin flogin = new frmLogin();
            frmSplash fsplash = new frmSplash();
            fsplash.ShowDialog();
                if (flogin.ShowDialog() == DialogResult.Yes)
                {
                    Application.Run(new frmInicio());
                    //Application.Run(new FrmSplash());
                }
                
            }
        }
    }

