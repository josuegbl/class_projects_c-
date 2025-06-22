using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class ejercicios_arr_bucles_3
{
    public static void Main(string[] args)
    {
        /// Crear un array de carcteres de al menos 10 caracteres.
        /// Crear un array de numeros, de la misma longitud que el de caracteres.
        /// Crear 3 string vacios.
        /// Crear un numero entero y asignarle un valor.
        /// Recorrer los arrays de caracteres y numeros. Si el nuemero que hay en el 
        /// array de numeros es menor que el numero entero "suelto", añadir el
        /// carcter de la posicion actual del array de caracteres al primer string;
        /// en el caso de que el nuemro sea igual que al "suelto", añadir el caracter al
        /// segundo string y añadir el caracter al tercer string en el caso de que el
        /// numero sea mayor.
        /// Sacar por pantalla las 3 cadenas resultantes.
        
        char[] arrChar1 = { 'u', 'n', 'a', 'c', 'o', 's', 'a', 'q', 'u', 'i'};
        int[] arrInt1 = {2, 6, 21, 5, 7, 2, 3, 6, 5, 6};
        string strMenor = "";
        string strIgual = "";
        string strMayor = "";
        int numero = 5;

        for (int i = 0; i < arrChar1.Length; i++)
        {
            if (arrInt1[i] < numero)
            {
                strMenor += arrChar1[i];
            }
            else if (arrInt1[i] == numero)
            {
                strIgual += arrChar1[i];
            }
            else
            {
                strMayor += arrChar1[i];
            }
        }
        Console.WriteLine(strMenor + ", " + strIgual + ", " + strMayor);
        Console.WriteLine("\n");

        //***************
        /// Almacenar una frase, sin espacios, en un array de caracteres en minusculas.
        /// Comprobar si la frase es un palindromo o no, esto es, que se lea igual de 
        /// izquierda a derecha que de derecha a izquierda.
        char[] arrCharPalin = {'s', 'o', 'm', 'o', 's', 'o', 'n', 'o', 's', 'o', 'm', 'o', 's'};
        string phrasePalindro1 = "";
        string phrasePalindro2 = "";
        int j = 0;

        for (int i = 0; i < arrCharPalin.Length; i++)
        {
            j = arrCharPalin.Length - i - 1;
            phrasePalindro1 += arrCharPalin[i];
            phrasePalindro2 += arrCharPalin[j];
        }
        if (phrasePalindro1 == phrasePalindro2)
        {
            Console.WriteLine("Es palindromo.");
        }
        else
        {
            Console.WriteLine("No es palindromo.");
        }

        Console.WriteLine("\n");

        // other way around

        int lengthArr = arrCharPalin.Length;
        bool isPalindrome = true;
        

        for (int i = 0, k = lengthArr-1; i < lengthArr/2; i++, k--)
        {
            if (arrCharPalin[i] != arrCharPalin[k])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Es palindromo.");
        }
        else
        {
            Console.WriteLine("No es palindromo.");
        }
        Console.WriteLine("\n");

        //***************



        /// Refactorizar el algoritmo anterior para que permita comprobar si una frase 
        /// es palindromo o no en un array de caracteres con espacios permitidos
        /// para formar la frase "real" (real = con espacios) 
        char[] arrCharPalinSpaces = { 's', 'o', 'm', 'o', 's',' ', ' ', 'o', ' ','n', 'o', ' ', 's', 'o', 'm', 'o', 's' };
        phrasePalindro1 = "";
        phrasePalindro2 = "";
        for (int i = 0; i < arrCharPalinSpaces.Length; i++)
        {
             j = arrCharPalinSpaces.Length - i - 1;
            if (arrCharPalinSpaces[i] != ' ')
            {
                phrasePalindro1 += arrCharPalinSpaces[i];
            }
            if (arrCharPalinSpaces[j] != ' ')
            {
                phrasePalindro2 += arrCharPalinSpaces[j];
            }
        }
        if (phrasePalindro1 == phrasePalindro2)
        {
            Console.WriteLine("Es palindromo.");
        }
        else
        {
            Console.WriteLine("No es palindromo.");
        }
        Console.WriteLine("\n");

        //other way around
        lengthArr = arrCharPalinSpaces.Length;
        isPalindrome = true;

        for (int i = 0, k = lengthArr - 1; i < lengthArr / 2; i++, k--)
        {
            if (arrCharPalinSpaces[i] == ' ')
            {
                k += 1;
                continue;
            }

            if (arrCharPalinSpaces[k] == ' ')
            {
                i -= 1;
                continue;
            }

            if (arrCharPalinSpaces[i] != arrCharPalinSpaces[k])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Es palindromo.");
        }
        else
        {
            Console.WriteLine("No es palindromo.");
        }
        Console.WriteLine("\n");

    }
}
