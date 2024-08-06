using System;
using System.IO;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Utils;
using SoftCaisse.Utils.Connection;

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
            try
            {
                var (connection, connectionString) = await Db.ConnectToServer(serverName, userName, password, timeoutInSeconds);
                var databases = await Cmbx.Populate(connection, connectionString);
                UpdateUI(() =>
                {
                    DbListCmbx.Items.Clear();
                    DbListCmbx.Items.AddRange(databases);
                    DbListCmbx.Enabled = true;
                });
                UpdateUI(() =>
                {
                    ListDatabase.Items.Clear();
                    ListDatabase.Items.AddRange(databases);
                    ListDatabase.Enabled = true;
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

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
            string SagedataBase = DbListCmbx.Text;
            string SOftCaissedataBase = ListDatabase.Text;
            string serveurFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServeurCfg.txt");
            string sageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServeurSage.txt");
            string sageFileObj = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ObjSage.txt");
            string connectionString = $"Data Source={serverName};Initial Catalog={SOftCaissedataBase};User ID={userName};Password={password};TrustServerCertificate=True;";
            string connectionStringSage = $"Data Source={serverName};Initial Catalog={SagedataBase};User ID={userName};Password={password};TrustServerCertificate=True;";
            string paramObj = commerciale.Text+"\n" + comptabilite.Text + "\n" + Utilisateur.Text  + "\n" + Mot_de_passe.Text + "\n";
            File.WriteAllText(serveurFilePath, "");
            File.WriteAllText(sageFilePath, "");
            File.WriteAllText(sageFileObj, "");
            File.WriteAllText(serveurFilePath, connectionString);
            File.WriteAllText(sageFilePath, connectionStringSage);
            File.WriteAllText(sageFileObj, paramObj);
            MessageBox.Show("Configuration sauvegardée.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnOpenSageGestion_Click(object sender, EventArgs e)
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
                    commerciale.Text = file.FullName;

                }
                catch (Exception ex)
                {
                    // Gestion des erreurs lors de la lecture du fichier
                    MessageBox.Show($"Une erreur est survenue lors de la lecture du fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnOpenSageCompta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Fichiers Sage (*.mae)|*.mae|Tous les fichiers (*.*)|*.*"; // Filtre pour afficher uniquement les fichiers texte
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    FileInfo file = new FileInfo(openFileDialog1.FileName);
                    sagedataBaseName = Path.GetFileNameWithoutExtension(filePath);
                    comptabilite.Text = file.FullName;

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
