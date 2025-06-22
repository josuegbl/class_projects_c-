using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_Functions;

public class functions_lesson_7
{
    public static void Main(string[] args)
    {
        bool doPlay = true;
        do
        {
            Console.WriteLine("How many rounds you want to play?");
            int rounds = int.Parse(Console.ReadLine());
            functions_lesson_7.simonMain(rounds);
            Console.WriteLine("Do you want to play again?");
            string doPlayString = Console.ReadLine().ToUpper();
            if (doPlayString == "NO") doPlay = false;

         } while (doPlay);

    }

    /// Hac>er el juego de Simon
    /// El juego consiste en mostrar una sucesion de colores por consola,
    /// elegidos al azar, que habrá que recordar e introducir en orden.
    /// Los colores posibles son: rojo, amarillo, verde y azul.
    /// Se empezará teniendo que recordar un color. Si se recuerda correctamente,
    /// el juego continúa; si no, el juego termina.
    /// El juego continuará aumentando el número de colores a recordar en uno.
    /// La secuencia a recordar será de seis. Si se aciertan seis, el juego 
    /// se gana y termina.
    /// Se mostrarán los colores a recordar uno detrás de otro (no a la vez),
    /// dejando un espacio de tiempo entre un color y otro.
    /// Usar las funciones de color de la consola para "pintar" del color apropiado el color.
    /// Esto es, si aparece "VERDE" como color a recordar, que el color de los caracteres
    /// sea verde.
    /// EXTRA: Hacer un selector de dificultad, que aumente el número de turnos a recordar y/o
    /// añada más colores posibles para tener que recordar.
    
    public static int[] getRandomColorNumbers(int maxRounds)
    {
        Random randomValue = new Random();
        int[] randomColor = new int[maxRounds];
        int[] colorNumber = [9, 10, 12, 14];

        for (int i = 0; i < maxRounds; i++)
        {
            randomColor[i] = colorNumber[randomValue.Next(0, 4)];
        }
        return randomColor;
    }

    public static string getColor(int colorNumber)
    {
        switch (colorNumber)
        {
            case 9:
                return "AZUL";
                break;
            case 10:
                return "VERDE";
                break;
            case 12:
                return "ROJO";
                break;
            case 14:
                return "AMARILLO";
                break;
            default:
                return "AZUL";
        }
    }

    public static int getColorNumber(string color)
    {
        switch (color)
        {
            case "AZUL":
                return 9;
                break;
            case "VERDE":
                return 10;
                break;
            case "ROJO":
                return 12;
                break;
            case "AMARILLO":
                return 14;
                break;
            default:
                return 9;
        }
    }

    public static void getChallengeRound(int[] randomColorNumbers, int rounds)
    {
        for (int i = 1; i <= rounds; i++)
        {
            Console.Clear();
            int colorNumber = randomColorNumbers[i - 1];
            string color = functions_lesson_7.getColor(colorNumber);
            Console.WriteLine("color {0}", i);
            Console.ForegroundColor = (ConsoleColor)colorNumber;
            Console.WriteLine(color);
            Thread.Sleep(1000);
            Console.ResetColor();
        }
        Console.Clear();
    }

    public static bool getUserResponseAndCheck(int[] randomColorNumbers, int rounds)
    {
        bool userSuccess = true;
        Console.WriteLine("Escriba los colores en el orden que han aparecido: ");
        for (int i = 0; i < rounds; i++)
        {
            string userColor = Console.ReadLine();
            userSuccess = functions_lesson_7.isUserSuccess(userColor, randomColorNumbers[i]);
            if (!userSuccess)
            {
                break;
            }
        }
        return userSuccess;
    }

    public static bool isUserSuccess(string userColor, int aiColorNumber)
    { 
        bool isSuccess = true;
        string aiColor = functions_lesson_7.getColor(aiColorNumber);
        if (userColor.ToUpper() != aiColor)
        {
            isSuccess = false;
        }

        return isSuccess;
    }

    public static void simonMain(int maxRounds)
    {
        bool isUserSuccess = true;
        int[] randomColorNumbers = functions_lesson_7.getRandomColorNumbers(maxRounds);
        for (int i = 1; i <= maxRounds; i++)
        {
            functions_lesson_7.getChallengeRound(randomColorNumbers, i);
            
            isUserSuccess = functions_lesson_7.getUserResponseAndCheck(randomColorNumbers, i);
            Console.Clear();
            if (!isUserSuccess)
            {
                break;
            }
        }

        if (isUserSuccess)
        {
            Console.WriteLine("Congratulations!!");
            Console.WriteLine("GAME OVER");
        }
        else
        {
            Console.WriteLine("Sorry, You have failed! :( ");
            Console.WriteLine("GAME OVER");
        }
    }
}
