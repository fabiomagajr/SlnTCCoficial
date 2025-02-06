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
    public partial class frmCadUsuarios : Form
    {
        public frmCadUsuarios()
        {
            InitializeComponent();
        }

        public frmCadUsuarios(MLUsuarios _MLUsuario)
        {
            objMLUsuario = _MLUsuario;
            InitializeComponent();
        }

        #region variaveis publicas
        public MLUsuarios objMLUsuario = new MLUsuarios();
        #endregion

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtCSenha.Text)
            {
                if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtSenha.Text))
                {
                    objMLUsuario.LoginUsuario = txtLogin.Text;
                    objMLUsuario.SenhaUsuario = txtSenha.Text;
                    objMLUsuario.TipoUsuario = cbxTipo.SelectedItem == "Administrador" ? 1 : 2;

                    if (objMLUsuario.CodUsuario > 0)
                    {
                        Atualizar(objMLUsuario);
                    }
                    else
                    {
                        Gravar(objMLUsuario);
                    }
                }
                else
                {
                    erpUsuario.Clear();
                    if (string.IsNullOrEmpty(txtLogin.Text))
                    {
                        erpUsuario.SetError(txtLogin, "Informe o Login.");
                    }
                    if (string.IsNullOrEmpty(txtSenha.Text))
                    {
                        erpUsuario.SetError(txtSenha, "Informe a Senha.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Senhas não conferem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtCSenha.Text = "";
                txtSenha.Focus();
            }
        }

        private void Gravar(MLUsuarios objMLUsuarios)
        {
            try
            {
                var objBLUsuarios = new BLUsuarios();

                if (objBLUsuarios.Gravar(objMLUsuario) > 0)
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

        public void Atualizar(MLUsuarios objMLUsuario) 
        {
            try
            {
                var objBLUsuarios = new BLUsuarios();

                if (objBLUsuarios.Atualizar(objMLUsuario) > 0)
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

        private void frmCadUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                if (objMLUsuario.CodUsuario > 0)
                {
                    btnGravar.Text = "Alterar";

                    txtLogin.Text = objMLUsuario.LoginUsuario;
                    txtSenha.Text = objMLUsuario.SenhaUsuario;
                    cbxTipo.SelectedText = objMLUsuario.TipoUsuario == 1 ? "Administrador" : "Operador";
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
