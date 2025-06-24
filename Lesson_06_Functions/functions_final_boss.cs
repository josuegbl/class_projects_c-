using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Functions;

public class functions_final_boss
{
    public static void Main(string[] args)
    {
        int chances = 2;
        int level = 4;
        functions_final_boss.drawBoard(chances);
        functions_final_boss.generateColorSelector(chances, level);
        functions_final_boss.selectColor(chances, level);
    }
    /// Hacer el juego Mastermind.
    /// . El juego de Mastermind consiste en adivinar una combinación secreta de 
    /// 4 colores seleccionada al azar.
    /// . De la combinacion se habrá de adivinar tanto el color como posicion.
    /// . Los colores posibles de la combinacion son: Verde, Amarillo, Rojo y Azul
    /// . Habrá un máximo de 6 intentos para averiguar la combinacion secreta.
    /// . Si se adivina la combinacion antes de que se pasen los 6 intentos, se gana el juego.
    /// . Si se agotan los intentos y no se ha adivinado la combinación, se pierde el juego.
    /// . Tras cada intento, el sistema mostrará pistas de la combinacion.
    /// . Si el color se correcponde con el de la combinación secreta en esa posicion,
    /// aparecerá en las pistas para esa posición en verde.
    /// . Si el color está en la combinación secreta, pero en otra posición, 
    /// aparecerá en las pistas para esa posición en amarillo.
    /// . Si un color no está ni en la posicíón ni en nunguna parte de la combinación,
    /// aparecerá en rojo en las pistas.
    /// . PISTA: recuerda que puedes crear arrays que contengan cualquier tipo 
    /// válido del lenguaje.
    /// . PISTA: existe  Console.ReadKey() y Consolekey.
    /// . EXTRA: Realizar el juego pintando el tablero y la interfaz gráfica.
    /// . EXTRA: Realizar el juego parametrizando el cófigo de forma que se pueda 
    /// poner un selector de dificultad al principio (en el propio código). Este
    /// selector permitirá elegir entre dificultad fácil, normal y díficil. En
    /// normal, el juego se mantiene igual; en fácil solo hay 2 colores posibles
    /// en la combinación secreta y 8 intentos para averiguarla, en díficil hay 
    /// 6 colores posibles en la combinación secreta y 4 intentos para averiguarla.
    /// . EXTRA: Realizar de forma distinta la comprobación de si el color está en 
    /// la combinación secreta pero no está en la posición. Se puede comprobar de 
    /// forma más precisa en base al número de veces que se repite el color en la 
    /// combinación secreta y cuantas veces se ha puesto en la combinación secreta.

    public static int[] getColorPalete(int dificultyLevel)
    // dificultyLevel is 2, 4 or 6.
    {
        int[] colorPalete =  [9, 12, 10, 14, 13, 11];
        int[] colorNumbers = new int[dificultyLevel];

        for (int i = 0; i < dificultyLevel; i++)
        {
            colorNumbers[i] = colorPalete[i];
        }
        return colorNumbers;

    }

    public static int[] getRandomColorNumbers(int dificultyLevel)
    {
        Random randomValue = new Random();
        int[] randomColor = new int[4];
        int[] colorNumber = functions_final_boss.getColorPalete(dificultyLevel);

        for (int i = 0; i < 4; i++)
        {
            randomColor[i] = colorNumber[randomValue.Next(0, dificultyLevel)];
        }
        return randomColor;
    }

    public static string getColor(int colorNumber)
    {
        switch (colorNumber)
        {
            case 9:
                return "BLUE";
                break;
            case 10:
                return "GREEN";
                break;
            case 11:
                return "CYAN";
                break;
            case 12:
                return "RED";
                break;
            case 13:
                return "MAGENTA";
                break;
            case 14:
                return "YELLOW";
                break;
            default:
                return "BLUE";
        }
    }

    public static int getColorNumber(string color)
    {
        switch (color)
        {
            case "BLUE":
                return 9;
                break;
            case "GREEN":
                return 10;
                break;
            case "CYAN":
                return 11;
                break;
            case "RED":
                return 12;
                break;
            case "MAGENTA":
                return 13;
                break;
            case "YELLOW":
                return 14;
                break;
            default:
                return 9;
        }
    }

    public static int[] getInitialCoords()
    {
        int rows = Console.BufferHeight/8;
        int cols = (Console.BufferWidth/2)-5;

        return [rows, cols];
    }
    public static void drawBoard(int chancesNumber)
    {
        int rows = functions_final_boss.getInitialCoords()[0];
        int cols = functions_final_boss.getInitialCoords()[1];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 2*chancesNumber+1; j++)
            {
                Console.SetCursorPosition(cols + i, rows + j);
                if (j % 2 == 0)
                {
                    Console.Write("-");
                }
                else if (i % 2 == 0)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("░");
                    Console.ResetColor();
                }

            }
        }
    }

    public static void generateColorSelector(int chancesNumber, int dificultyLevel)
    {
        int[] colorNumbers = functions_final_boss.getColorPalete(dificultyLevel);
        int rows = functions_final_boss.getInitialCoords()[0];
        int cols = functions_final_boss.getInitialCoords()[1];

        for (int i = 0; i < dificultyLevel; i++)
        {
            Console.SetCursorPosition(cols + 2*i, rows + 2 * chancesNumber + 2);
            Console.ForegroundColor = (ConsoleColor)colorNumbers[i];
            Console.Write("█");
            Console.ResetColor();
        }
    }

    public static void selectColor(int chancesNumber, int dificultyLevel)
    {
        int[] colorNumbers = functions_final_boss.getColorPalete(dificultyLevel);
        int rows = functions_final_boss.getInitialCoords()[0];
        int cols = functions_final_boss.getInitialCoords()[1];
            Console.SetCursorPosition(cols, rows + 2 * chancesNumber + 3);
            Console.Write("*");

        ConsoleKeyInfo keyInfo = Console.ReadKey(false);

        //Console.KeyAvailable
        if (keyInfo.Key == ConsoleKey.LeftArrow)
        {
            Console.SetCursorPosition(cols, rows + 2 * chancesNumber + 3);
            Console.Write(" ");
            cols -= 2;
            Console.SetCursorPosition(cols, rows + 2 * chancesNumber + 3);
            Console.Write("*");

        }
        else if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            Console.SetCursorPosition(cols, rows + 2 * chancesNumber + 3);
            Console.Write(" ");
            cols += 2;
            Console.SetCursorPosition(cols, rows + 2 * chancesNumber + 3);
            Console.Write("*");
        }

        do
        {
            Console.WriteLine("Press 'x' to stop!");
            Thread.Sleep(10);
            Console.Clear();
        } while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.X));


        //if (!Console.ReadKey().Equals())
        //    {

        //        if(Console.ReadKey().Key == ConsoleKey.LeftArrow)
        //        {
        //            Console.SetCursorPosition(cols, rows + 2 * chancesNumber + 3);
        //            Console.Write(" ");
        //            cols -= 2;
        //            Console.SetCursorPosition(cols, rows + 2 * chancesNumber + 3);
        //            Console.Write("*");

        //        }

        //        if (Console.ReadKey().Key == ConsoleKey.RightArrow)
        //    }






    }

}
