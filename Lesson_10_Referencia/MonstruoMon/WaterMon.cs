using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class WaterMon : Monstruomon
{
    public WaterMon(string name, int health, int strength, int defense) 
    {
        this.name = name;
        this.health = health;
        this.strength = strength;
        this.defense = defense;
        this.element = new Element(ElemenType.Agua);
    }

    public override void setAttack(Attack attack)
    {
        
        if (attack.getElemenType() == ElemenType.Agua || attack.getElemenType() == ElemenType.Neutral)
        {
            this.attacks.Add(attack);
        }
        else
        {
            try
            {
                throw new Exception(
                    $"Este ataque no es de {ElemenType.Agua}" +
                    $" o {ElemenType.Neutral}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Por favor, escoja un ataque compatible.");
            }
        }
    }
}
