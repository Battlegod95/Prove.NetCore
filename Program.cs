using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Prove_dotnet_core
{
    public class Program
    {
        public static void Main(string[] args) //come le applicazioni a riga di comando (console) anche asp.net core è un tipo speciale di console ed ha come ingresso appunto il primo arcomanto main
        {
            CreateWebHostBuilder(args).Build().Run();
            //quindi appunto va a costruire per prima cosa crea un web host builder ciè un oggetto
            //va ad inserirsi dentro il web host quando facciamo una richiesta http. questo oggetto crea un altro oggetto chiamato http context che lo spedice all'apllicazione che ne formula le richieste che gli facciamo in risposta
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
