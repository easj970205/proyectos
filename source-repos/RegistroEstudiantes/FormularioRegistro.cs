using System.Globalization;

namespace RegistroEstudiantes;

public partial class FormularioRegistro : Form
{
    private readonly List<Alumno> alumnos = new();

    public FormularioRegistro()
    {
        // Carga los controles de la ventana.
        InitializeComponent();
    }

    private void AgregarAlumno(object? objeto, EventArgs argumentos)
    {
        string nombreAlumno = cuadroNombre.Text.Trim();

        if (nombreAlumno == "")
        {
            MostrarError("Escribe el nombre del alumno.", cuadroNombre);
            return;
        }

        TextBox[] cuadrosNotas =
        {
            cuadroNota1,
            cuadroNota2,
            cuadroNota3,
            cuadroNota4
        };

        List<decimal> notas = new();

        // Revisamos las notas que sí fueron escritas.
        for (int indice = 0; indice < cuadrosNotas.Length; indice++)
        {
            string textoNota = cuadrosNotas[indice].Text.Trim();

            if (textoNota == "")
            {
                continue;
            }

            if (!IntentarLeerNota(textoNota, out decimal nota) ||
                nota < 0m || nota > 100m)
            {
                MostrarError(
                    $"La nota {indice + 1} debe estar entre 0 y 100.",
                    cuadrosNotas[indice]);
                return;
            }

            notas.Add(nota);
        }

        if (notas.Count == 0)
        {
            MessageBox.Show(this, "Escribe por lo menos una nota.",
                "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cuadroNota1.Focus();
            return;
        }

        // Creamos el alumno y guardamos sus notas en la lista.
        Alumno alumno = new() { Nombre = nombreAlumno };
        alumno.Notas.AddRange(notas);
        alumnos.Add(alumno);

        // Mostramos el nuevo registro para poder agregar más alumnos.
        string notasTexto = string.Join(", ",
            alumno.Notas.Select(nota => nota.ToString("0.##")));
        listaAlumnos.Items.Add($"{alumno.Nombre} | Notas: {notasTexto}");
        etiquetaCantidad.Text = $"Alumnos registrados: {alumnos.Count}";

        LimpiarCampos();
        cuadroNombre.Focus();
    }

    private static bool IntentarLeerNota(string texto, out decimal nota)
    {
        // Aceptamos notas con coma o con punto decimal.
        string textoNormalizado = texto.Replace(',', '.');
        return decimal.TryParse(textoNormalizado, NumberStyles.Float,
            CultureInfo.InvariantCulture, out nota);
    }

    private void MostrarError(string mensaje, TextBox cuadro)
    {
        // Mostramos un aviso y regresamos al campo que necesita corrección.
        MessageBox.Show(this, mensaje, "Dato no válido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cuadro.Focus();
        cuadro.SelectAll();
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        LimpiarCampos();
        cuadroNombre.Focus();
    }

    private void LimpiarCampos()
    {
        // Limpiamos los campos, pero dejamos guardados los alumnos de la lista.
        cuadroNombre.Clear();
        cuadroNota1.Clear();
        cuadroNota2.Clear();
        cuadroNota3.Clear();
        cuadroNota4.Clear();
    }
}
