namespace SistemaDeAlumnos;

public class Materia : IExportable
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public int CantidadHoras { get; set; }

    public Materia(int codigo, string nombre, int cantidadHoras)
    {
        Codigo = codigo;
        Nombre = nombre;
        CantidadHoras = cantidadHoras;
    }

    public string ExportarLinea()
    {
        return $"{Codigo};{Nombre};{CantidadHoras}";
    }
}