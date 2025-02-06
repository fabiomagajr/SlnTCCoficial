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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
        int tentativas = 0;
        private void btnAcessar_Click(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                var objBLUsuario = new BLUsuarios();
                List<MLUsuarios> objListausuario = new List<MLUsuarios>();
                objListausuario = objBLUsuario.Login(txtUsuario.Text, txtSenha.Text);

                if (objListausuario.Count > 0)
                {
                    Usuario.CodUsuario = objListausuario[0].CodUsuario;
                    Usuario.LoginUsuario = objListausuario[0].LoginUsuario;
                    Usuario.SenhaUsuario = objListausuario[0].SenhaUsuario;
                    Usuario.TipoUsuario = objListausuario[0].TipoUsuario;

                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    tentativas++;
                    MessageBox.Show("Nome de Usuário ou Senha Incorreto" + "\n Você está na tentativa: " + tentativas.ToString() + " de 3 tentativas" + "\nO programa será encerrado após a terceira tentativa");

                    txtUsuario.Text = "";
                    txtSenha.Text = "";

                    txtUsuario.Focus();

                    if (tentativas == 3)
                    {
                        MessageBox.Show("Você atingiu o limite de tentativas.", "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.ExitThread();
                    }
                }
            }
            else 
            {
                erpLogin.Clear();

                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    erpLogin.SetError(txtUsuario, "Informe o usuário.");
                }
                if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    erpLogin.SetError(txtSenha, "Informe a senha.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        Application.ExitThread();
        }
            
            
            //this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            //this.Close();
        }

       
    }

