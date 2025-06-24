using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Functions;

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
public class functions_final_boss
{
    public static void Main(string[] args)
    {
        functions_final_boss.masterMindMain(args);
    }

    public static void masterMindMain(string[] args)
    {
        int chances = 4;
        int level = 4;
        int[] secretColors = functions_final_boss.generateRandomColorNumbers(chances);

        functions_final_boss.drawBoard(chances);
        functions_final_boss.generateColorSelector(chances, level);
        functions_final_boss.userRounds(chances, level);
    }

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

    public static int[] generateRandomColorNumbers(int dificultyLevel)
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

    public static void paintColorIcon(int colorNumber)
    {
        Console.ForegroundColor = (ConsoleColor)colorNumber;
        Console.Write("█");
        Console.ResetColor();
    }

    public static void generateColorSelector(int chancesNumber, int level)
    {
        int[] colorNumbers = functions_final_boss.getColorPalete(level);
        int currentRow = functions_final_boss.getInitialCoords()[0] + 2 * chancesNumber + 4;
        int cols = functions_final_boss.getInitialCoords()[1];

        for (int i = 0; i < level; i++)
        {
            Console.SetCursorPosition(cols + 2*i, currentRow);
            functions_final_boss.paintColorIcon(colorNumbers[i]);
        }
    }

    public static int manualColorSelect(int chancesNumber, int level)
    {
        int[] colorNumbers = functions_final_boss.getColorPalete(level);
        int currentRow = functions_final_boss.getInitialCoords()[0] + 2 * chancesNumber + 5;
        int cols = functions_final_boss.getInitialCoords()[1];
        int leftCorner = functions_final_boss.getInitialCoords()[1];
        int rigthCorner = leftCorner + 2 * (level - 1);

        Console.SetCursorPosition(cols, currentRow);
        Console.Write("*");

        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (cols > leftCorner)
                {
                    Console.SetCursorPosition(cols, currentRow);
                    Console.Write(" ");
                    cols -= 2;
                }
                Console.SetCursorPosition(cols, currentRow);
                Console.Write("*");

            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (cols < rigthCorner)
                {
                    Console.SetCursorPosition(cols, currentRow);
                    Console.Write(" ");
                    cols += 2;
                }
                Console.SetCursorPosition(cols, currentRow);
                Console.Write("*");
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(cols, currentRow);
                Console.Write(" ");
                break;
            }
        } while (!Console.KeyAvailable);
        return colorNumbers[(cols - leftCorner) / 2];
    }

    public static void userRounds(int chances, int level)
    {
        int initialRow = functions_final_boss.getInitialCoords()[0];
        int currentRow = initialRow + 2 * chances + 2;
        int cols = functions_final_boss.getInitialCoords()[1];
        Console.SetCursorPosition(cols, currentRow);

        for (int i = 0; i < chances; i++)
        {

            for (int j = 0; j < 4; j++)
            {
                Console.SetCursorPosition(cols, currentRow);
                Console.Write("color {0}", j+1);
                int colorNumber = functions_final_boss.manualColorSelect(chances, level);
                Console.SetCursorPosition(cols + 2 * j + 1, initialRow + 2* i + 1);
                functions_final_boss.paintColorIcon(colorNumber);
            }
        }
    }

    public static void checkUserResponse(int[] secretColors, int[] userColors)
    {

    }


}
