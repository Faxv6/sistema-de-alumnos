namespace SistemaDeAlumnos;

public class Alumno
{
    public string Nombre { get; set; }

    private int legajo;
    public int Legajo
    {
        get { return legajo; }
        private set { legajo = value; }
    }

    private decimal nota1;
    public decimal Nota1
    {
        get { return nota1; }
        private set { nota1 = value; }
    }

    private decimal nota2;
    public decimal Nota2
    {
        get { return nota2; }
        private set { nota2 = value; }
    }

    public Alumno(string nombre, int legajo)
    {
        Nombre = nombre;
        Legajo = legajo;
    }

    public decimal Promedio()
    {
        return (Nota1 + Nota2) / 2;
    }

    public bool EstaAprobado()
    {
        if (Promedio() < 6)
            return false;
        else
            return true;
    }
    public void SubirNota()
    {
        Nota1 = Math.Min(Nota1 + 1, 10);
        Nota2 = Math.Min(Nota2 + 1, 10);
    }

    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (Promedio: {Promedio()})";
    }

    public bool CargarNotas(decimal nota1, decimal nota2)
    {
        if (nota1 >= 0 && nota1 <= 10 &&
            nota2 >= 0 && nota2 <= 10)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            return true;
        }

        return false;
    }
}