using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TeamPulse.Console.Extensions;
using TeamPulse.Console.Menus;

// Create a new HostBuilder with default configuration, logging, and DI setup
var builder = Host.CreateApplicationBuilder();

// Register services with the built-in DI container
builder.Services.AddCustomServices();

// Build the host, which finalizes configuration and prepares the DI container
using var host = builder.Build();

// Retrieve the main menu service from the DI container
var mainMenu = host.Services.GetRequiredService<IMainMenu>();

// Start the application by displaying the main menu
mainMenu.Display();