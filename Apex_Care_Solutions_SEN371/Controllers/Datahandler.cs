using Microsoft.Data.SqlClient;

namespace Apex_Care_Solutions_SEN371.Controllers
{
    public class Datahandler
    {
        private readonly string connectionString = "Server=HENRYPC\\SQLEXPRESS01;Database=ApexCareDB;Trusted_Connection=True;";
        public bool ValidateLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}' AND Password = '{password}'";
                var command = new SqlCommand(query, connection);
                var result = command.ExecuteScalar();
                return (int)result > 0;
            }
        }

    }

}
