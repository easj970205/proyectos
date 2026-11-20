using System.Globalization;

namespace DiaDelAnio;

public partial class FormularioDiaDelAnio : Form
{
    public FormularioDiaDelAnio()
    {
        // Aquí se cargan las cajas, los botones y el resultado.
        InitializeComponent();
    }

    private void CalcularFecha(object? objeto, EventArgs argumentos)
    {
        // Primero revisamos que el día y el mes sean números enteros.
        if (!int.TryParse(cuadroDia.Text.Trim(), out int dia))
        {
            MostrarError("Escribe un número entero para el día.", cuadroDia);
            return;
        }

        if (!int.TryParse(cuadroMes.Text.Trim(), out int mes))
        {
            MostrarError("Escribe un número entero para el mes.", cuadroMes);
            return;
        }

        // El mes debe estar entre enero y diciembre.
        if (mes < 1 || mes > 12)
        {
            MostrarError("El mes debe estar entre 1 y 12.", cuadroMes);
            return;
        }

        // Tomamos el año actual para saber el día de la semana.
        int anioActual = DateTime.Today.Year;

        // Revisamos el máximo de días que tiene el mes escrito.
        // Así también se revisa correctamente febrero en año bisiesto.
        int maximoDeDias = DateTime.DaysInMonth(anioActual, mes);
        if (dia < 1 || dia > maximoDeDias)
        {
            MostrarError($"Ese mes tiene de 1 a {maximoDeDias} días.", cuadroDia);
            return;
        }

        // Con la fecha completa podemos obtener el nombre del día y del mes.
        DateTime fecha = new DateTime(anioActual, mes, dia);
        CultureInfo cultura = CultureInfo.GetCultureInfo("es-MX");
        string fechaEscrita = fecha.ToString("dddd, d 'de' MMMM", cultura);

        etiquetaResultado.Text = $"La fecha es {fechaEscrita}.";
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Mostramos el error y dejamos listo el campo para corregirlo.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        // Borramos los datos y el resultado anterior.
        cuadroDia.Clear();
        cuadroMes.Clear();
        etiquetaResultado.Text = "Aquí aparecerá la fecha.";
        cuadroDia.Focus();
    }
}
