using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            String nombre;
            String edad;
            String fNacimiento;
            String carrera;
            String fin;


            //Agregamos los campos a completar para la informacion que requerimos
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");
            Console.WriteLine("\nNombre "); nombre = Console.ReadLine();
            Console.WriteLine("\nEdad "); edad = Console.ReadLine();
            Console.WriteLine("\nFecha de nacimiento (DD/MM/AAAA)"); fNacimiento = Console.ReadLine();
            Console.WriteLine("\nCarrera "); carrera = Console.ReadLine();


            //Presentamos la informacion que hemos conseguido anteriormente y lo mostramos en pantalla
            Console.WriteLine("\nGracias " + nombre + " por fomar parte de UMI/Universidad Coppel \nBienvenido a la carrrera " + carrera);
            Console.WriteLine("\nNombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Fecha de nacimiento: " + fNacimiento);
            Console.WriteLine("Carrera: " + carrera);
            Console.ReadLine();
        }
    }
}
