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
    public partial class frmListaServicos : PrjTCCoficial.frmPadraoFilhos
    {
        public frmListaServicos()
        {
            InitializeComponent();
        }
        private void ListarServicos()
        {
            var objBLServicos = new BLServicos();
            var objMLServicos = new MLServicos();
            List<MLServicos> objListaServicos = new List<MLServicos>();

            objMLServicos.NomeServico = (String.IsNullOrEmpty(txtNome.Text)) ? null : txtNome.Text;

            objListaServicos = objBLServicos.Consultar(objMLServicos);

            lstServicos.Items.Clear();

            foreach (var item in objListaServicos)
            {
                ListViewItem objListViewItem = new ListViewItem();

                objListViewItem.Text = item.CodServico.ToString();
                objListViewItem.SubItems.Add(item.NomeServico);
                objListViewItem.SubItems.Add(item.DuracaoServico);
                objListViewItem.SubItems.Add(item.ObsServico);

                lstServicos.Items.Add(objListViewItem);
            }
        }
        private void frmListaServicos_Load(object sender, EventArgs e)
        {
            ListarServicos();
        }
        public void Alterar()
        {
            try
            {
                var objMLServicos = new MLServicos();

                if (lstServicos.SelectedItems.Count > 0)
                {
                    objMLServicos.CodServico = Convert.ToInt32(lstServicos.SelectedItems[0].Text);
                    objMLServicos.NomeServico = lstServicos.SelectedItems[0].SubItems[1].Text;
                    objMLServicos.DuracaoServico = lstServicos.SelectedItems[0].SubItems[2].Text;
                    objMLServicos.ObsServico = lstServicos.SelectedItems[0].SubItems[3].Text;

                    frmCadServicos objFrmCadServicos = new frmCadServicos(objMLServicos);
                    objFrmCadServicos.ShowDialog();
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
            ListarServicos();
        }
        private void Excluir()
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var objBLServicos = new BLServicos();

                    if (lstServicos.SelectedItems.Count > 0)
                    {
                        objBLServicos.Excluir(Convert.ToInt32(lstServicos.SelectedItems[0].Text));
                        ListarServicos();
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
