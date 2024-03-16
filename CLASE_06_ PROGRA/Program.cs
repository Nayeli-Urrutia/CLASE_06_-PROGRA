using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_06__PROGRA
{
    internal class Program
    {
        static void ejemplo1()
        {
            int[] calificaciones;
            calificaciones = new int[] { 85, 92, 77, 68, 94 };

            bool hayAprovados = Array.Exists(calificaciones, calif => calif >= 60);
            Console.WriteLine("***********");
            Console.WriteLine("Hay Aprovados ");
            Console.WriteLine(hayAprovados);
            Console.WriteLine("***********");



            int i = 0;
            int esuma = 0;
            int enumeros2 = 0;
            foreach (int numeros in calificaciones)
            {
                Console.WriteLine(numeros);
                esuma = numeros + esuma;
            }
            int enumvector = calificaciones.Length;
            double resultado = esuma / enumvector;
            Console.WriteLine($"El promedio de las notas es de: {resultado}\n\n");

           




            int[] calificaciones2 = { 85, 92, 77, 68, 94, 56, 98, 36, 45, 95 };
            for (int ii = 0; ii < calificaciones2.Length; ii++)
            {
                esuma = calificaciones2[ii] + esuma;
                Console.WriteLine($"Calificación {ii + 1}: {calificaciones2[ii]}");
            }
            resultado = esuma / calificaciones2.Length;
            Console.WriteLine($"El promedio de las notas es de: {resultado}");
            Console.ReadKey();
        }


        static void despliegue(int[] arreglo)
        {
            foreach (int item in arreglo)
            {
                Console.WriteLine(item);
            }

        }
        static void ejemplo2()
        {

            int[] elementos = new int[] { 50, 20, 80, 90, 60 };
            Console.WriteLine("Original:");
            despliegue(elementos);

            Console.WriteLine("Ordenado:");
            Console.WriteLine("***********");
            Array.Sort(elementos);
            despliegue(elementos);
            Console.WriteLine("***********");

            Console.WriteLine("***********");
            Array.Reverse(elementos);
            despliegue(elementos);
            Console.WriteLine("***********");

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            ejemplo1();
        }
    }
}
