using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.DTO;
using SoftCaisse.Utils;
using SoftCaisse.Utils.Connection;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftCaisse.Forms.ConnexBase
{
    public partial class ConnectDbForm : KryptonForm
    {
        private string connectionStringSage="";
        private string serverName;
        private string userName;
        private string password;
        private string sagedataBaseName;
        private int timeoutInSeconds = 10;
        public ConnectDbForm()
        {
            InitializeComponent();
        }

        private async void btnConBD_Click(object sender, EventArgs e)
        {
            serverName = txtServBD.Text;
            userName = txtSqlUser.Text;
            password = txtPwdBD.Text;
            var (connection, connectionString) = await Db.ConnectToServer(serverName, userName, password, timeoutInSeconds);
            var databases = await Cmbx.Populate(connection, connectionString);
            UpdateUI(() =>
            {
                // Display the list or process as needed
                DbListCmbx.Items.Clear();
                DbListCmbx.Items.AddRange(databases);
                DbListCmbx.Enabled = true;
            });

        }

        private void UpdateUI(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }


        private void btnSaveConfigBd_Click(object sender, EventArgs e)
        {
            string dataBaseName = DbListCmbx.Text;
            string serveurFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServeurCfg.txt");
            string sageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServeurSage.txt");
            string connectionString = $"Data Source={serverName};Initial Catalog={dataBaseName};User ID={userName};Password={password};TrustServerCertificate=True;";
            string connectionStringSage = $"Data Source={serverName};Initial Catalog={sagedataBaseName};User ID={userName};Password={password};TrustServerCertificate=True;";
            File.WriteAllText(serveurFilePath, connectionString);
            File.WriteAllText(sageFilePath, connectionStringSage);
            MessageBox.Show("Configuration sauvegardée.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnOpenSageFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Fichiers Sage (*.gcm)|*.gcm|Tous les fichiers (*.*)|*.*"; // Filtre pour afficher uniquement les fichiers texte
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    FileInfo file = new FileInfo(openFileDialog1.FileName);
                    sagedataBaseName = Path.GetFileNameWithoutExtension(filePath);
                    txtBoxSagePath.Text = file.FullName;

                }
                catch (Exception ex)
                {
                    // Gestion des erreurs lors de la lecture du fichier
                    MessageBox.Show($"Une erreur est survenue lors de la lecture du fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
