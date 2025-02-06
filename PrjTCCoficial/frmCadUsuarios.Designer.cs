namespace PrjTCCoficial
{
    partial class frmCadUsuarios
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.txtCSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbDadosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(96, 29);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(229, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(96, 55);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(229, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.cbxTipo.Location = new System.Drawing.Point(96, 107);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(154, 21);
            this.cbxTipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo:";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(269, 144);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // gpbDadosUsuario
            // 
            this.gpbDadosUsuario.Controls.Add(this.txtCSenha);
            this.gpbDadosUsuario.Controls.Add(this.label4);
            this.gpbDadosUsuario.Controls.Add(this.txtLogin);
            this.gpbDadosUsuario.Controls.Add(this.btnGravar);
            this.gpbDadosUsuario.Controls.Add(this.label1);
            this.gpbDadosUsuario.Controls.Add(this.label3);
            this.gpbDadosUsuario.Controls.Add(this.txtSenha);
            this.gpbDadosUsuario.Controls.Add(this.cbxTipo);
            this.gpbDadosUsuario.Controls.Add(this.label2);
            this.gpbDadosUsuario.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosUsuario.Name = "gpbDadosUsuario";
            this.gpbDadosUsuario.Size = new System.Drawing.Size(358, 185);
            this.gpbDadosUsuario.TabIndex = 7;
            this.gpbDadosUsuario.TabStop = false;
            this.gpbDadosUsuario.Text = "Dados de Usuário";
            // 
            // txtCSenha
            // 
            this.txtCSenha.Location = new System.Drawing.Point(96, 81);
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.Size = new System.Drawing.Size(229, 20);
            this.txtCSenha.TabIndex = 2;
            this.txtCSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar senha:";
            // 
            // erpUsuario
            // 
            this.erpUsuario.ContainerControl = this;
            // 
            // frmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 210);
            this.Controls.Add(this.gpbDadosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCadUsuarios";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmCadUsuarios_Load);
            this.gpbDadosUsuario.ResumeLayout(false);
            this.gpbDadosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox gpbDadosUsuario;
        private System.Windows.Forms.ErrorProvider erpUsuario;
        private System.Windows.Forms.TextBox txtCSenha;
        private System.Windows.Forms.Label label4;
    }
}