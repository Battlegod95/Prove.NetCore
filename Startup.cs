using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Prove_dotnet_core.Models.Services.Application;

namespace Prove_dotnet_core
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container. ciao
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<CourseService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment()) //lo usi per ambienti da sviluppo a produzione > se vai nel file launchSettings.json nell'ultima colonna ASPNETCORE_ENVIRONMENT lo cambi con il nome che vuoi anche "cesso" dove lo vuoi impiegare e da qui gestisci i tuoi middlewear
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();//ha la responsabilità di mandare in output errori da i vari middlewear
                //il secondo è il context
            }

            app.UseStaticFiles(); //utilizzo di un secondo middlewear da inserire in mezzo ai due per usare file statici di immagini presenti nella cartella wwwroot

            //app.Run(async (context) =>
            //{
                //Ogni volta che arriva una richiesta web, il web server produce un oggetto che permetterà all'applicazione di leggere le informazioni contenute nella richiesta e di produrre una risposta. 
                //L'oggetto di tipo HttpContext rappresenta il contesto di esecuzione corrente e permette di accedere ai dati della richiesta (proprietà Request) o di produrre una risposta (dalla proprietà Response).

                //string nome = context.Request.Query["nome"];
                //await context.Response.WriteAsync($"Hello {nome.ToUpper()}!"); 
                
                //manda una stringa di risposta a quello che abbiamo richiesto
                //i valori che noi abbiamo mandato con la richiesta come facciamo a leggerli?
                //es. www.miosito.it
                //context.Request.Query[id]; ricorda che non va lo / dopo localhost:5001 ma ? e poi nome=cosa vuoi scrivere
            //});

            //app.UseMvcWithDefaultRoute(); fa quello che vedi sotto
            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            }); //abbiamo configurato la strada per richiamare una pagina. è divisa in tre pezzetti dove {controller} sta /courses/ {action} sta per detail/ e {id} sta per l'id che vogliamo cercare
            //non basta devi configurare i services
            //con laggiunta Home vado ad impostare nel caso in cui il controller che voglio richiamare non esista o è sbagliato, vado a richiamare il controller di base cioè Home, stessa cosa con action cioè index. mentre id con il ? vuol dire che è un parametro opzionale che posso mettere come no
        }
    }
}
