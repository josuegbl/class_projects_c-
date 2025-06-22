using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05;

public class ejemploIf
{
    public static void Main(string[] args)
    {
        // Integrals
        byte Abyte = 1; //8 bits
        short aShort = 2; // 16 bits
        int aInt = 3; //32 bits
        long aLong = 4; // 64 bits 

        // Floating point
        float aFloat = 5.5F; // 32 bits
        double aDouble = 6.6; // 64 bits
        decimal aDecimal = 7.7M; // 128 bits

        // Text
        char aChart = 'a'; // 16 bits UNICODE
        string aString = "Josue";

        bool aBoolean = true; // 1 bit

        if (aShort > Abyte)
        {
            Console.WriteLine("aShort > Abyte");
        }

        if (aInt > Abyte)
        {
            if (aInt > Abyte)
            {
                Console.WriteLine("aInt > Abyte");
            }
        }

        // SWITCH
        switch (aChart)
        {
            case 'a':
                Console.WriteLine("es una vocal");
                break;
            case 'e':
                Console.WriteLine("es una vocal");
                break;
            case 'i':
                Console.WriteLine("es una vocal");
                break;
            case 'o':
                Console.WriteLine("es una vocal");
                break;
            case 'u':
                Console.WriteLine("es una vocal");
                break;
            default:
                Console.WriteLine("no es una vocal");
                break;


        }

    }
}

