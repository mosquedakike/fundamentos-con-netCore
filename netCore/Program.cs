using System;
using System.Linq;

namespace netCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULADORA
            /*
            int suma;
            int resta;
            int multiplicacion;
            int division;
            int option;

            Console.WriteLine("inserte el valor de a: ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Inserte el valor de b: ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Selecciona alguna de las siguientes opciones:\n\nSumar: 1\nRestar: 2\nMultiplicar: 3\nDividir: 4\n");
            option = Convert.ToInt16(Console.ReadLine());

            switch(option)
            {
                case 1:
                    suma = a + b;
                    Console.WriteLine("El resultado de a + b es: " + suma);
                    break;
                case 2:
                    resta = a - b;
                    Console.WriteLine("El resultado de a - b es: " + resta);
                    break;
                case 3:
                    multiplicacion = a * b;
                    Console.WriteLine("El resultado de a * b es: " + multiplicacion);
                    break;
                case 4:
                    division = a / b;
                    Console.WriteLine("El resultado de a / b es: " + division);
                    break;
            }

            //if (option == 1)
            //{
            //    suma = a + b;
            //    Console.WriteLine("El resultado de a + b es: " + suma);
            //}
            //if (option == 2)
            //{
            //    resta = a - b;
            //    Console.WriteLine("El resultado de a - b es: " + resta);
            //}
            //if (option == 3)
            //{
            //    multiplicacion = a * b;
            //    Console.WriteLine("El resultado de a * b es: " + multiplicacion);
            //}
            //if (option == 4)
            //{
            //    division = a / b;
            //    Console.WriteLine("El resultado de a / b es: " + division);
            //}
            //else
            //{
            //    Console.WriteLine("NO ES UNA OPCION VALIDA");
            //}



            Console.ReadLine();
            */
            //********************************************************************************************************************************************

            /*
             * TIPOS DE OPERADORES:
             *  < menor que 
             *  > mayor que
             *  <= menor o igual que
             *  >= mayor o igual que
             *  == igual a
             *  ! diferente de
             *  != diferente o igual a
             *  && y
             *  || o
             

            int valor1 = 9;
            int valor2 = 9;
            string name;
            var data = valor1 != valor2;

            //if (data)
            //{
            //    name = "Alex";
            //}
            //else
            //{
            //    name = "Joel";
            //}

            //se valida el valor de la variable que esta del lado derecho del [?] si el valor es [true]
            //se imprime el valor de la izquierda de los [:] si es [false] se imprime lo de la derecha
            name = data ? "Alex" : "Joel";

            Console.WriteLine("Resultado " + name);
            */
            //********************************************************************************************************************************************

            //ARREGLOS

            int[] numeros = new int[3];
            string[] cadenas = new string[5];

            //pedir datos para el llenado del arreglo
            for (var a=0; a<cadenas.Length; a++)
            {
                Console.WriteLine("Inserta el valor del arreglo en la posicion [" + a + "]");
                cadenas[a] = Console.ReadLine();
            }

            for (var i = 0; i < cadenas.Length; i++)
            {
                Console.WriteLine("En la posicion " + i + " contiene: " + cadenas[i]);
            }
            //cadenas[1] = "kike";
            //cadenas[2] = "miguel";
            //cadenas[3] = "ricardo";
            //cadenas[4] = "fernando";

            numeros[0] = 1;
            Console.WriteLine(numeros[0]);

            //declarar arreglo e inicializarlo de tipo string
            string[] carreras = {"info","industrial"};
            Console.WriteLine(carreras[0]);
            //declarar arreglo e inicializarlo de tipo int
            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine(array3[4]);

            Console.ReadLine();

            
        }
    }
}
