namespace MultiplosHastaCien;

public partial class FormularioMultiplos : Form
{
    // Aquí guardamos los números que ya se habían consultado.
    private readonly List<int> numerosConsultados = new();

    public FormularioMultiplos()
    {
        // Cargamos los controles de la ventana.
        InitializeComponent();
    }

    private void MostrarMultiplos(object? objeto, EventArgs argumentos)
    {
        // Primero revisamos que sea un número entero de 1 a 100.
        if (!int.TryParse(cuadroNumero.Text.Trim(), out int numero))
        {
            MostrarError("Escribe un número entero.");
            return;
        }

        if (numero < 1 || numero > 100)
        {
            MostrarError("Escribe un número entre 1 y 100.");
            return;
        }

        // Antes de mostrar el número nuevo, avisamos cuáles fueron los anteriores.
        if (numerosConsultados.Count == 0)
        {
            etiquetaPrevios.Text = "Antes de este número no hay consultas anteriores.";
        }
        else
        {
            string anteriores = string.Join(", ", numerosConsultados);
            etiquetaPrevios.Text = $"Antes del {numero} ya se habían consultado: {anteriores}.";
        }

        List<int> multiplos = new();

        // Vamos sumando el mismo número hasta llegar a 100.
        for (int multiplo = numero; multiplo <= 100; multiplo += numero)
        {
            multiplos.Add(multiplo);
        }

        cuadroResultados.AppendText($"Múltiplos de {numero} hasta 100:\r\n");
        cuadroResultados.AppendText(string.Join(", ", multiplos));
        cuadroResultados.AppendText("\r\n\r\n");

        numerosConsultados.Add(numero);
        cuadroNumero.Clear();
        cuadroNumero.Focus();
    }

    private void MostrarError(string mensaje)
    {
        // Mostramos el aviso y seleccionamos el campo para corregirlo.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadroNumero.Focus();
        cuadroNumero.SelectAll();
    }

    private void LimpiarTodo(object? objeto, EventArgs argumentos)
    {
        // Borramos las consultas anteriores y el resultado de la ventana.
        numerosConsultados.Clear();
        cuadroNumero.Clear();
        etiquetaPrevios.Text = "Aquí aparecerán las consultas anteriores.";
        cuadroResultados.Clear();
        cuadroNumero.Focus();
    }
}
