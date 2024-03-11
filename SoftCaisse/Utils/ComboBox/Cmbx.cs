using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SoftCaisse.Utils
{
    public static class Cmbx
    {
        public static async Task<string[]> Populate(SqlConnection connection, string connectionString)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT name FROM sys.databases", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        var databases = new System.Collections.Generic.List<string>();
                        while (await reader.ReadAsync())
                        {
                            string databaseName = reader["name"].ToString();
                            databases.Add(databaseName);
                        }
                        connection.Close();
                        return databases.ToArray();
                    }
                }
                
            }
            
        }
    }
}
