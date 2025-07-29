using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public static class RepoAttack
{
    const string ATTACKS_FILE = "attacks_repository.txt";

    private static Attack getAttackFromDB(string line)
    {
        string[] atckLine = line.Trim().Split(',');

        Element element = new Element(Enum.Parse<ElemenType>(atckLine[2]));

        return new Attack(atckLine[0], int.Parse(atckLine[1]), element);
    }

    public static List<Attack> getAttackList()
    {
        List<Attack> attacks = new List<Attack>();

        string[] AttackLines = File.ReadAllLines(ATTACKS_FILE);
        foreach (string line in AttackLines)
        {
            attacks.Add(getAttackFromDB(line));
        }
        return attacks;
    }

    //TODO: implement if necessary
    private static void writAttackToDB(Attack attack)
    {
        Console.WriteLine("To implement");
    }

    //TODO: implement if necessary
    public static void writeAttackListToDB(List<Attack> attackList)
    {
        Console.WriteLine("To implement");
    }
}
