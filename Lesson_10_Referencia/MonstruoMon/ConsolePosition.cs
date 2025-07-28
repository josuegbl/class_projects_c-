using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class ConsolePosition
{
    private int top;
    private int left;

    public ConsolePosition()
    {
        this.top = Console.WindowHeight / 6;
        this.left = Console.WindowWidth / 2 - 12;
        this.setCursorPosition();
    }

    public static ConsolePosition defaultConsolePosition()
    {
        return new ConsolePosition();
    }

    public void setCursorPosition()
    {
        Console.SetCursorPosition(this.left, this.top);
    }

    public void shiftPosition(int left, int top)
    {
        this.left += left;
        this.top += top;
        this.setCursorPosition();
    }

    public void setPosition(int left, int top)
    {
        this.left = left;
        this.top = top;
    }

    public int[] getPosition()
    {
        return [this.left, this.top];
    }

}
