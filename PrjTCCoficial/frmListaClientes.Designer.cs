namespace PrjTCCoficial
{
    partial class frmListaClientes
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
            this.lstClientes = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpfCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNome = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.IdentidadeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataNascCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnderecoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComplementoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BairroCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CepCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UfCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefoneCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Celular1Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Celular2Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObsCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.nomeCliente,
            this.tipoCliente,
            this.cpfCliente,
            this.IdentidadeCliente,
            this.DataNascCliente,
            this.EmailCliente,
            this.EnderecoCliente,
            this.NCliente,
            this.ComplementoCliente,
            this.BairroCliente,
            this.CidadeCliente,
            this.CepCliente,
            this.UfCliente,
            this.TelefoneCliente,
            this.Celular1Cliente,
            this.Celular2Cliente,
            this.ObsCliente});
            this.lstClientes.FullRowSelect = true;
            this.lstClientes.GridLines = true;
            this.lstClientes.Location = new System.Drawing.Point(16, 70);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(593, 165);
            this.lstClientes.TabIndex = 10;
            this.lstClientes.UseCompatibleStateImageBehavior = false;
            this.lstClientes.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 73;
            // 
            // nomeCliente
            // 
            this.nomeCliente.Text = "Nome";
            this.nomeCliente.Width = 236;
            // 
            // tipoCliente
            // 
            this.tipoCliente.Text = "Tipo Cliente";
            this.tipoCliente.Width = 153;
            // 
            // cpfCliente
            // 
            this.cpfCliente.Text = "CPF";
            this.cpfCliente.Width = 137;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(202, 244);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 30);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(110, 244);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 30);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(15, 244);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 30);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(527, 31);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(82, 30);
            this.btnBusca.TabIndex = 8;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(508, 29);
            this.txtNome.TabIndex = 4;
            // 
            // IdentidadeCliente
            // 
            this.IdentidadeCliente.Text = "Identidade";
            // 
            // DataNascCliente
            // 
            this.DataNascCliente.Text = "Nascimento";
            // 
            // EmailCliente
            // 
            this.EmailCliente.Text = "Email";
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.Text = "Endereço";
            // 
            // NCliente
            // 
            this.NCliente.Text = "Nº";
            // 
            // ComplementoCliente
            // 
            this.ComplementoCliente.Text = "Complemento";
            // 
            // BairroCliente
            // 
            this.BairroCliente.Text = "Bairro";
            // 
            // CidadeCliente
            // 
            this.CidadeCliente.Text = "Cidade";
            // 
            // CepCliente
            // 
            this.CepCliente.Text = "CEP";
            // 
            // UfCliente
            // 
            this.UfCliente.Text = "UF";
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.Text = "Telefone";
            // 
            // Celular1Cliente
            // 
            this.Celular1Cliente.Text = "Celular 1";
            // 
            // Celular2Cliente
            // 
            this.Celular2Cliente.Text = "Celular 2";
            // 
            // ObsCliente
            // 
            this.ObsCliente.Text = "OBS";
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(630, 292);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtNome);
            this.Name = "frmListaClientes";
            this.Text = "Listar Clientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstClientes;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader nomeCliente;
        private System.Windows.Forms.ColumnHeader tipoCliente;
        private System.Windows.Forms.ColumnHeader cpfCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ColumnHeader IdentidadeCliente;
        private System.Windows.Forms.ColumnHeader DataNascCliente;
        private System.Windows.Forms.ColumnHeader EmailCliente;
        private System.Windows.Forms.ColumnHeader EnderecoCliente;
        private System.Windows.Forms.ColumnHeader NCliente;
        private System.Windows.Forms.ColumnHeader ComplementoCliente;
        private System.Windows.Forms.ColumnHeader BairroCliente;
        private System.Windows.Forms.ColumnHeader CidadeCliente;
        private System.Windows.Forms.ColumnHeader CepCliente;
        private System.Windows.Forms.ColumnHeader UfCliente;
        private System.Windows.Forms.ColumnHeader TelefoneCliente;
        private System.Windows.Forms.ColumnHeader Celular1Cliente;
        private System.Windows.Forms.ColumnHeader Celular2Cliente;
        private System.Windows.Forms.ColumnHeader ObsCliente;
    }
}
