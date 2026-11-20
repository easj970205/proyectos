using System.Globalization;

namespace ConversorDistancias;

public partial class FormularioConversor : Form
{
    public FormularioConversor()
    {
        InitializeComponent();
    }

    private void ConvertirMetrosAKilometros(object? objeto, EventArgs argumentos)
    {
        if (!IntentarLeerNumero(txtMetros.Text, out decimal metros))
        {
            MostrarErrorDeCaptura("Escribe una cantidad de metros válida. Puedes usar coma o punto para los decimales.", txtMetros);
            return;
        }

        if (metros < 0m)
        {
            MostrarErrorDeCaptura("La distancia no puede ser negativa.", txtMetros);
            return;
        }

        decimal kilometros = metros / 1000m;
        lblResultadoKilometros.Text = $"Resultado: {kilometros:0.######} km";
    }

    private void ConvertirKilometrosAMillas(object? objeto, EventArgs argumentos)
    {
        if (!IntentarLeerNumero(txtKilometros.Text, out decimal kilometros))
        {
            MostrarErrorDeCaptura("Escribe una cantidad de kilómetros válida. Puedes usar coma o punto para los decimales.", txtKilometros);
            return;
        }

        if (kilometros < 0m)
        {
            MostrarErrorDeCaptura("La distancia no puede ser negativa.", txtKilometros);
            return;
        }

        decimal millas = kilometros * 0.621371m;
        lblResultadoMillas.Text = $"Resultado: {millas:0.######} mi";
    }

    private static bool IntentarLeerNumero(string texto, out decimal numero)
    {
        const NumberStyles formato = NumberStyles.AllowLeadingWhite
            | NumberStyles.AllowTrailingWhite
            | NumberStyles.AllowLeadingSign
            | NumberStyles.AllowDecimalPoint;

        if (decimal.TryParse(texto, formato, CultureInfo.CurrentCulture, out numero))
        {
            return true;
        }

        string numeroConPunto = texto.Trim().Replace(',', '.');
        return decimal.TryParse(numeroConPunto, formato, CultureInfo.InvariantCulture, out numero);
    }

    private void MostrarErrorDeCaptura(string mensaje, TextBox cuadro)
    {
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        txtMetros.Clear();
        txtKilometros.Clear();
        lblResultadoKilometros.Text = "Resultado: -- km";
        lblResultadoMillas.Text = "Resultado: -- mi";
        txtMetros.Focus();
    }
}
