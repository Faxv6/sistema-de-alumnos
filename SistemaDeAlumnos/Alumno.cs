namespace SistemaDeAlumnos;

public class Alumno
{
    public string Nombre { get; set; }
    public int Legajo { get; set; }
    public decimal Nota1 { get; set; }
    public decimal Nota2 { get; set; }

    public Alumno(string nombre, int legajo, decimal nota1, decimal nota2)
    {
        Nombre = nombre;
        Legajo = legajo;
        Nota1 = nota1;
        Nota2 = nota2;
    }

    public decimal Promedio()
    {
        return (Nota1 + Nota2) / 2;
    }

    public bool EstaAprobado()
    {
        if (Promedio() < 6) return false;
        else return true;
    }

    public void SubirNota()
    {
        if (Nota1 < 10)
        {
            Nota1++;
        }

        if (Nota2 < 10)
        {
            Nota2++;
        }
    }

    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (Promedio: {Promedio()})";
    } // CS0114: 'Alumno.ToString()' hides inherited member 'object.ToString()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
}

