using System.Globalization;

namespace CalculadoraPromedio;

public partial class FormularioPromedio : Form
{
    public FormularioPromedio()
    {
        // Prepara todos los controles que aparecen en la ventana.
        InitializeComponent();
    }

    private void CalcularPromedio(object? objeto, EventArgs argumentos)
    {
        string materia = txtMateria.Text.Trim();

        if (string.IsNullOrWhiteSpace(materia))
        {
            MessageBox.Show(this, "Escribe el nombre de la materia.", "Falta la materia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMateria.Focus();
            return;
        }

        // Guardamos los cuatro cuadros en un arreglo para recorrerlos fácilmente.
        TextBox[] calificaciones =
        {
            txtCalificacion1,
            txtCalificacion2,
            txtCalificacion3,
            txtCalificacion4
        };

        decimal suma = 0m;
        int cantidad = 0;

        for (int indice = 0; indice < calificaciones.Length; indice++)
        {
            string texto = calificaciones[indice].Text.Trim();

            if (texto == "")
            {
                continue;
            }

            if (!IntentarLeerCalificacion(texto, out decimal calificacion))
            {
                MessageBox.Show(this,
                    $"La calificación {indice + 1} debe ser un número.",
                    "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                calificaciones[indice].Focus();
                calificaciones[indice].SelectAll();
                return;
            }

            if (calificacion < 0m || calificacion > 100m)
            {
                MessageBox.Show(this,
                    $"La calificación {indice + 1} debe estar entre 0 y 100.",
                    "Dato fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                calificaciones[indice].Focus();
                calificaciones[indice].SelectAll();
                return;
            }

            suma += calificacion;
            cantidad++;
        }

        if (cantidad == 0)
        {
            MessageBox.Show(this, "Escribe por lo menos una calificación.",
                "Faltan calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCalificacion1.Focus();
            return;
        }

        // El promedio se obtiene dividiendo la suma entre la cantidad capturada.
        decimal promedio = suma / cantidad;
        string comentario = ObtenerComentario(promedio);
        lblResultado.Text = $"El promedio de {materia} es {promedio:0.00}.\n{comentario}";
    }

    private static bool IntentarLeerCalificacion(string texto, out decimal calificacion)
    {
        // Aceptamos números con coma o con punto decimal.
        string textoNormalizado = texto.Trim().Replace(',', '.');
        return decimal.TryParse(textoNormalizado, NumberStyles.Float,
            CultureInfo.InvariantCulture, out calificacion);
    }

    private static string ObtenerComentario(decimal promedio)
    {
        // Se aplican los rangos solicitados para describir el desempeño.
        if (promedio < 70m)
        {
            return "No aprobatoria: el alumno debe repetir.";
        }

        if (promedio <= 80m)
        {
            return "Desempeño regular.";
        }

        if (promedio <= 90m)
        {
            return "Desempeño bueno.";
        }

        return "Desempeño excelente.";
    }

    private void LimpiarCampos(object? objeto, EventArgs argumentos)
    {
        txtMateria.Clear();
        txtCalificacion1.Clear();
        txtCalificacion2.Clear();
        txtCalificacion3.Clear();
        txtCalificacion4.Clear();
        lblResultado.Text = "El promedio y la observación aparecerán aquí.";
        txtMateria.Focus();
    }
}
