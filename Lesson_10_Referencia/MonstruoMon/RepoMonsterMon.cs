using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public static class RepoMonsterMon
{
    const string MONSTERS_FILE = "monstersmon_repository.txt";

    private static Monstruomon getMonstermonFromDB(string[] monsterLine)
    {

        Console.WriteLine(monsterLine[4]);
        Element element = new Element(Enum.Parse<ElemenType>(monsterLine[4]));

        //Type type = Type.GetType(monsterLine[0]);

        //object instance = Activator.CreateInstance(type, new object[] { });

        //return instance;

        //TODO: Cambiar esto a algo más inteligente usando Type y CreateInstance

        switch (element.getElemenType())
        {
            case ElemenType.Agua:
                return new WaterMon(monsterLine[0]
                                  , int.Parse(monsterLine[1])
                                  , int.Parse(monsterLine[2])
                                  , int.Parse(monsterLine[3]));
            
            case ElemenType.Fuego:
                return new FireMon(monsterLine[0]
                                  , int.Parse(monsterLine[1])
                                  , int.Parse(monsterLine[2])
                                  , int.Parse(monsterLine[3]));
            
            case ElemenType.Tierra:
                return new EarthMon(monsterLine[0]
                                  , int.Parse(monsterLine[1])
                                  , int.Parse(monsterLine[2])
                                  , int.Parse(monsterLine[3]));
            
            case ElemenType.Rayo:
                return new LightningMon(monsterLine[0]
                                      , int.Parse(monsterLine[1])
                                      , int.Parse(monsterLine[2])
                                      , int.Parse(monsterLine[3]));

            default:
                return new WaterMon(monsterLine[0]
                                  , int.Parse(monsterLine[1])
                                  , int.Parse(monsterLine[2])
                                  , int.Parse(monsterLine[3]));
        }
    }

    public static List<Monstruomon> geMonstruomonList()
    {
        List<Monstruomon> monsters = new List<Monstruomon>();

        string[] monsterLines = File.ReadAllLines(MONSTERS_FILE);
        foreach (string line in monsterLines)
        {
            string lineNoSpace = line.Replace(" ", String.Empty);
            string[] monsterLine = lineNoSpace.Trim().Split(',');
            var monster = getMonstermonFromDB(monsterLine);

            List<Attack> attacks = MonstruomonService.getAttacksFromNames([monsterLine[5]
                                                                         , monsterLine[6]
                                                                         , monsterLine[7]]);
            foreach (Attack attack in attacks)
            {
                monster.setAttack(attack);
            }
            monsters.Add(monster);
        }
        return monsters;
    }



}
