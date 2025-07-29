using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class EarthMon : Monstruomon
{
    public EarthMon(string name, int health, int strength, int defense)
        : base(name, health, strength, defense, new Element(ElemenType.Tierra))
    {
    }

    public EarthMon(string name, int health, int strength, int defense, List<Attack> attacks)
        : base(name, health, strength, defense, new Element(ElemenType.Tierra), attacks)
    {
    }

    //public virtual object Clone()
    //{
    //    return new EarthMon(name, health, strength, defense, attacks);
    //}

    public override void setAttack(Attack attack)
    {

        if (attack.getElemenType() == ElemenType.Tierra || attack.getElemenType() == ElemenType.Neutral)
        {
            this.attacks.Add(attack);
        }
        else
        {
            try
            {
                throw new Exception(
                    $"Este ataque no es de {ElemenType.Tierra}" +
                    $" o {ElemenType.Neutral}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Por favor, escoja un ataque compatible.");
            }
        }
    }
}
