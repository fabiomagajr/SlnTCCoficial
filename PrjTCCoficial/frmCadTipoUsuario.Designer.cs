namespace PrjTCCoficial
{
    partial class frmCadTipoUsuario
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
            this.gpbTipoUsuario = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gpbTipoUsuario
            // 
            this.gpbTipoUsuario.Location = new System.Drawing.Point(12, 12);
            this.gpbTipoUsuario.Name = "gpbTipoUsuario";
            this.gpbTipoUsuario.Size = new System.Drawing.Size(408, 185);
            this.gpbTipoUsuario.TabIndex = 0;
            this.gpbTipoUsuario.TabStop = false;
            this.gpbTipoUsuario.Text = "Tipo de usuário";
            // 
            // frmCadTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(432, 252);
            this.Controls.Add(this.gpbTipoUsuario);
            this.Name = "frmCadTipoUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTipoUsuario;
    }
}
