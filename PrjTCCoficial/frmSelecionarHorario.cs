using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjTCCoficial
{
    public partial class frmSelecionarHorario : PrjTCCoficial.frmPadraoFilhos
    {
        public frmSelecionarHorario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
