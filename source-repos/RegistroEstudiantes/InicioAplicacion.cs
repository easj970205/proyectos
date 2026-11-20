namespace RegistroEstudiantes;

internal static class InicioAplicacion
{
    [STAThread]
    private static void Main()
    {
        // Iniciamos el programa y abrimos el formulario.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormularioRegistro());
    }
}
