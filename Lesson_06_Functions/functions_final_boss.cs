using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Channels;
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
/// . Si el color se corresponde con el de la combinación secreta en esa posicion,
/// aparecerá en las pistas para esa posición en verde.
/// . Si el color está en la combinación secreta, pero en otra posición, 
/// aparecerá en las pistas para esa posición en amarillo.
/// . Si un color no está ni en la posicíón ni en nunguna parte de la combinación,
/// aparecerá en rojo en las pistas.
/// . PISTA: recuerda que puedes crear arrays que contengan cualquier tipo 
/// válido del lenguaje.
/// . PISTA: existe  Console.ReadKey() y Consolekey.
/// . EXTRA: Realizar el juego pintando el tablero y la interfaz gráfica.
/// . EXTRA: Realizar el juego parametrizando el código de forma que se pueda 
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
        bool doPlay = true;
        do
        {
            functions_final_boss.masterMindMain(args);
            Console.Clear();
            Console.WriteLine("Do you want to play again?");
            string doPlayString = Console.ReadLine().ToUpper();
            if (doPlayString == "NO") doPlay = false;

        } while (doPlay);

    }

    public static void masterMindMain(string[] args)
    {
        int[] difficultyParameters = functions_final_boss.defineLevel();
        int[] secretColors = functions_final_boss.generateRandomColorNumbers(difficultyParameters[1]);

        //functions_final_boss.shoWinnerSeq(secretColors, difficultyParameters[1]);
        functions_final_boss.printBoard(difficultyParameters[0]);
        functions_final_boss.generateColorSelector(difficultyParameters[0], difficultyParameters[1]);
        bool userWin = functions_final_boss.rounds(difficultyParameters[0], difficultyParameters[1], secretColors);
        functions_final_boss.finalMsj(userWin);
    }

    public static int[] defineLevel()
    {
        int initRow = functions_final_boss.getInitialCoords()[0];
        int initCol = functions_final_boss.getInitialCoords()[1];
        int rounds = 0;
        int colors = 0;
        Console.SetCursorPosition(0, initRow);
        Console.WriteLine("Welcome to MASTERMIND");
        Console.WriteLine("Which level do you want to play, EASY, NORMAL or HARD?");
        string leveldefined = Console.ReadLine().ToUpper();
        Console.Clear();
        switch (leveldefined)
        {
            case "EASY":
                rounds = 8;
                colors = 2;
                break;
            case "NORMAL":
                rounds = 6;
                colors = 4;
                break;
            case "HARD":
                rounds = 4;
                colors = 6;
                break;
            default:
                rounds = 6;
                colors = 4;
                break;
        }
        return [rounds, colors];
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

    public static void printBoard(int chancesNumber)
    {
        int rows = functions_final_boss.getInitialCoords()[0];
        int cols = functions_final_boss.getInitialCoords()[1];
        Console.SetCursorPosition(cols, rows - 2);
        Console.WriteLine("MASTERMIND");
        Console.SetCursorPosition(cols, rows - 1);
        Console.WriteLine(functions_final_boss.getLevel(chancesNumber));


        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 2 * chancesNumber + 1; j++)
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

    public static void shoWinnerSeq(int[] secretColors, int level)
    {
        int currentRow = functions_final_boss.getInitialCoords()[0] - 3;
        int cols = functions_final_boss.getInitialCoords()[1];

        for (int i = 0; i < level; i++)
        {
            Console.SetCursorPosition(cols + 2 * i, currentRow);
            functions_final_boss.paintColorIcon(secretColors[i]);
        }
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

    public static bool rounds(int chances, int level, int[] secretColors)
    {
        bool userWin = false;
        for (int i = 0; i < chances; i++)
        {
            int[] userColorPicks = functions_final_boss.userRound(chances, level, i);
            int[] colorsChekout = functions_final_boss.evaluateUserGuess(secretColors, userColorPicks);
            functions_final_boss.paintCheckOut(colorsChekout, i);
            userWin = functions_final_boss.checkWin(colorsChekout);
            if (userWin)
            {
                i = chances;
            }
        }
        return userWin;
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
    public static int getColorCheckout(int index)
    {
        int[] colorPalete = [12, 14, 10];

        return colorPalete[index];
    }

    public static int[] getInitialCoords()
    {
        int rows = Console.WindowHeight/8;
        int cols = (Console.BufferWidth/2)-5;

        return [rows, cols];
    }

    public static void paintColorIcon(int colorNumber)
    {
        Console.ForegroundColor = (ConsoleColor)colorNumber;
        Console.Write("█");
        Console.ResetColor();
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

    public static int[] userRound(int chances, int level, int rowPos)
    {
        int initialRow = functions_final_boss.getInitialCoords()[0];
        int currentRow = initialRow + 2 * chances + 2;
        int cols = functions_final_boss.getInitialCoords()[1];
        int[] userColorPicks = new int[4];

        for (int j = 0; j < 4; j++)
        {
            Console.SetCursorPosition(cols, currentRow);
            Console.Write("color {0}", j+1);
            userColorPicks[j] = functions_final_boss.manualColorSelect(chances, level);
            Console.SetCursorPosition(cols + 2 * j + 1, initialRow + 2 * rowPos + 1);
            functions_final_boss.paintColorIcon(userColorPicks[j]);
        }
        return userColorPicks;
    }

    public static bool checkWin(int[] colorsChekout)
    {
        return (colorsChekout[0] == 10 
             && colorsChekout[1] == 10
             && colorsChekout[2] == 10 
             && colorsChekout[3] == 10);
    }

    public static int[] evaluateUserGuess(int[] hiddenColors, int[] userColors)
    {
        bool[] takenIndex = new bool[4];
        Array.Fill(takenIndex, false);
        int[] colorCheck = new int[userColors.Length];
        Array.Fill(colorCheck, functions_final_boss.getColorCheckout(0));

        for (int i = 0; i < userColors.Length; i++)
        {
            if (userColors[i] == hiddenColors[i])
            {
                takenIndex[i] = true;
                colorCheck[i] = functions_final_boss.getColorCheckout(2);
            }
        }

        if (!functions_final_boss.checkWin(colorCheck))
        {
            for (int i = 0; i < userColors.Length; i++)
            {
                for (int j = 0; j < hiddenColors.Length; j++)
                {
                    if (!takenIndex[j])
                    {
                        if (userColors[i] == hiddenColors[j])
                        {
                            takenIndex[j] = true;
                            colorCheck[i] = functions_final_boss.getColorCheckout(1);
                        }
                    }
                }

            }
        }

        return colorCheck;
    }

    public static void paintCheckOut(int[] colorCheckout, int roundNumber)
    {
        int currentRow = functions_final_boss.getInitialCoords()[0]+1;
        int cols = functions_final_boss.getInitialCoords()[1];

        for (int i = 0; i < 4; i++)
        {
            Console.SetCursorPosition(cols + 12 + 2*i, currentRow + 2 * roundNumber);
            functions_final_boss.paintColorIcon(colorCheckout[i]);
        }

    }

    public static void finalMsj(bool userWin)
    {
        int currentRow = functions_final_boss.getInitialCoords()[0];
        int cols = functions_final_boss.getInitialCoords()[1];
        Console.SetCursorPosition(cols, currentRow + 20);
        if (userWin)
        {
            
            Console.ForegroundColor = (ConsoleColor)functions_final_boss.getColorCheckout(2);
            Console.WriteLine("YOU WON! Congratulations!! ");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = (ConsoleColor)functions_final_boss.getColorCheckout(0);
            Console.WriteLine("GAME OVER");
            Console.SetCursorPosition(cols, currentRow + 21);
            Console.WriteLine("You lost!");
            Console.ResetColor();
        }
        Thread.Sleep(2000);
    }

    public static string getLevel(int chances)
    {
        string levelString = "";
        switch (chances)
        {
            case 4:
                levelString = "Level: HARD";
                break;
            case 6:
                levelString = "Level: NORMAL";
                break;
            case 8:
                levelString = "Level: EASY";
                break;
        }
        return levelString;
    }
}
