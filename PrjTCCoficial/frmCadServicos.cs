using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLayer;
using BusinessLayer;

namespace PrjTCCoficial
{
    public partial class frmCadServicos : Form
    {
        public frmCadServicos()
        {
            InitializeComponent();
        }
        public MLServicos objMLServicos = new MLServicos();
         public frmCadServicos(MLServicos _MLServicos)
        {
            objMLServicos = _MLServicos;
            InitializeComponent();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeServico.Text) && !string.IsNullOrEmpty(txtDuracao.Text))
            {
                objMLServicos.NomeServico = txtNomeServico.Text;
                objMLServicos.DuracaoServico = txtDuracao.Text;
                objMLServicos.ObsServico = txtObs.Text;

                if (objMLServicos.CodServico > 0)
                {
                    Atualizar(objMLServicos);
                }
                else
                {
                    Gravar(objMLServicos);
                }
            }
            else
            {
                erpServicos.Clear();
                if (string.IsNullOrEmpty(txtNomeServico.Text))
                {
                    erpServicos.SetError(txtNomeServico, "Informe o nome do serviço.");
                }
                if (string.IsNullOrEmpty(txtDuracao.Text))
                {
                    erpServicos.SetError(txtDuracao, "Informe a duração do serviço.");
                }
            }
            
        }
        public void Atualizar(MLServicos objMLUsuario)
        {
            try
            {
                var objBLServicos = new BLServicos();

                if (objBLServicos.Atualizar(objMLUsuario) > 0)
                {
                    MessageBox.Show("Atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro atualizado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Gravar(MLServicos objMLServicos)
        {
            var objBLServicos = new BLServicos();
            //MLServicos objMLServicos = new MLServicos();
            objMLServicos.NomeServico = txtNomeServico.Text;
            objMLServicos.DuracaoServico = txtDuracao.Text;
            objMLServicos.ObsServico = txtObs.Text;


            if (objBLServicos.Gravar(objMLServicos) > 0)
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao Gravar");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCadServicos_Load(object sender, EventArgs e)
        {
            try
            {
                if (objMLServicos.CodServico > 0)
                {
                    btnGravar.Text = "Alterar";

                    txtNomeServico.Text = objMLServicos.NomeServico;
                    txtDuracao.Text = objMLServicos.DuracaoServico;
                    txtObs.SelectedText = objMLServicos.ObsServico;
                }
                else
                {
                    btnGravar.Text = "Gravar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
