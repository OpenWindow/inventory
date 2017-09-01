using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace InventoryAngular
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BuildHost(args).Run();

      //var host = new WebHostBuilder()
      //    .UseKestrel()
      //    .UseContentRoot(Directory.GetCurrentDirectory())
      //    .UseIISIntegration()
      //    .UseStartup<Startup>()
      //    .UseApplicationInsights()
      //    .Build();

      //host.Run();
    }

    public static IWebHost BuildHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
           .UseStartup<Startup>()
           .Build();
  }
}
