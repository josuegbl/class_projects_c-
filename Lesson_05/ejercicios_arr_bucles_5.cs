using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class ejercicios_arr_bucles_5
{
    public static void Main(string[] args)
    {

        /// Generar (a mano) un array de enteros que contenga los numeros naturales (del 0
        /// al 9), consecutivos, peros desordenados. Recorrer el array gasta "encontrar y
        /// sacar" por pantalla todos los números en orden.
        int[] arrDesordenado = {3,7,1,0,6,2,5,9,4,8};
        int minValuePrinted = -1;

        for (int i=0; i < 10; i++)
        {   
            int minValue = 10;
            
            for (int j=0; j < arrDesordenado.Length; j++)
            {
                int value = arrDesordenado[j];
                if (value < minValue && value > minValuePrinted)
                {
                    minValue = value;
                }
            }
            minValuePrinted = minValue;
            Console.Write(minValuePrinted);
        }
        Console.WriteLine("\n");

        //***************
        /// 3 in random. Generar un juego de 3 en raya con los siguientes requisitos:
        /// Habrá dos "fichas", una X y una O.
        /// Empezará siempre la X.
        /// En cada "turno" se pondrá una "ficha" apropiada en un lugar del "tablero".
        /// La "ficha" se pondrá en un lugar al azar del "tablero".
        /// El "tablero" de juego tendrá unas dimensiones de 3x3 "fichas".
        /// Una vez el "tablero" esté lleno de fichas, el juego terminará.
        /// No hay que controlar, ni durante la partida ni al final, si alguien gana o pierde.
        /// Tras cada "turno" mostrar cómo está el tablero
        /// NOTA: mirar cómo generar un núemro aleatorio para conseguir el objetivo.
        Random random = new Random();
        string[,] board = { {" "," "," "}, {" "," ","" }, {" "," "," "} };
        bool isCross = true;

        for (int i=0; i<9; i++)
        {
            int filasRandom = random.Next(0, 3);
            int colsRandom = random.Next(0, 3);
            if (board[filasRandom,colsRandom] == "X" || board[filasRandom, colsRandom] == "O")
            {
                i--;
                continue;
            }
            else
            {
                if(isCross)
                {
                    board[filasRandom, colsRandom] = "X";
                }
                else
                {
                    board[filasRandom, colsRandom] = "O";
                }
                isCross = !isCross;
            }
                Console.WriteLine("Turno " + (i+1));
                for (int k = 0; k < 3; k++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        Console.Write(board[k, l]);
                    }
                    Console.WriteLine();
                }
            // Check if there is a winner
            if (i >= 4)
            {
                bool validateDiagonal1 = (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != " ");
                bool validateRows1 = (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != " ");
                bool validateRows2 = (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != " ");
                bool validateRows3 = (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != " ");

                if (validateRows1 || validateRows2 || validateRows3 || validateDiagonal1)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Ha Ganado X :D");
                    }
                    else
                    {
                        Console.WriteLine("Ha Ganado O :D");
                    }
                    break;
                }

                string[,] boardRot90 = { { " ", " ", " " }, { " ", " ", "" }, { " ", " ", " " } };

                for (int l=0; l<3; l++)
                {
                    for (int m=0; m<3; m++)
                    {
                        boardRot90[m, 2 - l] = board[l, m];
                    }
                }

                validateDiagonal1 = (boardRot90[0, 0] == boardRot90[1, 1] && boardRot90[1, 1] == boardRot90[2, 2] && boardRot90[0, 0] != " ");
                validateRows1 = (boardRot90[0, 0] == boardRot90[0, 1] && boardRot90[0, 1] == boardRot90[0, 2] && boardRot90[0, 0] != " ");
                validateRows2 = (boardRot90[1, 0] == boardRot90[1, 1] && boardRot90[1, 1] == boardRot90[1, 2] && boardRot90[1, 0] != " ");
                validateRows3 = (boardRot90[2, 0] == boardRot90[2, 1] && boardRot90[2, 1] == boardRot90[2, 2] && boardRot90[2, 0] != " ");
                if (validateRows1 || validateRows2 || validateRows3 || validateDiagonal1)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Ha Ganado X :D");
                    }
                    else
                    {
                        Console.WriteLine("Ha Ganado O :D");
                    }
                    break;
                }
            }

        }
        Console.WriteLine("\n");

        //***************
        /// Matrix. Generar un efecto pantalla que se parezca a la "emision sin filtro"
        /// de la película Matrix, esto es, "cascadas" de números en puntos aleatorios 
        /// de la pantalla. Es también válido un efecto "dispersión" de números
        /// en puntos al azar de la consola. Buscar un efecto lo más fidedigno que se consiga.
        /// NOTA: estudia la documentación de la consola "clear", "SetCursorPosition", 
        /// "ResetColor", "foregroundColor".
        int col = 0;
        int row = 0;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        while (true)
        {
            int colRand = random.Next(0, Console.WindowWidth);
            int rowRand = random.Next(0, Console.WindowHeight);

            for (int i = 0; i < 10; i++)
            {


                col = colRand;
                row = rowRand + i;
                if (row >= Console.WindowHeight - 1)
                {
                    rowRand = random.Next(0, Console.WindowHeight);
                    i--;
                    continue;
                }
                Console.SetCursorPosition(col, row);
                Thread.Sleep(40);
                //for (int a=0; a < 15000000; a++);
                Console.Write(random.Next(0, 10));
            }
        }

        Console.WriteLine("\n");

        //***************


    }
}
