namespace ParImpar;

public partial class FormularioParImpar : Form
{
    public FormularioParImpar()
    {
        // Carga los controles que forman la ventana.
        InitializeComponent();
    }

    private void VerificarNumero(object? objeto, EventArgs argumentos)
    {
        // Intentamos leer un número entero desde el cuadro de texto.
        if (!int.TryParse(cuadroNumero.Text.Trim(), out int numero))
        {
            MostrarError("Escribe un número entero válido.", cuadroNumero);
            return;
        }

        // El residuo de dividir entre 2 indica si es par o impar.
        if (numero % 2 == 0)
        {
            etiquetaResultado.Text = $"El número {numero} es par.";
        }
        else
        {
            etiquetaResultado.Text = $"El número {numero} es impar.";
        }
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Avisamos del error y seleccionamos el texto para corregirlo.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        // Borramos el número y el resultado anterior.
        cuadroNumero.Clear();
        etiquetaResultado.Text = "Aquí aparecerá el resultado.";
        cuadroNumero.Focus();
    }
}
'Rev. Luis Alberto Luna Hdez 25/06/2026'