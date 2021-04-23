using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using balin.Repository._01.Interfaces;
using balin.Repository._02.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Runner.App.StaticResource;
using Runner.App.Views;
namespace Runner.App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        private static IConfigurationRoot config;
        public static string path { get; set; } = path.Output();
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StaticResource.StaticResource.ReWritejsonFile(path);
            Initialize();
            Application.Run(openPrincipal());
        }

        private static void Initialize()
        {
            var builder = new ConfigurationBuilder().SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            config = builder.Build();
        }
        private static Main openPrincipal()
        {
            return new Main(CreateDataRepository(), CreateBackupRepository());
        }
        private static IDatabaseRepositoryPattern CreateDataRepository()
        {
            return new DatabaseRepositoryPattern(config.GetConnectionString("DefaultConnection"));
        }
        private static IBackupRepositoryPattern CreateBackupRepository()
        {
            return new BackupRepositoryPattern(config.GetConnectionString("DefaultConnection"));
        }
    }
}
