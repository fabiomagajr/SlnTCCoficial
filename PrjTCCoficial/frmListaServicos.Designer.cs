namespace PrjTCCoficial
{
    partial class frmListaServicos
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
            this.lstServicos = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeServico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuracaoServico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObsServico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNome = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstServicos
            // 
            this.lstServicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.NomeServico,
            this.DuracaoServico,
            this.ObsServico});
            this.lstServicos.FullRowSelect = true;
            this.lstServicos.GridLines = true;
            this.lstServicos.Location = new System.Drawing.Point(12, 70);
            this.lstServicos.Name = "lstServicos";
            this.lstServicos.Size = new System.Drawing.Size(586, 158);
            this.lstServicos.TabIndex = 10;
            this.lstServicos.UseCompatibleStateImageBehavior = false;
            this.lstServicos.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 73;
            // 
            // NomeServico
            // 
            this.NomeServico.Text = "Nome";
            this.NomeServico.Width = 236;
            // 
            // DuracaoServico
            // 
            this.DuracaoServico.Text = "Duração";
            this.DuracaoServico.Width = 153;
            // 
            // ObsServico
            // 
            this.ObsServico.Text = "OBS";
            this.ObsServico.Width = 150;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 21);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome Serviço:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(198, 244);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(84, 30);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(106, 244);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(84, 30);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(11, 244);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 30);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(514, 31);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(84, 30);
            this.btnBusca.TabIndex = 8;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(499, 29);
            this.txtNome.TabIndex = 4;
            // 
            // frmListaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(615, 290);
            this.Controls.Add(this.lstServicos);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtNome);
            this.Name = "frmListaServicos";
            this.Text = "Listar Serviços";
            this.Load += new System.EventHandler(this.frmListaServicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstServicos;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader NomeServico;
        private System.Windows.Forms.ColumnHeader DuracaoServico;
        private System.Windows.Forms.ColumnHeader ObsServico;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtNome;
    }
}
