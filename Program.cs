using PizzeriaBellaItalia.Dominio;
using PizzeriaBellaItalia.Presentacion;
namespace PizzeriaBellaItalia.App;

internal static class Program
{
    // punto de entrada de la app
    [STAThread]
    static void Main()
    {
        // see https://aka.ms/applicationconfiguration. //DPI settings or default font
        ApplicationConfiguration.Initialize();          // To customize application configuration
        Application.Run(new FormPedido());              //Ejecuta el form
    }
}