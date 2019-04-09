using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutomationProject
{
    public class Startup
    {
        IConfigurationRoot configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            configuration = builder.Build();
            var URL = configuration["ProjectURL:URL"];

        }

        public void ConfigureServices(IServiceCollection services) {

            services.AddMvc();

            services.AddOptions();

            services.Configure<ProjectURL>(configuration.GetSection("ProjectURL"));
            
        }

    }
}
