using System.Globalization;

namespace PesosADolares;

public partial class FormularioConversion : Form
{
    // Este es un precio de ejemplo.
    private const decimal PrecioDolarEnPesos = 18.00m;

    public FormularioConversion()
    {
        // Carga los controles que forman la ventana.
        InitializeComponent();

        // Mostramos el precio que se usará en la conversión.
        etiquetaPrecio.Text = $"Precio de conversión: 1 USD = {PrecioDolarEnPesos:0.00} MXN";
    }

    private void ConvertirPesosADolares(object? objeto, EventArgs argumentos)
    {
        // Leemos la cantidad de pesos que escribió el usuario.
        if (!IntentarLeerNumero(cuadroPesos.Text, out decimal pesos) || pesos < 0m)
        {
            MostrarError("Escribe una cantidad de pesos válida, mayor o igual que cero.", cuadroPesos);
            return;
        }

        // Para convertir pesos a dólares dividimos entre el precio de un dólar.
        decimal dolares = pesos / PrecioDolarEnPesos;
        cuadroDolares.Text = $"{dolares:0.00}";
    }

    private static bool IntentarLeerNumero(string texto, out decimal numero)
    {
        // Permitimos que los decimales se escriban con coma o con punto.
        string textoNormalizado = texto.Trim().Replace(',', '.');
        return decimal.TryParse(
            textoNormalizado,
            NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
            CultureInfo.InvariantCulture,
            out numero);
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Indicamos el error y regresamos el cursor al campo que debe corregirse.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        // Borramos la entrada y el resultado para hacer otra conversión.
        cuadroPesos.Clear();
        cuadroDolares.Clear();
        cuadroPesos.Focus();
    }
}
