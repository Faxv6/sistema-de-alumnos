using SistemaDeAlumnos;

Alumno Pepe = new Alumno("Pepe", 1);
Alumno Manolo = new Alumno("Manolo", 2);

Console.WriteLine($"Nota Manolo {Manolo.Nota1} y {Manolo.Nota2}");

Manolo.SubirNota();

Console.WriteLine($"Nota Manolo {Manolo.Nota1} y {Manolo.Nota2}");

Console.WriteLine();

Console.WriteLine($"El alumno {Pepe.Nombre} tiene un legajo N° {Pepe.Legajo}");
Console.WriteLine();

Console.WriteLine($"El alumno {Manolo.Nombre} tiene un legajo N° {Manolo.Legajo}");

Pepe.Nombre = "Pepe1111";

Console.WriteLine();

Console.WriteLine($"El alumno {Pepe.Nombre} tiene un legajo N° {Pepe.Legajo}");
Console.WriteLine();

Console.WriteLine($"El alumno {Manolo.Nombre} tiene un legajo N° {Manolo.Legajo}");

Console.WriteLine();

Console.WriteLine(Pepe);

// Pepe.Nota1 = 47;

bool notasCargadas = Pepe.CargarNotas(8.52m, 9.01m);

if (notasCargadas)
{
    Console.WriteLine("Las notas son válidas y fueron cargadas.");
}
else
{
    Console.WriteLine("Las notas son inválidas.");
}

Console.WriteLine(Pepe);