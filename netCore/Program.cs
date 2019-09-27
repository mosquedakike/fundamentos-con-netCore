using System;

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
             */

            int valor1 = 9;
            int valor2 = 8;
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

            name = data ? "Alex" : "Joel";

            Console.WriteLine("Resultado " + name);

            Console.ReadLine();
            
        }
    }
}
