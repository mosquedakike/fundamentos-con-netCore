using System;

namespace netCore
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //********************************************************************************************************************************************
            /*
            *******************************************************************
            *                           OPERADORES                            *
            *******************************************************************
            */

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

            if (data)
            {
                name = "Alex";
            }
            else
            {
                name = "Joel";
            }

            //se valida el valor de la variable que esta del lado derecho del [?] si el valor es [true]
            //se imprime el valor de la izquierda de los [:] si es [false] se imprime lo de la derecha
            name = data ? "Alex" : "Joel";

            Console.WriteLine("Resultado " + name);
            */
            //********************************************************************************************************************************************

            /*
           *******************************************************************
           *                           ARREGLOS                              *
           *******************************************************************
           */

            /* ARREGLOS
              
            //Arreglo de tipo string
            string[] cadenas = new string[5];

            cadenas[0] = "Alex";
            cadenas[1] = "kike";
            cadenas[2] = "miguel";
            cadenas[3] = "ricardo";
            cadenas[4] = "fernando";

            for (var i = 0; i < cadenas.Length; i++)
            {
                Console.WriteLine("En la posicion " + i + " contiene: " + cadenas[i]);
            }

            //Arreglo de tipo int
            int[] numeros = new int[3];

            numeros[0] = 1;
            Console.WriteLine(numeros[0]);

            //Arreglo de tipo string sin definir la longitud

            string[] carreras = {"info","industrial"};
            Console.WriteLine(carreras[0]);
            //declarar arreglo e inicializarlo de tipo int
            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine(array3[4]);

            Console.ReadLine();
            */

            //********************************************************************************************************************************************

            /*
            *******************************************************************
            *       ARREGLOS BIBIMENSIONALES Y MULTIDIMENSIONALES             * 
            *******************************************************************
            */

            /*
             * ARREGLOS BIDIMENSIONALES
             * LOS VALORES DE LOS PRIMEROS PARENESIS SON LAS COLUMNAS
             * LOS VALORES DE LOS SEGUNDOS PARENTESIS SON LAS FILAS
             * PARA LAS CORDENAS EL 1° ES EL VALOR DE LA FILA Y EL 2° ES EL VALOR DE LA COLUMNA
             */
            /*
           int[,] matriz = new int[2, 2] { { 10,20 },
                                          {100,200} };


           int a = matriz[0, 0];
           int b = matriz[0, 1];
           int c = matriz[1, 0];
           int d = matriz[1, 1];

           Console.WriteLine(a); //10
           Console.WriteLine(b); //20
           Console.WriteLine(c); //100
           Console.WriteLine(d); //200

           //ARRAY TRIDIMENSIONAL O MULTIDIMENSIONAL

           double[,,] matriz3D = new double[2, 2, 3] {
                                                   { {3.0,6.9,8.9},{6.8,4.5,7.6} },
                                                   { {6.0,6.8,2.9},{3.8,4.5,10.6} }
                                                   };

           Console.WriteLine(matriz3D[0, 0, 2]);


           string[,,] words = new string[2, 2, 3] {
                                                   { {"a","b","c"},{"d","e","f"} },
                                                   { {"g","h","i"},{"j","k","l"} }
                                                   };

           Console.WriteLine("matriz de string: " + words[1, 1, 1]);

           Console.WriteLine("**********************************************************************");

             /*
            *******************************************************************
            *                         FOR Y FOREACH                           * 
            *******************************************************************
            */

            /*
             * El foreach te permite recorrer una serie de datos por ejemplo de un array 
             * de principio a fin almacenando cada valor del arreglo en el objeto item
             */
            /*
           int[] array_number2 = new int[] { 0, 1, 2 };

           for (int i = 0; i < array_number2.Length; i++)
           {
               Console.WriteLine("Array con for: " + array_number2[i]);
           }

           int[] array_foreach = new int[3];

           array_foreach[0] = 10;
           array_foreach[1] = 20;
           array_foreach[2] = 30;

           foreach (var item in array_foreach)
           {
               Console.WriteLine("Array con foreach: " + item);
           }
           */


            //********************************************************************************************************************************************

            /*
            *******************************************************************
            *                          SWITCH                                 * 
            *******************************************************************
            */

            /*
             * Switch #1
            */
            /*
            int a = 5;
            string a = "kike";

            switch (a)
            {
                case "jose":
                    Console.WriteLine("Estas en el case 1: {0}", a);
                    break;
                case "kike":
                    Console.WriteLine("Este es el case de string");
                    break;
                default:
                    Console.WriteLine("Este es el case default");
                    break;
            }
            */

            /*
             * Switch #2
             * Este tipo de switch solo funciona de la version 8 de C# en adelante
            */

            /*
            var data = 2;
            var result = data switch
            {
                1 => "primero",
                2 => "segundo",
                3 => "tercero"
            };

            Console.WriteLine("Contenido de la variable RESULT: " + result);
            */

            /*
             *Switch #3
             * 
             */

            /*
            var (a, b, option) = (2, 4, "*");
            var result = option switch
            {
            "+" => a+b,
            "-" => a-b,
            "*" => a*b
            };

            Console.WriteLine("El valor de RESULT es: {0}", result);

            var (c, d, opcion) = (20, 40, "-");
            var resultado = opcion switch
            {
                "+" => c == d,
                "-" => c < d,
                "*" => c > d
            };

            Console.WriteLine("El valor de RSTULTADO es: {0}",resultado);
            */

            /*
            *******************************************************************
            *                         WHILE Y DOWHILE                         * 
            *******************************************************************
            */

            /*
            * El While se ejecuta infinitamente hasta que ya no cumpla la condicion que  
            * lleva en sus parentesis
            */

            /*
            int a = 1;
            while (a<5)
            {
                Console.WriteLine("El valor de a es: {0}",a);
                a++;
            }

            Console.WriteLine("saliendo del while... ahora el valor de a es: {0}",a);

            do
            {
                Console.WriteLine("El valor de a es: {0}",a);
                a--;
            } while (a>0);

            Console.WriteLine("saliendo del do while... ahora el valor ed a es: {0}",a);
            */

            /*
            *******************************************************************
            *                   INMUTABILIDAD DE STRINGS                      * 
            *******************************************************************
            */

            /*
            string name1 = "kike";
            string name2 = "miguel";
            string name3 = name1;
            name1 += name2;

            Console.WriteLine("El valor de name1 es: {0}", name1);
            Console.WriteLine("El valor de name3, contiene name1 y es: {0}", name3);
            */

            /*
            *
            *******************************************************************
            *               FORMATEAR CADENAS DE TIPO STRING                  * 
            *******************************************************************
            */

            //INTERPOLACION DE DE CADENAS

            var nombres = (name1: "kike", number: 25, name2: "miguel");

            Console.WriteLine("{0} {1} {2}", $"{nombres.name1}", $"{nombres.name2}", $"{nombres.number}");

            var numeros = (first: 1, second: 2);

            Console.WriteLine(numeros.first);


            //Substring
            var message = "Hello World";

            Console.WriteLine(message);
            Console.WriteLine(message.Substring(0,3));
            var remplazar = message.Replace("World", "Mexico");
            Console.WriteLine(remplazar);

            /*
            * [ToCharArray] sirve para convertir una cadena en una array
            * [ToLower] sirve para convertir el texto en minusculas
            * [ToUpper] sirve para convertir el texto en mayusculas
            */

            var data = message.ToCharArray();
            Console.WriteLine(data[6]);

            var minusculas = message.ToLower();
            var mayusculas = message.ToUpper();
            Console.WriteLine(mayusculas);
            Console.WriteLine(minusculas);

            foreach (var item in message)
            {
                Console.WriteLine("Imprime la cadena de texto por posicion: {0}",item);
            }


            Console.ReadLine();

        }
    }
}