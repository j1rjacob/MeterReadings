using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TMF.Core;

namespace MeterReports
{
    public partial class DbaseUtil : Form
    {
        private SqlDataReader dr;
        private string _servername;
        private string _username;
        private string _password;
        private string _database;

        public DbaseUtil(int tabIndex)
        {
            GetConnConfig();
            InitializeComponent();
            TabControlDBaseUtil.SelectedIndex = tabIndex;
        }
        private void ButtonGetPath_Click(object sender, EventArgs e)
        {
            GetFilePath();
        }
        private void ButtonDBBackup_Click(object sender, EventArgs e)
        {
            CreateBackup();
        }

        private void GetConnConfig()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(new SmartDB().Connection.ConnectionString);
            _servername = builder.DataSource;
            _username = builder.UserID;
            _password = builder.Password;
            _database = builder.InitialCatalog;
        }

        private void ButtonDBRestore_Click(object sender, EventArgs e)
        {
            RestoreBackup();
        }

        private void GetFilePath()
        {
            if (OpenFileDialogDBRestore.ShowDialog() == DialogResult.OK)
            {
                TextBoxDBRestore.Text = OpenFileDialogDBRestore.FileName;
            }
        }

        private void RestoreBackup()
        {
            ProgressBarDBRestore.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(_servername, _username, _password));
                Restore dbRestore = new Restore() { Database = _database, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbRestore.Devices.AddDevice(TextBoxDBRestore.Text, DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                LabelDBRestoreStatus.Invoke((MethodInvoker)delegate
                {
                    LabelDBRestoreStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            ProgressBarDBRestore.Invoke((MethodInvoker)delegate
            {
                ProgressBarDBRestore.Value = e.Percent;
                ProgressBarDBRestore.Update();
            });
            LabelDBRestorePercent.Invoke((MethodInvoker)delegate
            {
                LabelDBRestorePercent.Text = $"{e.Percent}";
            });
        }

        private void ComboBoxDBBackup_Click(object sender, EventArgs e)
        {
            ComboBoxDBBackup.Items.Clear();
            Createconnection();
        }

        public void Createconnection()
        {
            using (SqlConnection connection =
                new SqlConnection(new SmartDB().Connection.ConnectionString))
            {
                connection.Open();

                string strSql = "select * from sys.databases";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ComboBoxDBBackup.Items.Add(dr[0]);
                }
                dr.Close();
                cmd.Dispose();
            }
        }

        private void CreateBackup()
        {
            ProgressBarDBUtil.Value = 0;
            try
            {
                if (string.IsNullOrWhiteSpace(ComboBoxDBBackup.Text))
                {
                    MessageBox.Show("Choose your database.");
                    return;
                }

                if (SaveFileDialogBackup.ShowDialog() == DialogResult.OK)
                {
                    //Server dbServer = new Server(new ServerConnection("AMTVICTORICURM\\SQLEXPRESS", "sa", "tmf101010"));
                    Server dbServer = new Server(new ServerConnection(_servername, _username, _password));
                    Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = ComboBoxDBBackup.Text };
                    dbBackup.Devices.AddDevice(SaveFileDialogBackup.FileName, DeviceType.File);
                    dbBackup.Initialize = true;
                    dbBackup.PercentComplete += DbBackup_PercentComplete;
                    dbBackup.Complete += DbBackup_Complete;
                    dbBackup.SqlBackupAsync(dbServer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            ProgressBarDBUtil.Invoke((MethodInvoker)delegate
            {
                ProgressBarDBUtil.Value = e.Percent;
                ProgressBarDBUtil.Update();
            });
            lblPercent.Invoke((MethodInvoker) delegate
            {
                lblPercent.Text = $"{e.Percent}%";
            });
        }
    }
}
