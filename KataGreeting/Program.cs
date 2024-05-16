using KataGreeting;
using Microsoft.Extensions.DependencyInjection;

var host = IOC.CreateHostBuilder();
var handler = host.Services.GetRequiredService<GreetHandler>();

Console.WriteLine(handler.Greet(null));