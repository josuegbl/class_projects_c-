using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class ejercicios_arr_bucles_6
{
    public static void Main(string[] args)
    {
        /// Crear un algoritmo que actúe como un generador de "caminos".
        /// Tendremos un número que representará lo "ancho" de una fila.
        /// Un array que será el de "movimientos", que solo podrán ser "ABAJO" y
        /// "DERECHA"
        /// El array de movimientos contrendrá un número variable de movimientos.
        /// Pintar '->' cuando el movimiento sea hacia la derecha.
        /// . Pintar '|' en la línea desde la que se baja y a la que se baja cuando
        /// sea hacia abajo.
        /// Tener en cuenta que un movimiento a derecha no pueda "salirse" del 
        /// "ancho de la fila", la aplicación dejará de imprimir movimientos en
        /// este caso.
        /// No habrá más límite de veces en el que se podrá ir "abajo" que el que
        /// el número de movimientos "ABAJO" permita.
        /// Un camino podría ser tal que así: 
        /// |
        /// | ->->->|
        ///         ||
        ///          |->->->->->|
        ///                     ||
        ///                      |->

        int limiteFila = 20;
        string[] arrMovimiento = { "DCHA", "ABAJO", "ABAJO", "DCHA", "ABAJO", "IZQ", "IZQ" };// , "DCHA", "ABAJO", "ABAJO", "DCHA", "DCHA", "ABAJO", "DCHA" };

        for (int i = 0; i < arrMovimiento.Length; i++)
        {
            if (Console.CursorLeft >= limiteFila)
            {
                break;
            }
            else if (arrMovimiento[i] == "DCHA")
            {
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                Console.Write("->");
            }
            else if (arrMovimiento[i] == "ABAJO")
            {
                if (i == 0 || arrMovimiento[i - 1] != "ABAJO")
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    Console.Write("|");
                }
                Console.CursorTop++;
                Console.CursorLeft--;
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                Console.Write("|");
            }
            else if (arrMovimiento[i] == "IZQ")
            {
                if (i == 0)
                {
                    Console.WriteLine("No se puede empezar con Izquierda");
                    break;
                }
                if (arrMovimiento[i - 1] != "IZQ")
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    Console.Write("|");
                    Console.CursorTop++;
                    Console.CursorLeft--;
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    Console.Write("|");

                    Console.CursorLeft -= 3;
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    Console.Write("<-");
                }
                else
                {
                    Console.CursorLeft -= 4;
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                    Console.Write("<-");
                }

            }
        }
        Console.WriteLine("\n");

        //***************
        /// Crear una variable y asignarle un valor.
        /// Crear dos arrays de numeros enteros y asignarles valores.
        /// Cambiar los contenidos de los dos arrays, si uno es mayor que otro:
        ///   En el cambio del menor al mayor, rellenar los huecos que 
        ///   "sobren" con el numero de la variable.
        ///   En el cambio del mayor al menor, no cambia los números que 
        ///   no "quepan"
        ///   Si los arrays son a = [1,2,3] y b = [4,5,6,7,8] y el numero 0
        ///   el resultado seria a = [4,5,6] y b = [1,2,3,0,0]
        /// Sacar por pantalla los arrays cambiados
        /// PISTA: Se pueden usar "variables intermedias" para no perder los 
        /// originales en el cambio.
        /// NOTA: El objetivo del ejercicio es partir de 2 arrays de cambiar sus valores.
        int[] arr2 = { 1, 2, 3 };
        int[] arr1 = { 4, 5, 6, 7, 8 };

        int valor = 9;

        if (arr1.Length >= arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (i < arr2.Length)
                {
                    int intAux = arr1[i];
                    arr1[i] = arr2[i];
                    arr2[i] = intAux;
                }
                else
                {
                    arr1[i] = valor;
                }
            }
        }
        else
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                if (i < arr1.Length)
                {
                    int intAux = arr1[i];
                    arr1[i] = arr2[i];
                    arr2[i] = intAux;
                }
                else
                {
                    arr2[i] = valor;
                }
            }
        }
        Console.WriteLine("array1");
        for (int i = 0; i < arr1.Length; i++) Console.Write(arr1[i]);
        Console.Write("\n");
        Console.WriteLine("array2");
        for (int i = 0; i < arr2.Length; i++) Console.Write(arr2[i]);
        Console.WriteLine("\n");

        //***************
        /// Other way
        arr2 = [1, 2, 3];
        arr1 = [4, 5, 6, 7, 8];
        valor = 0;

        for (int i = 0; i < arr1.Length || i < arr2.Length; i++)
        {
            if (i < arr1.Length && i < arr2.Length)
            {
                int intAux = arr1[i];
                arr1[i] = arr2[i];
                arr2[i] = intAux;
            }
            else
            {
                if (arr1.Length > arr2.Length)
                {
                    arr1[i] = valor;
                }
                else
                {
                    arr2[i] = valor;
                }
            }
        }

        Console.WriteLine("array1");
        for (int i = 0; i < arr1.Length; i++) Console.Write(arr1[i]);
        Console.Write("\n");
        Console.WriteLine("array2");
        for (int i = 0; i < arr2.Length; i++) Console.Write(arr2[i]);
        Console.WriteLine("\n");

        //***************
        /// Crear un algoritmo para comprobar si un array de 
        /// caracteres de varias dimensiones forma un "cuadrado
        /// mágico" de orden 5. Una estructura de este tipo es
        /// aquella en la que todas las palabras se leen igual
        /// tanto de izquierda a derecha, saltando de línea
        /// (array), como de derecha a izquierda, y además también
        /// de arriba a abajo y de abajo a arriba.
        /// El cuadrado mágico de orden cinco más conocido es el siguiente:
        /// SATOR
        /// AREPO
        /// TENET
        /// OPERA
        /// ROTAS
        /// NOTA: Utilizar un array de varias dimensiones para el ejecricio.

        char[,] magicSquare = {
                              {'S','A','T','O','R'},
                              {'A','R','E','P','O'},
                              {'T','E','N','E','T'},
                              {'O','P','E','R','A'},
                              {'R','O','T','A','S'},
                              };
        bool isMagic = true;

        for (int i = 0, j = magicSquare.GetLength(0) - 1; i <= j; i++, j--)
        {
            for (int k = 0, l = magicSquare.GetLength(1) - 1; k < magicSquare.GetLength(1); k++, l--)
            {
                // check if rows and colunms meets the conditions.
                Console.WriteLine(magicSquare[i, k] + " " + magicSquare[j, l] + " " + magicSquare[k, i] + " " + magicSquare[l, j]);

                if (magicSquare[i, k] != magicSquare[j, l] || magicSquare[k, i] != magicSquare[l, j])
                {
                    i = magicSquare.GetLength(0) + 1;
                    k = magicSquare.GetLength(0) + 1;
                    isMagic = false;
                }
                // check if central cross meets the conditions. 
                if (i == j && (magicSquare[i, k] != magicSquare[k, i] || magicSquare[j, l] != magicSquare[l, j]))
                {
                    i = magicSquare.GetLength(0) + 1;
                    k = magicSquare.GetLength(0) + 1;
                    isMagic = false;
                }

            }
        }

        if (!isMagic)
        {
            Console.WriteLine("No es un cuadrado mágico");
        }
        else
        {
            Console.WriteLine("Enhorabuena! Es un cuadrado mágico");
        }
    }
}
