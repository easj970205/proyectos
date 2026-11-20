namespace SumaDelUnoAlN;

public partial class FormularioSuma : Form
{
    // Esta variable guarda el total mientras se van agregando números.
    private long sumaAcumulada;

    public FormularioSuma()
    {
        // Aquí se cargan los controles de la ventana.
        InitializeComponent();
    }

    private void SumarCantidad(object? objeto, EventArgs argumentos)
    {
        // Leemos la cantidad que se escribió en el campo.
        if (!long.TryParse(cuadroNumero.Text.Trim(), out long numero))
        {
            MostrarError("Escribe un número entero.");
            return;
        }

        try
        {
            // Cada vez que se pulsa Sumar, la cantidad se agrega al total.
            sumaAcumulada = checked(sumaAcumulada + numero);
        }
        catch (OverflowException)
        {
            MostrarError("La suma es demasiado grande.");
            return;
        }

        listaNumeros.Items.Add(numero);
        etiquetaTotal.Text = $"Total acumulado: {sumaAcumulada}";
        cuadroNumero.Clear();
        cuadroNumero.Focus();
    }

    private void MostrarError(string mensaje)
    {
        // Mostramos el aviso y dejamos seleccionado el campo para corregirlo.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadroNumero.Focus();
        cuadroNumero.SelectAll();
    }

    private void LimpiarTodo(object? objeto, EventArgs argumentos)
    {
        // Reiniciamos el total y quitamos las cantidades de la lista.
        sumaAcumulada = 0;
        cuadroNumero.Clear();
        listaNumeros.Items.Clear();
        etiquetaTotal.Text = "Total acumulado: 0";
        cuadroNumero.Focus();
    }
}
'Revisado: Luis Alberto Luna Hernandez'