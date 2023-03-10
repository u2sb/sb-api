using Microsoft.AspNetCore;

namespace SbApi;

public class Program
{
  public static void Main(string[] args)
  {
    BuildWebHost(args).Run();
  }

  private static IWebHost BuildWebHost(string[] args)
  {
    return WebHost.CreateDefaultBuilder(args)
      .UseStartup<Startup>()
      .Build();
  }
}