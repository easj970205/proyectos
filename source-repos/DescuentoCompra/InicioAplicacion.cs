namespace DescuentoCompra;

internal static class InicioAplicacion
{
    [STAThread]
    private static void Main()
    {
        // Iniciamos Windows Forms y abrimos el formulario.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormularioDescuento());
    }
}
