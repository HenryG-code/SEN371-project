using Apex_Care_Solutions_SEN371.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
//using BCrypt.Net;

namespace Apex_Care_Solutions_SEN371.Controllers
{
    public class HomeController : Controller
    {
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

        private readonly string _connectionString = "Server=THECYBERWIZARD\\SQLEXPRESS;Database=ApexCare;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

[HttpPost]
public IActionResult Register(string username, string password, string role, string name, string email, string specialization, string phone)
{
    using (SqlConnection connection = new SqlConnection(_connectionString))
    {
        connection.Open();

        // Depending on role, insert into Clients or Technicians table
        string insertQuery = "";

        if (role == "Client")
        {
            insertQuery = "INSERT INTO Clients (Username, PasswordHash, Name, Email) VALUES (@Username, @Password, @Name, @Email)";
        }
        else if (role == "Technician")
        {
            insertQuery = "INSERT INTO Technicians (Username, PasswordHash, Name, Email, Specialization, Phone) VALUES (@Username, @Password, @Name, @Email, @Specialization, @Phone)";
        }
        else
        {
            ViewBag.ErrorMessage = "Invalid role selected.";
            return View();
        }

        using (SqlCommand command = new SqlCommand(insertQuery, connection))
        {
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Email", email);

            // If technician, also add specialization and phone
            if (role == "Technician")
            {
                command.Parameters.AddWithValue("@Specialization", specialization);
                command.Parameters.AddWithValue("@Phone", phone);
            }

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
    // Queries to check the user in both Clients and Technicians tables
    string clientQuery = "SELECT COUNT(*) FROM Clients WHERE Username = @Username AND PasswordHash = @Password";
    string technicianQuery = "SELECT COUNT(*) FROM Technicians WHERE Username = @Username AND PasswordHash = @Password";

    using (SqlConnection connection = new SqlConnection(_connectionString))
    {
        connection.Open();

        // First, check in the Clients table
        SqlCommand clientCommand = new SqlCommand(clientQuery, connection);
        clientCommand.Parameters.AddWithValue("@Username", username);
        clientCommand.Parameters.AddWithValue("@Password", password);

        int clientUserCount = (int)clientCommand.ExecuteScalar();

        // If not found in Clients, check in Technicians table
        if (clientUserCount == 0)
        {
            SqlCommand technicianCommand = new SqlCommand(technicianQuery, connection);
            technicianCommand.Parameters.AddWithValue("@Username", username);
            technicianCommand.Parameters.AddWithValue("@Password", password);

            int technicianUserCount = (int)technicianCommand.ExecuteScalar();

            if (technicianUserCount == 1)
            {
                // Technician login success, redirect to home or dashboard
                return RedirectToAction("Index", "Home");
            }
        }
        else
        {
            // Client login success, redirect to home or dashboard
            return RedirectToAction("ClientManagement", "Home");
        }

        // If both checks failed, show an error message
        ViewBag.ErrorMessage = "Invalid email or password";
        return View();
    }
}
    }
}

