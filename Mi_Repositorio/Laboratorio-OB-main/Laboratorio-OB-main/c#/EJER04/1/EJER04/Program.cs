using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace EJER04

{

    internal class Program

    {

        static void Main(string[] args)

        {

            // instanciacion de la clase

            microondas objmicroondas = new microondas();


            // carga de informacion

            Console.WriteLine("Ingrese el color");

            objmicroondas.color = Console.ReadLine();


            Console.WriteLine("Ingrese el marca");

            objmicroondas.marca = Console.ReadLine();


            Console.WriteLine("Ingrese la tamaño");

            objmicroondas.tamaño = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese la potencia");

            objmicroondas.potencia = Convert.ToInt32(Console.ReadLine());


            // salida de informacion

            objmicroondas.saludar();

            objmicroondas.mostrarDatos();

        }



        public class microondas
        {


            // constructor

            public microondas()
            {

            }


            // atributos

            public string color;

            public string marca;

            public int tamaño;

            public int potencia;


            // metodos

            public void saludar()
            {

                Console.WriteLine("Buenos días");

            }

            public void mostrarDatos()
            {

                Console.WriteLine("El Microondas de color {0} es de la marca {1}  tiene un tamaño de {2}cm y una potencia de {3}hz", color, marca, tamaño, potencia);

            }

        }

    }

}