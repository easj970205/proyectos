namespace PesosADolares;

internal static class InicioAplicacion
{
    [STAThread]
    private static void Main()
    {
        // Configura Windows Forms y abre el formulario principal.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormularioConversion());
    }
}
