using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                try
                {
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ETicaretAPI.API"));
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Directory not found: " + ex.Message);
                }



                return configurationManager.GetConnectionString("SqlConnection");
            }


        }

    }
}
