using System.Globalization;

namespace VolumenCilindro;

public partial class FormularioVolumen : Form
{
    public FormularioVolumen()
    {
        // Prepara los controles que se ven en la ventana.
        InitializeComponent();
    }

    private void CalcularVolumen(object? objeto, EventArgs argumentos)
    {
        // Primero leemos el radio y comprobamos que sea un número positivo.
        if (!IntentarLeerNumero(cuadroRadio.Text, out double radio) || !double.IsFinite(radio) || radio <= 0)
        {
            MostrarError("Escribe un radio numérico mayor que cero.", cuadroRadio);
            return;
        }

        // Después hacemos la misma validación con la altura del cilindro.
        if (!IntentarLeerNumero(cuadroAltura.Text, out double altura) || !double.IsFinite(altura) || altura <= 0)
        {
            MostrarError("Escribe una altura numérica mayor que cero.", cuadroAltura);
            return;
        }

        // Fórmula del cilindro: volumen = pi por radio al cuadrado por altura.
        double volumen = Math.PI * radio * radio * altura;

        MessageBox.Show(this,
            $"El volumen del cilindro es {volumen:0.00} m³.\n\nFórmula: π × radio² × altura",
            "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private static bool IntentarLeerNumero(string texto, out double numero)
    {
        // Permitimos escribir los decimales con coma o con punto.
        string textoNormalizado = texto.Trim().Replace(',', '.');
        return double.TryParse(textoNormalizado, NumberStyles.Float, CultureInfo.InvariantCulture, out numero);
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Avisamos del problema y regresamos el cursor al campo que debe corregirse.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }
}
