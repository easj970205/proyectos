using System.Globalization;

namespace DistanciaAutomovil;

public partial class FormularioDistancia : Form
{
    public FormularioDistancia()
    {
        // Aquí se cargan las cajas, los botones y el resultado.
        InitializeComponent();
    }

    private void CalcularDistancia(object? objeto, EventArgs argumentos)
    {
        // Tomamos el tiempo y la aceleración que escribió el usuario.
        if (!IntentarLeerNumero(cuadroTiempo.Text, out double tiempo) ||
            !double.IsFinite(tiempo))
        {
            MostrarError("Escribe bien el tiempo en segundos.", cuadroTiempo);
            return;
        }

        if (!IntentarLeerNumero(cuadroAceleracion.Text, out double aceleracion) ||
            !double.IsFinite(aceleracion))
        {
            MostrarError("Escribe bien la aceleración en m/s².", cuadroAceleracion);
            return;
        }

        if (tiempo < 0 || aceleracion < 0)
        {
            MessageBox.Show(this,
                "El tiempo y la aceleración no pueden ser negativos.",
                "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // En este ejercicio el auto empieza desde cero y acelera de forma constante.
        // La fórmula que usamos es: distancia = (aceleración × tiempo²) / 2.
        double distancia = (aceleracion * tiempo * tiempo) / 2;
        etiquetaResultado.Text = $"Distancia recorrida: {distancia:0.00} metros.";
    }

    private static bool IntentarLeerNumero(string texto, out double numero)
    {
        // Se puede escribir el decimal con coma o con punto.
        string textoNormalizado = texto.Trim().Replace(',', '.');
        return double.TryParse(textoNormalizado, NumberStyles.Float,
            CultureInfo.InvariantCulture, out numero);
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Si algo está mal, mostramos un aviso y regresamos a ese cuadro.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        // Limpiamos todo para hacer otro cálculo.
        cuadroTiempo.Clear();
        cuadroAceleracion.Clear();
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        cuadroTiempo.Focus();
    }
}
