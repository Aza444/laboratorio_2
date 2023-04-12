using Laboratorio_2.DAO;
using Laboratorio_2.Models;

CrudNota CrudNota = new CrudNota();
Nota Nota = new Nota();

bool continuar = true;
while (continuar)
{
    Console.WriteLine("Bienvenidos o Bienvenidas usuario, puede calcular sus notas desde aqui");
    Console.WriteLine("                 Menu                   ");
    Console.WriteLine("pulse 1 para calcular Notas");
    Console.WriteLine("pulse 2 para listar notas");

    var Menu = Convert.ToInt32(Console.ReadLine());
    switch(Menu) 
    {
      case 1:
            Console.WriteLine("Ingrese el nombre de la materia");
            Nota.Materia = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del Estudiante ");
            Nota.NombreEstudiante = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del laboratorio_1 ");
            Nota.Lab1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Parcial_1 ");
            Nota.Parcial1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del laboratorio_2 ");
            Nota.Lab2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Parcial_2 ");
            Nota.Parcial2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del laboratorio_3 ");
            Nota.Lab3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Parcial_3 ");
            Nota.Parcial3 = Convert.ToDecimal(Console.ReadLine());
            
            
            CrudNota.CalcularResultado(Nota);
            CrudNota.AgregarNota(Nota);
            Console.WriteLine($"su resultado es {Nota.Resultado}");
            Console.WriteLine("Sus notas se han guardado");




            break;   

            case 2:
            Console.WriteLine("Lista de Notas");
            var ListarNotas = CrudNota.ListarNotas();
            foreach (var iteracionNota in ListarNotas)
            {
                Console.WriteLine($"ID {IteracionNota.IdNotas},Nombre de la Materia: {IteracionNota.Materia},Nombre del Alumno:{IteracionNota.NombreEstudiante},laboratorio_1:{IteracionNota.Lab1},parcial_2:{IteracionNota.Parcial1},laboratorio_2: {IteracionNota.Lab2},parcial_2: {IteracionNota.Parcial2},laboratorio_3:{IteracionNota.Lab3},parcial_3:{IteracionNota.Parcial3},su nota final: {IteracionNota.Resultado}");
            }
            break;

    }


    Console.WriteLine("¿Desea continuar? /n presione S para si y N para No");
    var cont = Console.ReadLine();
    if (cont.Equals("N"))
    {
        continuar = false;
    }
}


