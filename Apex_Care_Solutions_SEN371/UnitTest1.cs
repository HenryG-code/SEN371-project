using Xunit;
using Apex_Care_Solutions_SEN371.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.Extensions.Logging;

public class HomeControllerTests
{
    private readonly HomeController _controller;

    public HomeControllerTests()
    {
        var mockLogger = new Mock<ILogger<HomeController>>();
        _controller = new HomeController((IConfiguration)mockLogger.Object);
    }

    [Fact]
    public void Login_ValidCredentials_ShouldRedirectToClientManagement()
    {
        // Arrange
        string username = "validuser";
        string password = "validpassword";

        // Act
        var result = _controller.Login(username, password) as RedirectToActionResult;

        // Assert
        Assert.NotNull(result);
        Assert.Equal("ClientManagement", result.ActionName);
    }

    [Fact]
    public void Login_InvalidCredentials_ShouldReturnViewWithErrorMessage()
    {
        // Arrange
        string username = "invaliduser";
        string password = "wrongpassword";

        // Act
        var result = _controller.Login(username, password) as ViewResult;

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Invalid username or password.", _controller.ViewBag.ErrorMessage);
    }

}
