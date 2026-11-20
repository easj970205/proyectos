namespace CalculadoraPromedio;

internal static class InicioAplicacion
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormularioPromedio());
    }
}
