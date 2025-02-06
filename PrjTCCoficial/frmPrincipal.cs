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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você está certo disso?","Atenção!",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
        }
        public void abrirForm(Type tipoform)
        {
            bool isOpen = false;

            foreach (Form objForm in Application.OpenForms)
            {
                if (objForm.GetType().Equals(tipoform))
                {
                    objForm.Show();
                    isOpen = true;
                    break;
                }
            }

            if (!isOpen)
            {
                Form objFrm = (Form)Activator.CreateInstance(tipoform);
                objFrm.MdiParent = this;
                objFrm.Show();
            }
        }
        private void ControleAcesso(bool permissao)
        {
            usuariosToolStripMenuItem.Visible = permissao;
            usuáriosToolStripMenuItem.Visible = permissao;
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            //Adicionando usuário 
            if (Usuario.TipoUsuario == 1)
            {
                lblUsuario.Text = "Usuário Logado: " + Usuario.LoginUsuario + " Tipo Administrador";
            }
            else
            {
                lblUsuario.Text = "Usuário Logado: " + Usuario.LoginUsuario + " Tipo Usuário";
                ControleAcesso(false);
            } 
            // #1
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.AliceBlue;
                    // 4#
                    break;
                }
            }
        
            abrirForm(typeof(frmCalendario));
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblData.Text = "Data: " + DateTime.Now.ToLongDateString().ToUpper();
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmCadClientes));
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmCadServicos));
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmCadAgendamento));
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmListaUsuarios));
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmCadUsuarios));
        }

        private void dadosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmBackup));
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmListaClientes));
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmCadUsuarios));
        }

        private void cadastrosdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmListaServicos));
        }

        private void agendamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmListaAgendamentos));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmCalendario));
        }

        private void tsbNovoAgendamento_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmCadAgendamento));
        }

        private void tsbNovoCliente_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmCadClientes));
        }

        private void tsbBackup_Click(object sender, EventArgs e)
        {
            abrirForm(typeof(frmBackup));
        }
    }
}
