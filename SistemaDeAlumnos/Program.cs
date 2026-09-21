using SistemaDeAlumnos;

List<Alumno> ListaAlumnos = new List<Alumno>();

bool salir = false;
while (!salir)
{
    Console.WriteLine("1) Añadir alumno");
    Console.WriteLine("2) Lista de alumnos");
    Console.WriteLine("3) Filtrar alumno por legajo");
    Console.WriteLine("4) Promedio general del curso");
    Console.WriteLine("5) Cantidad de alumnos aprobados");
    Console.WriteLine("6) Salir");
    Console.Write("Opción: ");
    string Opcion = Console.ReadLine();



    switch (Opcion)
    {
        case "1":
            Console.WriteLine("AÑADIR UN ALUMNO");
            Console.WriteLine();
            Console.Write("Ingrese el nombre del alumno: ");
            string Nombre = Console.ReadLine();

            Console.Write("Ingrese el documento: ");
            int Documento = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el N° de legajo: ");
            int Legajo = int.Parse(Console.ReadLine());

            ListaAlumnos.Add(new Alumno(Nombre, Documento, Legajo));           break;
        case "2":
            Console.WriteLine("LISTA DE ALUMNOS");
            Console.WriteLine();

            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                Console.WriteLine($"Alumno N° {i + 1}: {ListaAlumnos[i]}");
                Console.WriteLine();
            }
            break;
        case "3":

            Alumno AlumnoEncontrado = null;
            Console.WriteLine("FILTRO POR LEGAJO");
            Console.WriteLine();
            int LegajoFiltro = int.Parse(Console.ReadLine());
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {

                if (ListaAlumnos[i].Legajo == LegajoFiltro)
                {
                    AlumnoEncontrado = ListaAlumnos[i];
                    break;
                }

            }
            if (AlumnoEncontrado == null)
            {
                Console.WriteLine("No se encontró ningún alumno con ese legajo");
            }
            else
            {
                Console.WriteLine($"Alumno encontrado: {AlumnoEncontrado}");
            }
            break;

        case "4":
            Console.WriteLine("PROMEDIO GENERAL DE CURSO");
            Console.WriteLine();

            if (ListaAlumnos.Count == 0)
            {
                Console.WriteLine("No se cargaron alumnos");
                break;
            }
            decimal SumaPromedios = 0;
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                SumaPromedios += ListaAlumnos[i].Promedio();
            }
            decimal PromedioTotal = SumaPromedios / ListaAlumnos.Count;

            Console.WriteLine($"El promedio del curso es {PromedioTotal}");
            break;
        case "5":
            int AlumnosAprobados = 0;
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                if (ListaAlumnos[i].EstaAprobado())
                {
                    AlumnosAprobados += 1;
                }
            }
            Console.WriteLine($"{AlumnosAprobados} están aprobados");
            break;
        case "6":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    List<Persona> personas = new List<Persona>();

    personas.Add(new Alumno("Ana Pérez", 12345678, 1234));
    personas.Add(new Profesor("Marta Díaz", 23456789, "Programación"));

    foreach (Persona persona in personas)
    {
        Console.WriteLine(persona.Presentarse());
    }

    List<Alumno> alumnos = new List<Alumno>();

    alumnos.Add(new Alumno("Ana Pérez", 12345678, 1234));
    alumnos.Add(new Alumno("Juan López", 23456789, 2345));

    List<Profesor> profesores = new List<Profesor>();

    profesores.Add(new Profesor("Marta Díaz", 34567890, "Programación"));
    profesores.Add(new Profesor("Carlos Gómez", 45678901, "Matemática"));

    List<IExportable> exportables = new List<IExportable>();

    exportables.Add(alumnos[0]);
    exportables.Add(profesores[0]);
    exportables.Add(materias[0]);
    exportables.Add(alumnos[1]);
    exportables.Add(materias[1]);
    exportables.Add(profesores[1]);

    foreach (IExportable elemento in exportables)
{
    Console.WriteLine(elemento.ExportarLinea());
}
}





// --------------------------------------------------------------------------------

//using SistemaDeAlumnos;

//Alumno Pepe = new Alumno("Pepe", 1);
//Alumno Manolo = new Alumno("Manolo", 2);

//Console.WriteLine($"Nota Manolo {Manolo.Nota1} y {Manolo.Nota2}");

//Manolo.SubirNota();

//Console.WriteLine($"Nota Manolo {Manolo.Nota1} y {Manolo.Nota2}");

//Console.WriteLine();

//Console.WriteLine($"El alumno {Pepe.Nombre} tiene un legajo N° {Pepe.Legajo}");
//Console.WriteLine();

//Console.WriteLine($"El alumno {Manolo.Nombre} tiene un legajo N° {Manolo.Legajo}");

//Pepe.Nombre = "Pepe1111";

//Console.WriteLine();

//Console.WriteLine($"El alumno {Pepe.Nombre} tiene un legajo N° {Pepe.Legajo}");
//Console.WriteLine();

//Console.WriteLine($"El alumno {Manolo.Nombre} tiene un legajo N° {Manolo.Legajo}");

//Console.WriteLine();

//Console.WriteLine(Pepe);

//// Pepe.Nota1 = 47;

//bool notasCargadas = Pepe.CargarNotas(8.52m, 9.01m);

//if (notasCargadas)
//{
//    Console.WriteLine("Las notas son válidas y fueron cargadas.");
//}
//else
//{
//    Console.WriteLine("Las notas son inválidas.");
//}

//Console.WriteLine(Pepe);