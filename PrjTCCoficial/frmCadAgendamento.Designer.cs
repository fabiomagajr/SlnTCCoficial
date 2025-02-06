namespace PrjTCCoficial
{
    partial class frmCadAgendamento
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscaHorario = new System.Windows.Forms.Button();
            this.txtCodServico = new System.Windows.Forms.TextBox();
            this.btnBuscaServico = new System.Windows.Forms.Button();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.erpAgendamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscaHorario);
            this.groupBox1.Controls.Add(this.txtCodServico);
            this.groupBox1.Controls.Add(this.btnBuscaServico);
            this.groupBox1.Controls.Add(this.txtNomeServico);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.txtHoraFim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoraInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.btnBuscaCliente);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de agendamento";
            // 
            // btnBuscaHorario
            // 
            this.btnBuscaHorario.BackgroundImage = global::PrjTCCoficial.Properties.Resources.Zoom_icon;
            this.btnBuscaHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaHorario.Location = new System.Drawing.Point(336, 95);
            this.btnBuscaHorario.Name = "btnBuscaHorario";
            this.btnBuscaHorario.Size = new System.Drawing.Size(43, 34);
            this.btnBuscaHorario.TabIndex = 7;
            this.btnBuscaHorario.UseVisualStyleBackColor = true;
            this.btnBuscaHorario.Click += new System.EventHandler(this.btnBuscaHorario_Click);
            // 
            // txtCodServico
            // 
            this.txtCodServico.Location = new System.Drawing.Point(220, 64);
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Size = new System.Drawing.Size(61, 29);
            this.txtCodServico.TabIndex = 3;
            // 
            // btnBuscaServico
            // 
            this.btnBuscaServico.BackgroundImage = global::PrjTCCoficial.Properties.Resources.Zoom_icon;
            this.btnBuscaServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaServico.Location = new System.Drawing.Point(287, 60);
            this.btnBuscaServico.Name = "btnBuscaServico";
            this.btnBuscaServico.Size = new System.Drawing.Size(43, 34);
            this.btnBuscaServico.TabIndex = 4;
            this.btnBuscaServico.UseVisualStyleBackColor = true;
            this.btnBuscaServico.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Location = new System.Drawing.Point(336, 64);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(402, 29);
            this.txtNomeServico.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(220, 99);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 29);
            this.txtData.TabIndex = 6;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "OBS.:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(220, 204);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(518, 76);
            this.txtObs.TabIndex = 10;
            // 
            // txtHoraFim
            // 
            this.txtHoraFim.Location = new System.Drawing.Point(220, 169);
            this.txtHoraFim.Mask = "00:00";
            this.txtHoraFim.Name = "txtHoraFim";
            this.txtHoraFim.Size = new System.Drawing.Size(73, 29);
            this.txtHoraFim.TabIndex = 9;
            this.txtHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora de Fim:";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(220, 134);
            this.txtHoraInicio.Mask = "00:00";
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(73, 29);
            this.txtHoraInicio.TabIndex = 8;
            this.txtHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora de Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o Atendimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o cliente:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(220, 28);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(61, 29);
            this.txtCodCliente.TabIndex = 0;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackgroundImage = global::PrjTCCoficial.Properties.Resources.Zoom_icon;
            this.btnBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCliente.Location = new System.Drawing.Point(287, 24);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(43, 34);
            this.btnBuscaCliente.TabIndex = 1;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(336, 28);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(402, 29);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 338);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 30);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(501, 338);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 30);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(600, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(681, 338);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 30);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // erpAgendamento
            // 
            this.erpAgendamento.ContainerControl = this;
            // 
            // frmCadAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(768, 378);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadAgendamento";
            this.Text = "Agendamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpAgendamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.MaskedTextBox txtHoraFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtHoraInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtCodServico;
        private System.Windows.Forms.Button btnBuscaServico;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.Button btnBuscaHorario;
        private System.Windows.Forms.ErrorProvider erpAgendamento;
    }
}
