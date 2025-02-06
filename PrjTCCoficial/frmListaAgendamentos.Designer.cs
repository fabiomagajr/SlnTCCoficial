namespace PrjTCCoficial
{
    partial class frmListaAgendamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAgendamento = new System.Windows.Forms.ListView();
            this.Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Servico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoraInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoraFim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OBS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNome = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtCodAgendamentos = new System.Windows.Forms.DateTimePicker();
            this.cmbServicos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAgendamento
            // 
            this.lstAgendamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cliente,
            this.Servico,
            this.Data,
            this.HoraInicio,
            this.HoraFim,
            this.OBS});
            this.lstAgendamento.FullRowSelect = true;
            this.lstAgendamento.GridLines = true;
            this.lstAgendamento.Location = new System.Drawing.Point(12, 68);
            this.lstAgendamento.Name = "lstAgendamento";
            this.lstAgendamento.Size = new System.Drawing.Size(593, 165);
            this.lstAgendamento.TabIndex = 17;
            this.lstAgendamento.UseCompatibleStateImageBehavior = false;
            this.lstAgendamento.View = System.Windows.Forms.View.Details;
            // 
            // Cliente
            // 
            this.Cliente.Text = "Cliente";
            this.Cliente.Width = 65;
            // 
            // Servico
            // 
            this.Servico.Text = "Serviço";
            this.Servico.Width = 73;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 137;
            // 
            // HoraInicio
            // 
            this.HoraInicio.Text = "Início";
            this.HoraInicio.Width = 74;
            // 
            // HoraFim
            // 
            this.HoraFim.Text = "Fim";
            this.HoraFim.Width = 75;
            // 
            // OBS
            // 
            this.OBS.Text = "OBS";
            this.OBS.Width = 165;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(168, 21);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Data de Agendamento:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(198, 242);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 30);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(106, 242);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 30);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(11, 242);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 30);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(523, 29);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(82, 30);
            this.btnBusca.TabIndex = 15;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtCodAgendamentos
            // 
            this.txtCodAgendamentos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCodAgendamentos.Location = new System.Drawing.Point(12, 33);
            this.txtCodAgendamentos.Name = "txtCodAgendamentos";
            this.txtCodAgendamentos.Size = new System.Drawing.Size(200, 29);
            this.txtCodAgendamentos.TabIndex = 18;
            // 
            // cmbServicos
            // 
            this.cmbServicos.FormattingEnabled = true;
            this.cmbServicos.Location = new System.Drawing.Point(249, 33);
            this.cmbServicos.Name = "cmbServicos";
            this.cmbServicos.Size = new System.Drawing.Size(200, 29);
            this.cmbServicos.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Serviços:";
            // 
            // frmListaAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(631, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbServicos);
            this.Controls.Add(this.txtCodAgendamentos);
            this.Controls.Add(this.lstAgendamento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBusca);
            this.Name = "frmListaAgendamentos";
            this.Text = "Listar Agendamentos";
            this.Load += new System.EventHandler(this.frmListaAgendamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstAgendamento;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader Servico;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.ColumnHeader HoraInicio;
        private System.Windows.Forms.ColumnHeader HoraFim;
        private System.Windows.Forms.ColumnHeader OBS;
        private System.Windows.Forms.DateTimePicker txtCodAgendamentos;
        private System.Windows.Forms.ComboBox cmbServicos;
        private System.Windows.Forms.Label label1;
    }
}
