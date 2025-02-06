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
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           // MessageBox.Show(monthCalendar1.SelectionStart.ToShortDateString());
        }
    }
}
