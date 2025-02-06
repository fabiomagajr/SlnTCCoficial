using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ModelLayer;
using BusinessLayer;

namespace PrjTCCoficial
{
    public partial class frmListaClientes : PrjTCCoficial.frmPadraoFilhos
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void ListarClientes()
        {
            var objBLClientes = new BLClientes();
            var objMLClientes = new MLClientes();
            List<MLClientes> objListaClientes = new List<MLClientes>();

            objMLClientes.NomeCliente = (String.IsNullOrEmpty(txtNome.Text)) ? null : txtNome.Text; 

            objListaClientes = objBLClientes.Consultar(objMLClientes);

            lstClientes.Items.Clear();

            foreach (var item in objListaClientes)
            {
                ListViewItem objListViewItem = new ListViewItem();

                objListViewItem.Text = item.CodCliente.ToString();
                objListViewItem.SubItems.Add(item.NomeCliente);
                objListViewItem.SubItems.Add(item.TipoCliente);
                objListViewItem.SubItems.Add(item.CpfCnpjCliente);
                objListViewItem.SubItems.Add(item.IdentidadeCliente);
                objListViewItem.SubItems.Add(item.DataNascCliente);
                objListViewItem.SubItems.Add(item.EmailCliente);
                objListViewItem.SubItems.Add(item.EnderecoCliente);
                objListViewItem.SubItems.Add(item.NEnderecoClienteE);
                objListViewItem.SubItems.Add(item.ComplementoCliente);
                objListViewItem.SubItems.Add(item.BairroCliente);
                objListViewItem.SubItems.Add(item.CidadeCliente);
                objListViewItem.SubItems.Add(item.CepCliente);
                objListViewItem.SubItems.Add(item.UfCliente);
                objListViewItem.SubItems.Add(item.TelefoneCliente);
                objListViewItem.SubItems.Add(item.Celular1Cliente);
                objListViewItem.SubItems.Add(item.Celular2Cliente);
                objListViewItem.SubItems.Add(item.ObsCliente);
             

                lstClientes.Items.Add(objListViewItem);
            }
        }
        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

        }
        public void Alterar()
        {
            try
            {
                var objMLClientes = new MLClientes();

                if (lstClientes.SelectedItems.Count > 0)
                {

                    objMLClientes.CodCliente = Convert.ToInt32(lstClientes.SelectedItems[0].Text);
                    objMLClientes.NomeCliente = lstClientes.SelectedItems[0].SubItems[1].Text;
                    objMLClientes.TipoCliente = lstClientes.SelectedItems[0].SubItems[2].Text;
                    objMLClientes.CpfCnpjCliente = lstClientes.SelectedItems[0].SubItems[3].Text;
                    objMLClientes.IdentidadeCliente = lstClientes.SelectedItems[0].SubItems[4].Text;
                    objMLClientes.DataNascCliente = lstClientes.SelectedItems[0].SubItems[5].Text;
                    objMLClientes.EmailCliente = lstClientes.SelectedItems[0].SubItems[6].Text;
                    objMLClientes.EnderecoCliente = lstClientes.SelectedItems[0].SubItems[7].Text;
                    objMLClientes.NEnderecoClienteE = lstClientes.SelectedItems[0].SubItems[8].Text;
                    objMLClientes.ComplementoCliente = lstClientes.SelectedItems[0].SubItems[9].Text;
                    objMLClientes.BairroCliente = lstClientes.SelectedItems[0].SubItems[10].Text;
                    objMLClientes.CidadeCliente = lstClientes.SelectedItems[0].SubItems[11].Text;
                    objMLClientes.CepCliente = lstClientes.SelectedItems[0].SubItems[12].Text;
                    objMLClientes.UfCliente = lstClientes.SelectedItems[0].SubItems[13].Text;
                    objMLClientes.TelefoneCliente = lstClientes.SelectedItems[0].SubItems[14].Text;
                    objMLClientes.Celular1Cliente = lstClientes.SelectedItems[0].SubItems[15].Text;
                    objMLClientes.Celular2Cliente = lstClientes.SelectedItems[0].SubItems[16].Text;
                    objMLClientes.ObsCliente = lstClientes.SelectedItems[0].SubItems[17].Text;
                  
                    frmCadClientes objFrmCadClientes = new frmCadClientes(objMLClientes);
                    objFrmCadClientes.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
            ListarClientes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadClientes objFrmCadClientes = new frmCadClientes();
            objFrmCadClientes.ShowDialog();
        }
        private void Excluir()
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var objBLClientes = new BLClientes();

                    if (lstClientes.SelectedItems.Count > 0)
                    {
                        objBLClientes.Excluir(Convert.ToInt32(lstClientes.SelectedItems[0].Text));
                        ListarClientes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
