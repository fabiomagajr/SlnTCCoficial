namespace PrjTCCoficial
{
    partial class frmCadServicos
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
            this.gpbTipoAtendimento = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.erpServicos = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbTipoAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbTipoAtendimento
            // 
            this.gpbTipoAtendimento.Controls.Add(this.label3);
            this.gpbTipoAtendimento.Controls.Add(this.txtObs);
            this.gpbTipoAtendimento.Controls.Add(this.txtDuracao);
            this.gpbTipoAtendimento.Controls.Add(this.label2);
            this.gpbTipoAtendimento.Controls.Add(this.label1);
            this.gpbTipoAtendimento.Controls.Add(this.txtNomeServico);
            this.gpbTipoAtendimento.Location = new System.Drawing.Point(12, 12);
            this.gpbTipoAtendimento.Name = "gpbTipoAtendimento";
            this.gpbTipoAtendimento.Size = new System.Drawing.Size(421, 198);
            this.gpbTipoAtendimento.TabIndex = 0;
            this.gpbTipoAtendimento.TabStop = false;
            this.gpbTipoAtendimento.Text = "Tipo de Atendimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "OBS.:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(102, 88);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(301, 100);
            this.txtObs.TabIndex = 5;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(102, 62);
            this.txtDuracao.Mask = "00:00";
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(80, 20);
            this.txtDuracao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duração Média:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome de serviço:";
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Location = new System.Drawing.Point(102, 36);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(301, 20);
            this.txtNomeServico.TabIndex = 0;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(358, 216);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(197, 216);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(278, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // erpServicos
            // 
            this.erpServicos.ContainerControl = this;
            // 
            // frmCadServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 248);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gpbTipoAtendimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCadServicos";
            this.Text = "Cadastro de Serviço";
            this.Load += new System.EventHandler(this.frmCadServicos_Load);
            this.gpbTipoAtendimento.ResumeLayout(false);
            this.gpbTipoAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTipoAtendimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.MaskedTextBox txtDuracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider erpServicos;
    }
}