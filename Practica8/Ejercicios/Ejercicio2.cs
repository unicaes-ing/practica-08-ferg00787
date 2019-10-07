using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8.Ejercicios
{
    class Ejercicio2
    {
        public struct Producto
        {
            public string nombre;
            private int cantidad;
            private double precio;
            private const double iva = 0.13;


            public void setCantidad(int cantidad)
            {
                if (cantidad > 0)
                {
                    this.cantidad = cantidad;
                }
            }

            public int getCantidad()
            {
                return cantidad;
            }

            public void setPrecio(double precio)
            {
                if (precio > 0.00)
                {
                    this.precio = precio;
                }
            }

            public double getPrecio()
            {
                double pagar;
                pagar = precio * iva;
                return precio + pagar;
            }
        }

        static void Main(string[] args)
        {
            int cant;
            Console.Write("Cantidad de productos a ingresar: ");

            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Producto[] prod = new Producto[cant];

            for (int i = 0; i < prod.Length; i++)
            {
                Console.WriteLine("Producto #{0}", i + 1);
                Console.Write("Ingrese el nombre del producto: ");
                prod[i].nombre = Console.ReadLine();
                Console.Write("Ingrese la cantidad del producto: ");
                prod[i].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Ingrese el precio del producto: ");
                prod[i].setPrecio(Convert.ToDouble(Console.ReadLine()));


            }


            for (int i = 0; i < prod.Length; i++)
            {

                Console.Clear();
                Console.WriteLine("Precio <Enter>  para mostrar el total a pagar por el cliente");
                Console.ReadKey();
                Console.Clear();
                double total;
                total = prod[i].getCantidad() * prod[i].getPrecio();
                Console.WriteLine("{0,5}   {1,-10}   {2,7}   {3,9} ", "Producto", "Cantidad", "Precio", "Total");
                Console.WriteLine("-------------------------------------------------------------");
                foreach (Producto p in prod)
                {
                    Console.WriteLine("{0,5}  {1,8}  {2, 13}   {3,10} ",
                        prod[i].nombre,
                        prod[i].getCantidad(),
                        prod[i].getPrecio(),
                        total);

                }

            }
            Console.ReadKey();



        }

    }
}
