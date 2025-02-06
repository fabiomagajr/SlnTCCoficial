using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTCCoficial
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Increment(30);
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
            
        }
    }
}
