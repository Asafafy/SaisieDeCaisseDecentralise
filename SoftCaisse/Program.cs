using SoftCaisse.Forms.ConnexBase;
using System;
using System.IO;
using System.Windows.Forms;

namespace SoftCaisse
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, "ServeurCfg.txt");
            string filePathSage = Path.Combine(baseDirectory, "ServeurSage.txt");

            // Read connection string from file
            if (!File.Exists(filePath) && !File.Exists(filePathSage))
            {
                MessageBox.Show("La base de donnée n'est pas encore configurée");
                Application.Run(new ConnectDbForm());
            }
            if(File.Exists(filePath) && File.Exists(filePathSage))
            {
                Application.Run(new MainForm());
            }
           
        }
    }
}
