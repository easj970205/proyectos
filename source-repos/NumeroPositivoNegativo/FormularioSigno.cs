using System.Globalization;

namespace NumeroPositivoNegativo;

public partial class FormularioSigno : Form
{
    public FormularioSigno()
    {
        // Carga los controles de la ventana.
        InitializeComponent();
    }

    private void RevisarNumero(object? objeto, EventArgs argumentos)
    {
        // Intentamos convertir el texto escrito en un número.
        if (!IntentarLeerNumero(cuadroNumero.Text, out decimal numero))
        {
            MostrarError("Escribe un número válido.", cuadroNumero);
            return;
        }

        // Mayor que cero es positivo; cualquier otro valor es negativo.
        if (numero > 0m)
        {
            etiquetaResultado.Text = $"El número {numero} es positivo.";
        }
        else
        {
            etiquetaResultado.Text = $"El número {numero} es negativo.";
        }
    }

    private static bool IntentarLeerNumero(string texto, out decimal numero)
    {
        // Aceptamos decimales con coma o con punto.
        string textoNormalizado = texto.Trim().Replace(',', '.');
        return decimal.TryParse(
            textoNormalizado,
            NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
            CultureInfo.InvariantCulture,
            out numero);
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Mostramos el error y dejamos seleccionado el texto para corregirlo.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        // Borramos los datos para hacer otra comprobación.
        cuadroNumero.Clear();
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        cuadroNumero.Focus();
    }
}
