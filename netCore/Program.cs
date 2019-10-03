using System;
using System.Linq;

namespace netCore
{
    class Program
    {
        static void Main(string[] args)
        {

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
             * ARREGLOS
             * 
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

            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine(array3[4]);
            */
            //********************************************************************************************************************************************

            /*
             * ARREGLOS BIDIMENSIONALES
             * LOS VALORES DE LOS PRIMEROS PARENESIS SON LAS COLUMNAS
             * LOS VALORES DE LOS SEGUNDOS PARENTESIS SON LAS FILAS
             * PARA LAS CORDENAS EL 1° ES EL VALOR DE LA FILA Y EL 2° ES EL VALOR DE LA COLUMNA
             */

            int[,] matriz = new int[2,2] { { 10,20 },
                                           {100,200} };

            int a = matriz[0,0];
            int b = matriz[0,1];
            int c = matriz[1,0];
            int d = matriz[1,1];

            Console.WriteLine(a); //10
            Console.WriteLine(b); //20
            Console.WriteLine(c); //100
            Console.WriteLine(d); //200

            //ARRAY TRIDIMENSIONAL O MULTIDIMENSIONAL

            double[,,] matriz3D = new double[2,2,3] { 
                                                    { {3.0,6.9,8.9},{6.8,4.5,7.6} }, 
                                                    { {6.0,6.8,2.9},{3.8,4.5,10.6} } 
                                                    };

            Console.WriteLine(matriz3D[0,0,2]);


            string[,,] words = new string[2, 2, 3] { 
                                                    { {"a","b","c"},{"d","e","f"} },
                                                    { {"g","h","i"},{"j","k","l"} }
                                                    };

            Console.WriteLine("matriz de string: " + words[1, 1, 1]);

            Console.WriteLine("**********************************************************************");

            /*
             * El foreach te permite recorrer una serie de datos por ejemplo de un array 
             * de principio a fin almacenando cada valor del arreglo en el objeto item
             */
            foreach (var item in words)
            {
                Console.WriteLine("Contenido del array words " + item);
            }

            Console.ReadLine();

        }
    }
}
