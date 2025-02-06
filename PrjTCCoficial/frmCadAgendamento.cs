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
    public partial class frmCadAgendamento : PrjTCCoficial.frmPadraoFilhos
    {
        public frmCadAgendamento()
        {
            InitializeComponent();
        }
        MLAgendamento objMlAgendamento = new MLAgendamento();
        public frmCadAgendamento(MLAgendamento _objMlAgendamento)
        {
            objMlAgendamento = _objMlAgendamento;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaClientes objlistarCliente = new frmListaClientes();
            objlistarCliente.ShowDialog();
           
        }
        private void Gravar(MLAgendamento objMLAgendamento)
        {
            try
            {
                var objBLAgendamento = new BLAgendamento();

                if (objBLAgendamento.Gravar(objMLAgendamento) > 0)
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
        private void Atualizar(MLAgendamento objMLAgendamento)
        {
            try
            {
                var objBLAgendamento = new BLAgendamento();

                if (objBLAgendamento.Atualizar(objMLAgendamento) > 0)
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
            if (!string.IsNullOrEmpty(txtCodCliente.Text) && !string.IsNullOrEmpty(txtNomeCliente.Text) && !string.IsNullOrEmpty(txtCodServico.Text))
            {
                var objBLAgendamento = new BLAgendamento();

                objMlAgendamento.CodCliente = Convert.ToInt32(txtCodCliente.Text);
                objMlAgendamento.CodServico = Convert.ToInt32(txtCodServico.Text);
                objMlAgendamento.DataAgendamento = txtData.Text;
                objMlAgendamento.HoraInicio = txtHoraInicio.Text;
                objMlAgendamento.HoraTermino= txtHoraFim.Text;
                objMlAgendamento.ObsAgendamento = txtObs.Text;
                
               

                if (objMlAgendamento.CodAgendamento > 0)
                {

                    Atualizar(objMlAgendamento);
                }
                else
                {

                    Gravar(objMlAgendamento);
                }
            }
            else
            {
                erpAgendamento.Clear();
                if (string.IsNullOrEmpty(txtNomeCliente.Text))
                {
                    erpAgendamento.SetError(txtNomeCliente, "Informe qual é o cliente.");
                }
                if (string.IsNullOrEmpty(txtNomeServico.Text))
                {
                    erpAgendamento.SetError(txtNomeServico, "Informe qual é o serviço.");
                }
                if (string.IsNullOrEmpty(txtData.Text))
                {
                    erpAgendamento.SetError(txtData, "Informe a data.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListaServicos objListarServicos = new frmListaServicos();
            objListarServicos.ShowDialog();

        }

        private void btnBuscaHorario_Click(object sender, EventArgs e)
        {
            frmSelecionarHorario objSelecionaHorario = new frmSelecionarHorario();
            objSelecionaHorario.ShowDialog();
        }
    }
}
