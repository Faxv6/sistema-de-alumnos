using SistemaDeAlumnos;
Alumno Pepe = new Alumno("Pepe", 1, 7.59m, 5.85m);
//{
//    Nombre = "Pepe",
//    Legajo = 1,
//    Nota1 = 10.0m,
//    Nota2 = 5.0m,
//};

Alumno Manolo = new Alumno("Manolo", 2, 10.0m, 8.52m);
//{
//    Nombre = "Manolo",
//    Legajo = 2,
//    Nota1 = 8.0m,
//    Nota2 = 7.0m,
//};

Console.WriteLine($"Nota Manolo {Manolo.Nota1} y {Manolo.Nota2}");
Manolo.SubirNota();
Console.WriteLine($"Nota Manolo {Manolo.Nota1} y {Manolo.Nota2}");


//Alumno AlumnoPrueba = new Alumno();
//Error CS7036 - Este error aparece porque se esperan recibir los parámetros para instanciar el nuevo objeto, los cuales son los declarados en el constructor. 

Console.WriteLine($"El alumno {Pepe.Nombre} tiene un legaje N° {Pepe.Legajo}");
Console.WriteLine();
Console.WriteLine($"El alumno {Manolo.Nombre} tiene un legaje N° {Manolo.Legajo}");

Pepe.Nombre = "Pepe1111";

Console.WriteLine($"El alumno {Pepe.Nombre} tiene un legaje N° {Pepe.Legajo}");
Console.WriteLine();
Console.WriteLine($"El alumno {Manolo.Nombre} tiene un legaje N° {Manolo.Legajo}");

Console.WriteLine();

Console.WriteLine(Pepe);