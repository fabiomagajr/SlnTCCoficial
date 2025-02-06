namespace PrjTCCoficial
{
    partial class frmListaUsuarios
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SenhaCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpfCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(508, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(526, 39);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(14, 250);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(109, 250);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(201, 250);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.nomeCliente,
            this.SenhaCliente,
            this.cpfCliente});
            this.lstUsuarios.FullRowSelect = true;
            this.lstUsuarios.GridLines = true;
            this.lstUsuarios.Location = new System.Drawing.Point(15, 76);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(586, 158);
            this.lstUsuarios.TabIndex = 3;
            this.lstUsuarios.UseCompatibleStateImageBehavior = false;
            this.lstUsuarios.View = System.Windows.Forms.View.Details;
            this.lstUsuarios.DoubleClick += new System.EventHandler(this.lstUsuarios_DoubleClick);
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
            // SenhaCliente
            // 
            this.SenhaCliente.Text = "Senha";
            this.SenhaCliente.Width = 153;
            // 
            // cpfCliente
            // 
            this.cpfCliente.Text = "Tipo";
            this.cpfCliente.Width = 90;
            // 
            // frmListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 297);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmListaUsuarios";
            this.Text = "Lista de Usuários";
            this.Load += new System.EventHandler(this.frmListaUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListView lstUsuarios;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader nomeCliente;
        private System.Windows.Forms.ColumnHeader SenhaCliente;
        private System.Windows.Forms.ColumnHeader cpfCliente;
    }
}