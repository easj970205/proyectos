namespace RegistroEstudiantes;

public class Alumno
{
    public string Nombre { get; set; } = string.Empty;
    public List<decimal> Notas { get; } = new();
}
