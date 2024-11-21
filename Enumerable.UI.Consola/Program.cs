using Enumerable.UI.Consola;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("Enumerable");
        Console.WriteLine("===========================================");
        Console.WriteLine("\n");
        Console.WriteLine("*Mtc*   *Lista*  *precio*  List<T>");

   


        #region Lista
        var Lista = new List<Alumnos>
        {
            new Alumnos {Matricula = 1, Nombre = "Juan", Precio = 24.459M},
            new Alumnos {Matricula = 2, Nombre = "jose", Precio = 22.563M},
            new Alumnos {Matricula = 3, Nombre = "Luis", Precio = 21.999M},
            new Alumnos {Matricula = 4, Nombre = "Ileny", Precio = 20.085M},
            new Alumnos {Matricula = 5, Nombre = "Karla", Precio = 19.789M},
            new Alumnos {Matricula = 6, Nombre = "Casco",Precio = 25.453M},
            new Alumnos {Matricula = 7, Nombre = "Mitzi", Precio = 22.233M},
            new Alumnos {Matricula = 8, Nombre = "Isabel",Precio = 19.434M},
            new Alumnos {Matricula = 9, Nombre = "Zuri", Precio = 18.456M},

        };


        //foreach (var nombre in Lista)
        //{
        //    Console.WriteLine(nombre);
        //}

        //Lista.Clear();
        //Lista.Sort();

        Lista = Lista.OrderBy(x => x.Precio).ToList();
        //Lista = Lista.OrderBy(x => x.Edad).ToList();

        for (int i = 0; i < Lista.Count; i++)
        {

            Console.WriteLine(Lista[i]);
        }

        #endregion
        Console.ReadKey();
    }
}