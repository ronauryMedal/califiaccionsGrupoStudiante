using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace califiaccionsGrupoStudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            int CantidadStudiante;
            double nota1, nota2, nota3, nota4, promedioTotal=0;
            string nombre;
            Console.WriteLine("--------------------promedios de un grupo de estudiantes----------------");

            Console.WriteLine("cantidad de estudiante ");
            CantidadStudiante = int.Parse(Console.ReadLine());

            for (int i =1; i <=CantidadStudiante; i++)
            {
                Console.WriteLine("ingrese el nombre del estudiante");
                nombre = Console.ReadLine();

                Console.WriteLine("ingrese primera nota");
                nota1 = int.Parse(Console.ReadLine());


                Console.WriteLine("ingrese segunda nota");
                nota2 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese tercera nota");
                nota3 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese cuarta nota");
                nota4 = int.Parse(Console.ReadLine());

                promedioTotal = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine("el promedio de " + nombre + "="  + promedioTotal);

            }

            Console.ReadKey();

        }
    }
}
