namespace VolumenCilindro;

internal static class InicioAplicacion
{
    [STAThread]
    private static void Main()
    {
        // Configura los valores básicos de la aplicación de Windows Forms.
        ApplicationConfiguration.Initialize();

        // Abre el formulario principal del programa.
        Application.Run(new FormularioVolumen());
    }
}
