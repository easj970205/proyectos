using System.Globalization;

namespace AreaCircunferencia;

public partial class FormularioArea : Form
{
    public FormularioArea()
    {
        // Carga los controles que forman la ventana.
        InitializeComponent();
    }

    private void CalcularArea(object? objeto, EventArgs argumentos)
    {
        // Convertimos el texto del radio a un número.
        if (!IntentarLeerNumero(cuadroRadio.Text, out double radio) || !double.IsFinite(radio) || radio <= 0)
        {
            MostrarError("Escribe un radio válido mayor que cero.", cuadroRadio);
            return;
        }

        // Fórmula del área: pi por radio al cuadrado.
        double area = Math.PI * radio * radio;
        etiquetaResultado.Text = $"El área de la circunferencia es {area:0.00} m².";
    }

    private static bool IntentarLeerNumero(string texto, out double numero)
    {
        // Permitimos números decimales con coma o con punto.
        string textoNormalizado = texto.Trim().Replace(',', '.');
        return double.TryParse(textoNormalizado, NumberStyles.Float,
            CultureInfo.InvariantCulture, out numero);
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Mostramos el error y seleccionamos el dato para corregirlo.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        // Dejamos la ventana lista para calcular otra área.
        cuadroRadio.Clear();
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        cuadroRadio.Focus();
    }
}

'Rev. Luis Alberto Luna Hernandez. 25/09/2026'
