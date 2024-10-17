using Apex_Care_Solutions_SEN371.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Http; // For session handling

namespace Apex_Care_Solutions_SEN371.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _connectionString;

        public HomeController(IConfiguration configuration)
        {
            // Use GetSection("ConnectionStrings:<name>").Value instead of GetConnectionString("<name>")
            string connectionString1 = configuration.GetSection("ConnectionStrings:CyberWizard").Value;
            string connectionString2 = configuration.GetSection("ConnectionStrings:HenryPC").Value;

            // Use Environment.MachineName or another condition to pick the right connection string
            if (Environment.MachineName == "THECYBERWIZARD")
            {
                _connectionString = connectionString1;
            }
            else if (Environment.MachineName == "HENRYPC")
            {
                _connectionString = connectionString2;
            }
            else
            {
                _connectionString = connectionString1;  // Default connection string
            }

            Debug.WriteLine($"Using Connection String: {_connectionString}");
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

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
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
                try
                {
                    connection.Open();

                    // Hash the password
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
                    Debug.WriteLine($"Hashed Password: {passwordHash}");

                    // Insert into Clients table
                    string insertQuery = "INSERT INTO Clients (Username, PasswordHash, Name, Email) VALUES (@Username, @Password, @Name, @Email)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", passwordHash);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = command.ExecuteNonQuery();
                        Debug.WriteLine($"Rows affected during registration: {rowsAffected}");

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
                catch (SqlException ex)
                {
                    // Check for unique constraint violation (error code 2627 is for unique constraint violations)
                    if (ex.Number == 2627) // Error code for unique constraint violation
                    {
                        ViewBag.ErrorMessage = "The username is already taken. Please choose another one.";
                        Debug.WriteLine($"Error: {ex.Message}");
                        return View();
                    }
                    else
                    {
                        // Log or handle other types of SQL exceptions
                        ViewBag.ErrorMessage = "An error occurred during registration. Please try again.";
                        Debug.WriteLine($"SQL Error: {ex.Message}");
                        return View();
                    }
                }
                catch (Exception ex)
                {
                    // Handle other general exceptions
                    ViewBag.ErrorMessage = "An unexpected error occurred. Please try again.";
                    Debug.WriteLine($"General Error: {ex.Message}");
                    return View();
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
                Debug.WriteLine($"Attempting login for Username: {username}");

                // Check in Clients first
                if (TryAuthenticateUser(connection, "Clients", username, password, out userType))
                {
                    Debug.WriteLine("Login successful for Client.");
                    return RedirectToAction("ClientManagement", "Home");
                }

                // If not found, check in Technicians
                else if (TryAuthenticateUser(connection, "Technicians", username, password, out userType))
                {
                    Debug.WriteLine("Login successful for Technician.");
                    return RedirectToAction("Technicians", "Home");
                }
            }

            // If both checks failed, show an error message
            Debug.WriteLine("Login failed: Invalid username or password.");
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

                // Debugging to verify stored hash
                Debug.WriteLine($"Stored Hash for {username}: {storedPasswordHash}");

                // Check if the storedPasswordHash is valid before attempting BCrypt verification
                if (!string.IsNullOrEmpty(storedPasswordHash) && storedPasswordHash.StartsWith("$2"))
                {
                    // Verify the password against the hash
                    bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedPasswordHash);
                    Debug.WriteLine($"Password valid: {isPasswordValid}");

                    if (isPasswordValid)
                    {
                        userType = table == "Clients" ? "Client" : "Technician";
                        return true;
                    }
                    else
                    {
                        Debug.WriteLine("Password verification failed.");
                    }
                }
                else
                {
                    Debug.WriteLine("No valid hash found for this user.");
                }
            }

            userType = null;
            return false;
        }
      

        // Temporary action for generating hashed passwords
        public IActionResult GenerateHashedPassword()
                {
                    string plainPassword = "password123";  // Replace with the password you want to hash
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword);
                    Debug.WriteLine($"Generated Hashed Password: {hashedPassword}");
                    return Content($"Hashed Password: {hashedPassword}");

                /*https://localhost:<PortYourServerisRunningOn>/Home/GenerateHashedPassword This link will help you generate hashpassword with the plain password being password123 by default*
                 */
                }
    }
}

