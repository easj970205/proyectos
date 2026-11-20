namespace IntercambiarValores;

public partial class FormularioIntercambio : Form
{
    public FormularioIntercambio()
    {
        // Carga los controles que forman la ventana.
        InitializeComponent();
    }

    private void IntercambiarValores(object? objeto, EventArgs argumentos)
    {
        // Leemos los dos valores como números enteros.
        if (!int.TryParse(cuadroValorUno.Text.Trim(), out int valorUno))
        {
            MostrarError("Escribe un número entero válido para el valor 1.", cuadroValorUno);
            return;
        }

        if (!int.TryParse(cuadroValorDos.Text.Trim(), out int valorDos))
        {
            MostrarError("Escribe un número entero válido para el valor 2.", cuadroValorDos);
            return;
        }

        // Guardamos temporalmente el primer valor para no perderlo.
        int valorTemporal = valorUno;

        // Intercambiamos los valores usando la variable temporal.
        valorUno = valorDos;
        valorDos = valorTemporal;

        // Mostramos los valores ya intercambiados en los cuadros.
        cuadroValorUno.Text = valorUno.ToString();
        cuadroValorDos.Text = valorDos.ToString();
        etiquetaResultado.Text = "Los valores fueron intercambiados.";
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Avisamos del error y seleccionamos el dato para corregirlo.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        // Borramos los valores para realizar otro intercambio.
        cuadroValorUno.Clear();
        cuadroValorDos.Clear();
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        cuadroValorUno.Focus();
    }
}
'Rev: Luis Alberto Luna Hernandez 25/09/2026'