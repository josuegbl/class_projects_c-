using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

internal class ejercicios_arr_bucles_2
{
    public static void Main(string[] args)
    {
        /// Sacar por pantalla los numeros pares hasta 200 inclusive
        
        string numStr = string.Empty;

        for (int i = 0; i <= 200; i++)
        {
            if (i % 2 == 0)
            {
                numStr += i.ToString() + ", ";
            }
        }
        Console.WriteLine(numStr);
        Console.WriteLine("\n");

        //***************
        /// Preparar un bucle que recorra los 51 primeros numeros enteros.
        /// En cada iteracion, sacará el numero en el que esté en ese momento por consola.
        /// Si el numero en el que está en ese momento es divisible por 3, 
        /// mostrar que esto ocurre por consola, además del número, y "saltarse" 4 números,
        /// es decir, los siguientes cuatro numeros enteros no se mostrarán.
        
        for (int i = 0; i < 51; i++)
        {
            Console.WriteLine("numero: " + i);
            if ((i % 3) == 0)
            {
                Console.WriteLine("Es divisible por 3");
                i += 3;
            }
        }

        Console.WriteLine("\n");

        //***************
        /// Generar un string a partir de unir el contenido de dos arrays de caracteres, 
        /// de igual longitud, uniendo las letras leyendo alternamente caracteres de uno y otro array.
        /// Si los arrays fueran [d,4,f] y [7,n,o] el string resultante sería "d74nfo"

        char[] arrChar1 = { 's', 'm', 's', 't', 'd', 'z', 'c', 'a', 'k'};
        char[] arrChar2 = { 'o', 'o', ' ', 'o', 'o', ' ', 'r', 'c', 's'};
        string strUnion = string.Empty;

        for (int i = 0; i < arrChar1.Length; i++)
        {
            strUnion += arrChar1[i];
            strUnion += arrChar2[i];
        }
        
        Console.WriteLine("cadena: " + strUnion);
        Console.WriteLine("\n");

        //***************
        /// Crear dos arrays de numeros enteros; uno de numeros mayores o iguales que 0
        /// y el otro con números enteros cualesquiera.
        /// Recorrer el array de numeros mayores o iguales que 0 y mostrar por pantalla la posicion del otro array
        /// que se corresponda con el valor de la posicion actual del array.
        /// Por ejemplo, si los arrays fueran [0,1,0,2] y [-3,142,243] saldría por pantalla "-3" y luego "142"
        /// luego otra vez "-3" y por último "243"
        
        int[] arrint1 = { 3, 0, 3, 15, 2, 5};
        int[] arrint2 = { -51, 562, 33, 204, -55, 46, -37, -98 };

        for (int i = 0;i < arrint1.Length; i++)
            if (arrint1[i] < arrint2.Length)
            {
                Console.WriteLine(arrint2[arrint1[i]]);
            }

        Console.WriteLine("\n");

        //***************
        /// Crear un array de caracteres del tamaño que se desee.
        /// Ir concatenando en una cadena de texto los caracteres mientras que en el 
        /// array de caracteres no se encuentre una z.
        /// Después de encontrar la z o si se acaba de recorrer el array, sacar
        /// la cadena por pantalla.
        
        strUnion = string.Empty;
        for (int i = 0; i < arrChar1.Length; i++)
        {
            if (arrChar1[i] == 'z')
            {
                break;
            }
            strUnion = strUnion + arrChar1[i];
        }

        Console.WriteLine("la cadena es: " + strUnion);
        Console.WriteLine("\n");

        //***************
        /// Crear un array de nombres y otros dos de apellidos.
        /// A partir de los dos arrays, formar "familias", esto es, a partir
        /// de cada uno de los nombres, generar todas las posibles combinaciones
        /// de dos apellidos y mostrarlas las combinaciones por pantalla.
        string[] arrNombres = {"Josue ", "Carlos "};
        string[] arrApellidos1 = { "Gomez ", "Gonzales ", "Gutierrez " };
        string[] arrApellidos2 = { "Blanco", "Leis", "Garcia" };
        string nombreCompleto = string.Empty;

        for (int i = 0; i < arrNombres.Length; i++)
        {
            for (int j = 0; j < arrApellidos1.Length; j++)
            {
                for(int k = 0; k <arrApellidos2.Length; k++ )
                {
                    nombreCompleto = arrNombres[i] + arrApellidos1[j] + arrApellidos2[k];
                    Console.WriteLine(nombreCompleto);
                }
            }
        }
        Console.WriteLine("\n");

        // Other solution. More clear and clean from my point of view.
        foreach (string name in arrNombres)
        {
            foreach(string apellido1 in arrApellidos1)
            {
                foreach(string apellido2 in arrApellidos2)
                {
                    Console.WriteLine(name + apellido1 + apellido2);
                }
            }
        }
        Console.WriteLine("\n");

        //***************
        /// Crear un array de numeros enteros.
        /// Crear una variable entera suma. 
        /// ir sumando los numeros del array hasta que la suma sea mayor que 20,
        /// entonces parar (no hay por que llegar a 20).
        /// Si el numero a sumar es un 3, no sumarlo.
        /// Si el numero a sumar es un 4, parar.
        /// Si no, sacar por pantalla la suma hasta ese momento en cada iteracion.
        int[] arrEnteros = { 1, -3, 12, 3, 3, 2, 4, 1 };
        int suma = 0;

        for (int i = 0; i < arrEnteros.Length; i++)
        {
            
            if (suma > 20 || arrEnteros[i] == 4)
            {
                break;
            }
            else if (arrEnteros[i] != 3)
            {
                suma += arrEnteros[i];
            }
            Console.WriteLine(suma);
        }
        Console.WriteLine("\n");
        
        //***************

    }
}
