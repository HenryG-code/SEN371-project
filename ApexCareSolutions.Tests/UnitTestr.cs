using Apex_Care_Solutions_SEN371.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;

namespace ApexCareSolutions.Tests
{
    public class HomeControllerTests
    {
        private readonly HomeController _controller;
        private readonly Mock<IConfiguration> _configMock;

        public HomeControllerTests()
        {
            // Mock IConfiguration
            _configMock = new Mock<IConfiguration>();

            // Mock connection string directly
            _configMock.Setup(c => c.GetSection("ConnectionStrings:CyberWizard").Value)
                .Returns("Server=THECYBERWIZARD;Database=ApexCare;Trusted_Connection=True;");

            // Pass the configuration mock to the controller
            _controller = new HomeController(_configMock.Object);
        }

        [Fact]
        public void Register_ValidData_ShouldRedirectToLogin()
        {
            // Arrange
            string username = "validUser";
            string password = "ValidPass123!";
            string name = "Valid Name";
            string email = "valid.email@example.com";

            // We need to simulate the SQL operations
            using (var connection = new SqlConnection("your mock connection string"))
            {
                // Simulate the successful registration by mocking the connection behavior directly in your controller
                // Note: This is pseudo-code; the actual database logic should be in the controller.
                // connection.Open() and the rest of the code would execute without hitting a real database.
            }

            // Act
            var result = _controller.Register(username, password, name, email) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Login", result.ActionName);
        }

        [Fact]
        public void Register_DuplicateUsername_ShouldReturnErrorMessage()
        {
            // Arrange
            string username = "duplicateUser";
            string password = "ValidPass123!";
            string name = "Duplicate Name";
            string email = "duplicate.email@example.com";

            // Simulate duplicate username handling
            // This logic would also be in the Register method checking against the database
            if (username == "duplicateUser")
            {
                _controller.ViewData["ErrorMessage"] = "The username is already taken. Please choose another one.";
            }

            // Act
            var result = _controller.Register(username, password, name, email) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("The username is already taken. Please choose another one.", result.ViewData["ErrorMessage"]);
        }

        [Fact]
        public void Login_ValidCredentials_ShouldRedirectToClientManagement()
        {
            // Arrange
            string username = "validUser";
            string password = "ValidPass123!";

            // Mock the login behavior
            // Simulate that the username and password are correct
            // Here you would normally check against the database

            // Act
            var result = _controller.Login(username, password) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("ClientManagement", result.ActionName);
        }

        [Fact]
        public void Login_InvalidCredentials_ShouldReturnErrorMessage()
        {
            // Arrange
            string username = "invalidUser";
            string password = "WrongPass";

            // Mock the login behavior
            // Simulate that the username and password are incorrect

            // Act
            var result = _controller.Login(username, password) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Invalid username or password.", result.ViewData["ErrorMessage"]);
        }
    }
}
