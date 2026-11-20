using System.Globalization;

namespace DescuentoCompra;

public partial class FormularioDescuento : Form
{
    private const decimal PrecioBase = 100m;

    public FormularioDescuento()
    {
        // Aquí se cargan los controles de la ventana.
        InitializeComponent();
    }

    private void CalcularCompra(object? objeto, EventArgs argumentos)
    {
        // Leemos cuántas unidades quiere comprar la persona.
        if (!int.TryParse(cuadroUnidades.Text.Trim(), out int unidades) || unidades < 1)
        {
            MostrarError("Escribe un número entero de unidades mayor que cero.");
            return;
        }

        decimal porcentajeDescuento;
        string rango;

        // Con estos rangos elegimos el descuento que corresponde.
        if (unidades <= 2)
        {
            porcentajeDescuento = 0m;
            rango = "1 a 2 unidades";
        }
        else if (unidades <= 5)
        {
            porcentajeDescuento = 0.10m;
            rango = "3 a 5 unidades";
        }
        else if (unidades <= 10)
        {
            porcentajeDescuento = 0.15m;
            rango = "6 a 10 unidades";
        }
        else
        {
            porcentajeDescuento = 0.20m;
            rango = "11 o más unidades";
        }

        // Calculamos el precio de una unidad y el total de toda la compra.
        decimal precioPorUnidad = PrecioBase * (1m - porcentajeDescuento);
        decimal total = precioPorUnidad * unidades;
        CultureInfo cultura = CultureInfo.GetCultureInfo("es-MX");

        etiquetaRango.Text = $"Rango aplicado: {rango}";
        etiquetaDescuento.Text = $"Descuento: {porcentajeDescuento.ToString("P0", cultura)}";
        etiquetaPrecio.Text = $"Precio por unidad: {precioPorUnidad.ToString("C2", cultura)} MXN";
        etiquetaTotal.Text = $"Total de la compra: {total.ToString("C2", cultura)} MXN";
    }

    private void MostrarError(string mensaje)
    {
        // Mostramos el aviso y dejamos seleccionado el dato para cambiarlo.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadroUnidades.Focus();
        cuadroUnidades.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        // Borramos la cantidad y los resultados anteriores.
        cuadroUnidades.Clear();
        etiquetaRango.Text = "Rango aplicado: -";
        etiquetaDescuento.Text = "Descuento: -";
        etiquetaPrecio.Text = "Precio por unidad: -";
        etiquetaTotal.Text = "Aquí aparecerá el total.";
        cuadroUnidades.Focus();
    }
}
'Revisado Luis Alberto Luna Hernandez'