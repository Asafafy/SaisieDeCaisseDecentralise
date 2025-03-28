﻿using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Utils.Connection
{
    public static class Db
    {
        public static async Task<(SqlConnection connection, string connectionString)> ConnectToServer(string serverName, string userName, string password, int timeoutInSeconds)
        {
            string connectionString = $"Data Source={serverName};User ID={userName};Password={password};TrustServerCertificate=True;";
            if (userName == "" && password == "")
            {
                connectionString = $"Data Source={serverName};Integrated Security=True;TrustServerCertificate=False;";
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(timeoutInSeconds)))
                    {
                        await connection.OpenAsync(cts.Token);
                        // Close the connection when done
                        
                        connection.Close();
                        MessageBox.Show("Connecté avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                        return (connection, connectionString);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                throw new TimeoutException($"Connection attempt timed out after {timeoutInSeconds} seconds.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
        public static string GetConnectionString(string fichierTxt)
        {
            string connectionString = "";
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construct the full path to the text file in the bin folder
            string filePath = Path.Combine(baseDirectory, fichierTxt);

            // Read connection string from file
            if (!File.Exists(filePath))
            {
                MessageBox.Show("La base de donnée n'est pas encore configurée");
            }
            else
            {
                connectionString = File.ReadAllText(filePath);
            }
            return connectionString;
        }
    }
}
