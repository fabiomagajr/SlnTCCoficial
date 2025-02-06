namespace PrjTCCoficial
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRelogio = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCalendario = new System.Windows.Forms.ToolStripButton();
            this.tsbNovoAgendamento = new System.Windows.Forms.ToolStripButton();
            this.tsbNovoCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbBackup = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.agendamentosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.arquivoToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            this.agendamentosToolStripMenuItem.Click += new System.EventHandler(this.agendamentosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.serviçosToolStripMenuItem1,
            this.agendamentosToolStripMenuItem1,
            this.usuariosToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultarToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // serviçosToolStripMenuItem1
            // 
            this.serviçosToolStripMenuItem1.Name = "serviçosToolStripMenuItem1";
            this.serviçosToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.serviçosToolStripMenuItem1.Text = "Serviços";
            this.serviçosToolStripMenuItem1.Click += new System.EventHandler(this.serviçosToolStripMenuItem1_Click);
            // 
            // agendamentosToolStripMenuItem1
            // 
            this.agendamentosToolStripMenuItem1.Name = "agendamentosToolStripMenuItem1";
            this.agendamentosToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.agendamentosToolStripMenuItem1.Text = "Agendamentos";
            this.agendamentosToolStripMenuItem1.Click += new System.EventHandler(this.agendamentosToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosClientesToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // dadosClientesToolStripMenuItem
            // 
            this.dadosClientesToolStripMenuItem.Name = "dadosClientesToolStripMenuItem";
            this.dadosClientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dadosClientesToolStripMenuItem.Text = "Novo Backup";
            this.dadosClientesToolStripMenuItem.Click += new System.EventHandler(this.dadosClientesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRelogio,
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1336, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(440, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuário: ";
            // 
            // lblRelogio
            // 
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(440, 17);
            this.lblRelogio.Spring = true;
            this.lblRelogio.Text = "Relógio: ";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(440, 17);
            this.lblData.Spring = true;
            this.lblData.Text = "Data: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCalendario,
            this.tsbNovoAgendamento,
            this.tsbNovoCliente,
            this.tsbBackup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1336, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCalendario
            // 
            this.tsbCalendario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCalendario.Image = global::PrjTCCoficial.Properties.Resources.Apps_Calendar_Metro_icon;
            this.tsbCalendario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalendario.Name = "tsbCalendario";
            this.tsbCalendario.Size = new System.Drawing.Size(23, 22);
            this.tsbCalendario.Text = "Mostrar Calendário";
            this.tsbCalendario.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbNovoAgendamento
            // 
            this.tsbNovoAgendamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovoAgendamento.Image = global::PrjTCCoficial.Properties.Resources.Files_New_File_icon;
            this.tsbNovoAgendamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovoAgendamento.Name = "tsbNovoAgendamento";
            this.tsbNovoAgendamento.Size = new System.Drawing.Size(23, 22);
            this.tsbNovoAgendamento.Text = "Novo Agendamento";
            this.tsbNovoAgendamento.Click += new System.EventHandler(this.tsbNovoAgendamento_Click);
            // 
            // tsbNovoCliente
            // 
            this.tsbNovoCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovoCliente.Image = global::PrjTCCoficial.Properties.Resources.Actions_contact_new_icon;
            this.tsbNovoCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovoCliente.Name = "tsbNovoCliente";
            this.tsbNovoCliente.Size = new System.Drawing.Size(23, 22);
            this.tsbNovoCliente.Text = "Novo Cliente";
            this.tsbNovoCliente.Click += new System.EventHandler(this.tsbNovoCliente_Click);
            // 
            // tsbBackup
            // 
            this.tsbBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBackup.Image = global::PrjTCCoficial.Properties.Resources.Data_Database_Backup_icon;
            this.tsbBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackup.Name = "tsbBackup";
            this.tsbBackup.Size = new System.Drawing.Size(23, 22);
            this.tsbBackup.Text = "Fazer Backup";
            this.tsbBackup.Click += new System.EventHandler(this.tsbBackup_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1336, 702);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInicio";
            this.Text = "Início";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosClientesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRelogio;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tsbCalendario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton tsbNovoAgendamento;
        private System.Windows.Forms.ToolStripButton tsbNovoCliente;
        private System.Windows.Forms.ToolStripButton tsbBackup;
    }
}

