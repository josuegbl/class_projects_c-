using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class ejercicios_arr_bucles_4
{
    public static void Main(string[] args)
    {
        /// Crear un algoritmo para que, utilizando @ impresas por consola,
        /// aparezca  en consola un rectangulo o cuadrado de "alto" indicado
        /// por un número entero (maximo2 0) y "ancho" indicado por otro número
        /// entero (maximo 40)
        int alto = 11;
        int ancho = 25;

        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write("@");
                
            }
            Console.WriteLine();
        }


        Console.WriteLine("\n");

        //***************
        /// Partiendo del ejercicio anterior generar un figura similar, pero 
        /// haciendo que el interior quede vacío, lleno de espacios en blanco.
        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                if (i == 0 || i == alto-1 || j == 0 || j == ancho-1)
                    Console.Write("@");
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }

        Console.WriteLine("\n");

        //***************
        /// Partiendo del ejercicio anterior, con un alto de 10 y un ancho de 
        /// 25, generar una figura similar, pero haciendo que en este caso el
        /// "interior" quede relleno con un aspa o X. Este aspa tendrá dos
        /// líneas: una que partirá del extremo superior izquierdo de la
        /// figura, hasta su extremo inferior derecho y otra que partirá desde
        /// su extremo superior derecho hasta su extremo inferior izquierdo. 
        /// En este caso, los bordes de la figura también quedarán impresos 
        /// con @ y toda la parte del interior que no forme parte del aspa estará
        /// rellena de espacios en blanco.
        /// NOTA: No tiene que quedar perfecta, pero sí aproximada.
        for (int i = 0; i < alto; i++)
        {   
            for (int j = 0; j < ancho; j++)
            {
                int val1 = (i * (ancho+3) / alto);
                int val2 =  ancho - (i * (ancho+3) / alto);

                if (i == 0 || i == alto - 1 || j == 0 || j == ancho - 1 || j == val1 || j == val2)
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }
    }
}
