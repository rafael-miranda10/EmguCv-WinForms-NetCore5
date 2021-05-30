using EmguCvDemo.Applications.App;
using EmguCvDemo.Applications.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace EmguCvDemo
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var principalForm = serviceProvider.GetRequiredService<Principal>();
                Application.Run(principalForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            
            services.AddLogging(configure => configure.AddConsole())
                    .AddScoped<Principal>()
                    .AddScoped<IEmguCvBasicOperation, EmguCvBasicOperation>();
        }
    }
}
