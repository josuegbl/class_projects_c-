using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class Selector
{
    private ConsolePosition position;
    private int option;

    public Selector()
    {
        this.position = new ConsolePosition();
        this.option = 0;
    }

    public int getOption()
    {
        return this.option;
    }

    public void horizontalSelector(int maxLeft)
    {
        ConsolePosition defaultObjPos = ConsolePosition.defaultConsolePosition();

        int left = defaultObjPos.getPosition()[0];

        this.position = defaultObjPos;
        this.position.shiftPosition(-2, 2);

        Console.Write("█");

        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (this.position.getPosition()[0] > left + 2)
                {
                    this.position.setCursorPosition();
                    Console.Write(" ");
                    this.position.shiftPosition(-1, 0);
                }
                this.position.setCursorPosition();
                Console.Write("█");

            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (this.position.getPosition()[0] < left + maxLeft)
                {
                    this.position.setCursorPosition();
                    Console.Write(" ");
                    this.position.shiftPosition(1, 0);
                }
                this.position.setCursorPosition();
                Console.Write("█");
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                break;
            }
        } while (!Console.KeyAvailable);
        this.option = this.position.getPosition()[1] - left - 2;
    }

    public void verticalSelector(int maxTop)
    {
        ConsolePosition defaultObjPos = ConsolePosition.defaultConsolePosition();

        int top = defaultObjPos.getPosition()[1];

        this.position = defaultObjPos;
        this.position.shiftPosition(-2, 2);

        Console.Write("█");

        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (this.position.getPosition()[1] > top + 2)
                {
                    this.position.setCursorPosition();
                    Console.Write(" ");
                    this.position.shiftPosition(0, -1);
                }
                this.position.setCursorPosition();
                Console.Write("█");

            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (this.position.getPosition()[1] < top + maxTop)
                {
                    this.position.setCursorPosition();
                    Console.Write(" ");
                    this.position.shiftPosition(0, 1);
                }
                this.position.setCursorPosition();
                Console.Write("█");
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                break;
            }
        } while (!Console.KeyAvailable);
        this.option = this.position.getPosition()[1] - top - 2;
    }
}
