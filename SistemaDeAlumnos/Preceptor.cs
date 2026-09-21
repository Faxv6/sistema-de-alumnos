namespace SistemaDeAlumnos;

public class Preceptor : Persona
{
    public Preceptor(string nombre, int documento)
        : base(nombre, documento)
    {
    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombre}, preceptor.";
    }
}