using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    class Ejercicio1
    {
        public struct Estudiante
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private double cum;

            public void setCum(double cum)
            {
                if (cum >= 0)
                {
                    if (cum <= 10)
                    {
                        this.cum = cum;
                    }


                }
            }

            public double getCum()
            {
                return cum;
            }


        }


        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante();
            Console.WriteLine("Ingrese su carnet: ");
            Console.WriteLine("--------------------");
            est1.carnet = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre: ");
            Console.WriteLine("--------------------");
            est1.nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su carrera: ");
            Console.WriteLine("--------------------");
            est1.carrera = Console.ReadLine();

            Console.WriteLine("Ingrese su cum: ");
            Console.WriteLine("--------------------");
            est1.setCum(Convert.ToDouble(Console.ReadLine()));

            Console.Clear();
            Console.WriteLine("Carnet:  " + est1.carnet);
            Console.WriteLine("Nombre: " + est1.nombre);
            Console.WriteLine("Carrera: " + est1.carrera);
            Console.WriteLine("Cum: " + est1.getCum());
        }

    }
}
