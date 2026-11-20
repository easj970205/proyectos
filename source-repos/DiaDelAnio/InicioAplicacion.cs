namespace DiaDelAnio;

internal static class InicioAplicacion
{
    [STAThread]
    private static void Main()
    {
        // Iniciamos Windows Forms y abrimos la ventana del ejercicio.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormularioDiaDelAnio());
    }
}
