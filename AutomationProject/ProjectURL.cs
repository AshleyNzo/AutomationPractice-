using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutomationProject
{
    public class ProjectURL
    {
        
        public string URL { get; set; }
        IConfigurationRoot configuration { get; }

        public ProjectURL()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            configuration = builder.Build();

            URL = configuration["ProjectURL:URL"];

        }




    }
}
