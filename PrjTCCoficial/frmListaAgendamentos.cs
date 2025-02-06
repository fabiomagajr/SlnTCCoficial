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
    public partial class frmListaAgendamentos : PrjTCCoficial.frmPadraoFilhos
    {
        public frmListaAgendamentos()
        {
            InitializeComponent();
        }
        private void ListarAgendamentos()
        {
            var objBLAgendamento = new BLAgendamento();
            var objMLAgendamento = new MLAgendamento();
            List<MLAgendamento> objListaAgendamentos = new List<MLAgendamento>();

            objMLAgendamento.DataAgendamento = (string.IsNullOrEmpty(txtCodAgendamentos.Text) ? null : txtCodAgendamentos.Text);
            objMLAgendamento.CodServico = Convert.ToInt32(string.IsNullOrEmpty(cmbServicos.SelectedValue.ToString()) ? null : cmbServicos.SelectedValue.ToString());

            objListaAgendamentos = objBLAgendamento.Consultar(objMLAgendamento);

            lstAgendamento.Items.Clear();

            foreach (var item in objListaAgendamentos)
            {
                ListViewItem objListViewItem = new ListViewItem();

                objListViewItem.Text = item.CodCliente.ToString();
                objListViewItem.SubItems.Add(Convert.ToString(item.CodServico));
                objListViewItem.SubItems.Add(item.DataAgendamento);
                objListViewItem.SubItems.Add(item.HoraInicio);
                objListViewItem.SubItems.Add(item.HoraTermino);
                objListViewItem.SubItems.Add(item.ObsAgendamento);

                lstAgendamento.Items.Add(objListViewItem);
            }
        }
        private void frmListaAgendamentos_Load(object sender, EventArgs e)
        {
            try
            {
                carregarServico();
                ListarAgendamentos();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                ListarAgendamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void txtCodAgendamentos_ValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ListarAgendamentos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        

        private void carregarServico() 
        {
            BLServicos objBLServico = new BLServicos();
            MLServicos objMLServico = new MLServicos();

            cmbServicos.DataSource = objBLServico.Consultar(objMLServico);
            cmbServicos.DisplayMember = "NomeServico";
            cmbServicos.ValueMember = "CodServico";
        }

        
    }
}
