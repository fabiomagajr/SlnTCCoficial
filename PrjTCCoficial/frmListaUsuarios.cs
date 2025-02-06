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
    public partial class frmListaUsuarios : Form
    {
        public frmListaUsuarios()
        {
            InitializeComponent();
        }

        private void frmListaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {

                ListarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }
            
        }

        private void ListarUsuarios()
        {
            var objBLUsuarios = new BLUsuarios();
            var objMLUsuarios = new MLUsuarios();
            List<MLUsuarios> objListaUsuarios = new List<MLUsuarios>();

            objMLUsuarios.LoginUsuario = (String.IsNullOrEmpty(txtNome.Text)) ? null : txtNome.Text;

            objListaUsuarios = objBLUsuarios.Consultar(objMLUsuarios);

            lstUsuarios.Items.Clear();

            foreach (var item in objListaUsuarios)
            {
                ListViewItem objListViewItem = new ListViewItem();

                objListViewItem.Text = item.CodUsuario.ToString();
                objListViewItem.SubItems.Add(item.LoginUsuario);
                objListViewItem.SubItems.Add(item.SenhaUsuario);
                objListViewItem.SubItems.Add(item.TipoUsuario == 1 ? "Administrador" : "Operador");

                lstUsuarios.Items.Add(objListViewItem);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
            ListarUsuarios();
        }

        public void Alterar() 
        {
            try
            {
                var objMLUsuario = new MLUsuarios();

                if (lstUsuarios.SelectedItems.Count > 0)
                {
                    objMLUsuario.CodUsuario = Convert.ToInt32(lstUsuarios.SelectedItems[0].Text);
                    objMLUsuario.LoginUsuario = lstUsuarios.SelectedItems[0].SubItems[1].Text;
                    objMLUsuario.SenhaUsuario = lstUsuarios.SelectedItems[0].SubItems[2].Text;
                    objMLUsuario.TipoUsuario = Convert.ToInt32(lstUsuarios.SelectedItems[0].SubItems[3].Text == "Administrador" ? 1 : 2 );

                    frmCadUsuarios objFrmCadUsuario = new frmCadUsuarios(objMLUsuario);
                    objFrmCadUsuario.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadUsuarios objFrmCadUsuario = new frmCadUsuarios();
            objFrmCadUsuario.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void Excluir()
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var objBLUsuario = new BLUsuarios();                    

                    if (lstUsuarios.SelectedItems.Count > 0)
                    {
                        objBLUsuario.Excluir(Convert.ToInt32(lstUsuarios.SelectedItems[0].Text));
                        ListarUsuarios();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstUsuarios_DoubleClick(object sender, EventArgs e)
        {
            Alterar();
            ListarUsuarios();
        }
    }
}
