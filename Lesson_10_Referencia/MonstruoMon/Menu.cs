using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class Menu
{
    private ConsolePosition position;
    private int option;

    public Menu()
    {
        this.position = new ConsolePosition();
        this.option = 0;
    }

    public void printMenu()
    {
        getMainMenu();
        selector(3, -7);
    }
    public void printPickMonstermonMenu(string[] monsterList)
    {
        getPickMonstermonMenu(monsterList);
        selector(monsterList.Length, -2);
    }

    private void getPickMonstermonMenu(string[] monsterList)
    {
        Console.Clear();
        this.position = ConsolePosition.defaultConsolePosition();
        Console.WriteLine("Seleccione su Monstruomon");
        position.shiftPosition(0, 1);

        foreach (string monsterString in monsterList)
        {
            position.shiftPosition(0, 1);
            Console.Write(monsterString);
        }

    }

    public void setOption(int option)
    {
        this.option = option;
    }
    public int getOption()
    {
        return this.option;
    }

    private void getMainMenu()
    {
        Console.Clear();
        Console.ResetColor();
        this.position = ConsolePosition.defaultConsolePosition();
        Console.Write("MONSTERMON");

        this.position.shiftPosition(-5, 2);
        Console.Write("¡Al campo de batalla!");

        this.position.shiftPosition(0, 1);
        Console.Write("Crear un Monstruomon");

        this.position.shiftPosition(0, 1);
        Console.Write("Salir");
    }

    public void printBattleMenu(string[] pMonster, string[] AIMonster)
    {
        Console.Clear();
        this.position = ConsolePosition.defaultConsolePosition();
        Console.Write("Batalla!");

        this.position.shiftPosition(-17, 0);
        monsterScreen(pMonster);

        this.position.shiftPosition(30, -11);
        monsterScreen(AIMonster);
    }

    private void monsterScreen(string[] monster)
    {
        for (int i = 0; i < monster.Length; i++)
        {
            if (i == 5)
            {
                this.position.shiftPosition(0, 2);
                Console.Write("Ataques");
                this.position.shiftPosition(0, 1);
            }
            this.position.shiftPosition(0, 1);
            Console.Write(monster[i]);
        }
    }

    public void selector(int maxTop, int left=-2, int defTop = 1)
    {
        ConsolePosition defaultObjPos = ConsolePosition.defaultConsolePosition();

        int top = defaultObjPos.getPosition()[1];

        this.position = defaultObjPos;
        this.position.shiftPosition(left, defTop + 1);

        Console.Write("█");
        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(false);

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (this.position.getPosition()[1] > top + defTop + 1)
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

                if (this.position.getPosition()[1] < top + defTop + maxTop)
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
        this.option = this.position.getPosition()[1] - top - defTop - 1;
    }

    internal void defenderLost(string defender, bool AIwon)
    {
        this.position = new ConsolePosition();
        this.position.shiftPosition(-8, 12);
        Console.Write(defender + " ha perdido!");
        this.position.shiftPosition(0, 1);
        if (AIwon)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Te ha ganado la AI");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Has ganado a la AI");
        }
        Thread.Sleep(2000);
    }
}
