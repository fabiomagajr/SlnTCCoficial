using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrjTCCoficial
{
    public partial class frmBackup : PrjTCCoficial.frmPadraoFilhos
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        string sql = "";
        string connectionString = "";

        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Infomar usuário, por favor.");
                return;
            }
            try
            {
                
                
                connectionString = "Data Source=" + txtDataSource.Text + "; User Id=" + txtUsuario.Text + "; Password=" + txtSenha.Text;
                conn = new SqlConnection(connectionString);
                conn.Open();
                //sql = "EXEC sp_databases";
                sql = "SELECT * FROM sys.databases d WHERE d.database_id>6";
                
                cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                cmbBancoDeDados.Items.Clear();
                while (rdr.Read())
                {
                    cmbBancoDeDados.Items.Add(rdr[0].ToString());
                }
                txtDataSource.Enabled = false;
                txtSenha.Enabled = false;
                txtUsuario.Enabled = false;
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                cmbBancoDeDados.Enabled = true;
                btnRestaurar.Enabled = true;
                btnBackup.Enabled = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //rdr.Close();
                //rdr.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            txtDataSource.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnRestaurar.Enabled = false;
            btnBackup.Enabled = false;
            cmbBancoDeDados.Enabled = false;
        }

        private void frmBackupRestore_Load(object sender, EventArgs e)
        {
            txtDataSource.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnRestaurar.Enabled = false;
            btnBackup.Enabled = false;
            cmbBancoDeDados.Enabled = false;
        }

        private void btnLocalizarBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSalvarEm.Text = dlg.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBancoDeDados.Text.CompareTo("")==0)
                {
                    MessageBox.Show("Selecione um banco de dados para realizar o Backup.");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "BACKUP DATABASE " + cmbBancoDeDados.Text + " TO DISK = '" + txtSalvarEm.Text + "\\" + cmbBancoDeDados.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Backup realizado com sucesso!", "Foi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void btnLocalizarRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                txtRestaurarDe.Text = dlg.FileName;
                btnRestaurar.Enabled = true;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBancoDeDados.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Selecione um banco de dados.");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "ALter DataBase " + cmbBancoDeDados.Text + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore DataBase " + cmbBancoDeDados.Text + " FROM Disk ='" + txtRestaurarDe.Text + "' WITH REPLACE";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("BD Recuperado com sucesso!", "Foi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
