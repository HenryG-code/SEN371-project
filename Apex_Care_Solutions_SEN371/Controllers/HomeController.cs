using Apex_Care_Solutions_SEN371.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using BCrypt.Net; // Ensure you have installed the BCrypt.Net-Next package
using System.Diagnostics;

namespace Apex_Care_Solutions_SEN371.Controllers
{
    public class HomeController : Controller
    {
        // Update to match your specific PC
        private readonly string _connectionString = "Server=TIAAN_PC\\SQLEXPRESS;Database=ApexCare;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ClientSatisfaction()
        {
            return View();
        }

        public IActionResult ClientManagement()
        {
            return View();
        }

        public IActionResult ServiceDesk()
        {
            return View();
        }

        public IActionResult Technicians()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Register(string username, string password, string name, string email)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Hash the password
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                // Insert into Clients table
                string insertQuery = "INSERT INTO Clients (Username, PasswordHash, Name, Email) VALUES (@Username, @Password, @Name, @Email)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", passwordHash);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return RedirectToAction("Login", "Home");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Registration failed. Please try again.";
                        return View();
                    }
                }
            }
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            string userType;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Check in Clients first
                if (TryAuthenticateUser(connection, "Clients", username, password, out userType))
                {
                    return RedirectToAction("ClientManagement", "Home");
                }

                // If not found, check in Technicians
                if (TryAuthenticateUser(connection, "Technicians", username, password, out userType))
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            // If both checks failed, show an error message
            ViewBag.ErrorMessage = "Invalid username or password.";
            return View();
        }

        private bool TryAuthenticateUser(SqlConnection connection, string table, string username, string password, out string userType)
        {
            string query = $"SELECT PasswordHash FROM {table} WHERE Username = @Username";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                var storedPasswordHash = command.ExecuteScalar() as string;

                // Ensure storedPasswordHash is valid
                if (!string.IsNullOrEmpty(storedPasswordHash) && storedPasswordHash.StartsWith("$2a$"))
                {
                    if (BCrypt.Net.BCrypt.Verify(password, storedPasswordHash))
                    {
                        userType = table == "Clients" ? "Client" : "Technician";
                        return true;
                    }
                }
            }

            userType = null;
            return false;
        }
    }
}