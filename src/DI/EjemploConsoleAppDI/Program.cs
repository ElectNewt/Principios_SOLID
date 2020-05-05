using InversionDependencias;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EjemploConsoleAppDI
{
    class Program
    {
        static void Main(string[] args)
        {


            var serviceProvider = new ServiceCollection()
                .AddScoped<IAlmacenamiento, AlmacenamientoSQL>()
                .AddScoped<ILogging, Logging>()
                .AddScoped<DBRepository>()
                .AddScoped<Cache>()
                .AddScoped<IArticuloServicio,ArticulosServicio>()
                .BuildServiceProvider();


            var articuloServicio = serviceProvider.GetService<IArticuloServicio>();
            articuloServicio.ConsultarArticulo("test");



            Console.WriteLine("Hello World!");
        }
    }
}
