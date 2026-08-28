using SistemaDeAlumnos;
Alumno Pepe = new Alumno()
{
    Nombre = "Pepe",
    Legajo = 1,
    Nota1 = 10.0m,
    Nota2 = 5.0m,
};

Alumno Manolo = new Alumno()
{
    Nombre = "Manolo",
    Legajo = 2,
    Nota1 = 8.0m,
    Nota2 = 7.0m,
};

Console.WriteLine($"El alumno {Pepe.Nombre} tiene un legaje N° {Pepe.Legajo}");
Console.WriteLine();
Console.WriteLine($"El alumno {Manolo.Nombre} tiene un legaje N° {Manolo.Legajo}");

Pepe.Nombre = "Pepe1111";

Console.WriteLine($"El alumno {Pepe.Nombre} tiene un legaje N° {Pepe.Legajo}");
Console.WriteLine();
Console.WriteLine($"El alumno {Manolo.Nombre} tiene un legaje N° {Manolo.Legajo}");