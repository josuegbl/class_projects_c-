using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lesson_06_Functions;

public class Challenge_snake
{
    public static void Main(string[] args)
    {
        int width = 50;
        int height = 20;

        //board.drawBoard(width, height);
        board.ticks();
    }
}

public class snake
{

}

public class board
{
   public static void drawBoard(int width, int height)
    {
        for (int i = 0; i <= height; i++)
        {
            for (int j = 0; j <= width; j++)
            {
                if (i == 0 || i == height)
                {
                    Console.Write('-');
                }
                else if (j == 0 || j == width)
                {
                    Console.Write('|');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
    public static void ticks()
    {
        const long NSPerSecond = 10000000;
        long ticks;
        ticks = NSPerSecond / 5;                        // 5 Ticks per second
        DateTimeOffset dto = new DateTimeOffset( ticks, DateTimeOffset.Now.Offset);
        Console.WriteLine("There are {0:n0} ticks in {1}.", dto.Ticks, dto.ToString());
    }

}