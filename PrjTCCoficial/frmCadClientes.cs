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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        public frmCadClientes(MLClientes _objMlClientes)
        {
            objMlClientes = _objMlClientes;
            InitializeComponent();
        }

        #region variaveis publicas
        public MLClientes objMlClientes = new MLClientes();
        #endregion

        private void Gravar(MLClientes objMLClientes)
        {
            try
            {
                var objBLClientes = new BLClientes();

                if (objBLClientes.Gravar(objMLClientes) > 0)
                {
                    MessageBox.Show("Gravado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro gravado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Atualizar(MLClientes objMLClientes)
        {
            try
            {
                var objBLClientes = new BLClientes();

                if (objBLClientes.Atualizar(objMLClientes) > 0)
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
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtCpf.Text) && !string.IsNullOrEmpty(txtNascimento.Text))
            {
                var objBLClientes = new BLClientes();
               
                objMlClientes.NomeCliente = txtNome.Text;
                objMlClientes.TipoCliente = txtTipoCliente.Text;
                objMlClientes.CpfCnpjCliente = txtCpf.Text;
                objMlClientes.IdentidadeCliente = txtIdentidade.Text;
                objMlClientes.DataNascCliente = txtNascimento.Text;
                objMlClientes.EmailCliente = txtEmail.Text;
                objMlClientes.EnderecoCliente = txtEndereco.Text;
                objMlClientes.NEnderecoClienteE = txtN.Text;
                objMlClientes.ComplementoCliente = txtComplemento.Text;
                objMlClientes.BairroCliente = txtBairro.Text;
                objMlClientes.CidadeCliente = txtCidade.Text;
                objMlClientes.CepCliente = txtCep.Text;
                objMlClientes.UfCliente = cmbUf.Text;
                objMlClientes.TelefoneCliente = txtTelefone.Text;
                objMlClientes.Celular1Cliente = txtCelular.Text;
                objMlClientes.Celular2Cliente = txtCelular2.Text;
                objMlClientes.ObsCliente = txtObs.Text;

                if (objMlClientes.CodCliente > 0)
                {
                   
                    Atualizar(objMlClientes);
                }
                else
                {
                    
                    Gravar(objMlClientes);
                }
            }
            else
            {
                erpClientes.Clear();
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    erpClientes.SetError(txtNome, "Informe o nome.");
                }
                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    erpClientes.SetError(txtCpf, "Informe o CPF.");
                }
                if (string.IsNullOrEmpty(txtNascimento.Text))
                {
                    erpClientes.SetError(txtNascimento, "Informe a data de nascimento.");
                }
            }
            
                        
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            try
            {

                if (objMlClientes.CodCliente > 0)
                {
                    btnGravar.Text = "Alterar";

                    txtNome.Text = objMlClientes.NomeCliente;
                    txtTipoCliente.SelectedText = objMlClientes.TipoCliente == "Pessoa Física" ? "Pessoa Física" : "Pessoa Jurídica";
                    txtCpf.Text = objMlClientes.CpfCnpjCliente;
                    txtIdentidade.Text = objMlClientes.IdentidadeCliente;
                    txtNascimento.Text = objMlClientes.DataNascCliente;
                    txtEmail.Text = objMlClientes.EmailCliente;
                    txtEndereco.Text = objMlClientes.EnderecoCliente;
                    txtN.Text = objMlClientes.NEnderecoClienteE;
                    txtComplemento.Text = objMlClientes.ComplementoCliente;
                    txtBairro.Text = objMlClientes.BairroCliente;
                    txtCidade.Text = objMlClientes.CidadeCliente;
                    txtCep.Text=objMlClientes.CepCliente;
                    cmbUf.SelectedItem = objMlClientes.UfCliente;
                    txtTelefone.Text = objMlClientes.TelefoneCliente;
                    txtCelular.Text = objMlClientes.Celular1Cliente;
                    txtCelular2.Text = objMlClientes.Celular2Cliente;
                    txtObs.Text = objMlClientes.ObsCliente;
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
