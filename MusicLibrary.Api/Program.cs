using API;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.DataAccess.Interfaces;
using MusicLibrary.DataAccess.Models;
using MusicLibrary.DataAccess.Repository;

internal class Program
{
    private static void Main(string[] args)
    {

        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });

}