namespace SistemaDeAlumnos;

public class Profesor : Persona, IExportable
{
    public string Materia { get; set; }

    public Profesor(string nombre, int documento, string materia)
        : base(nombre, documento)
    {
        Materia = materia;
    }

    public string ExportarLinea()
    {
        return $"{Nombre};{Documento};{Materia}";
    }

        public override string Presentarse()
    {
        return $"Hola, soy {Nombre}, Profesor aura.";
    }
}