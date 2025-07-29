using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon
{
    public class LightningMon : Monstruomon
    {
        public LightningMon(string name, int health, int strength, int defense)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.defense = defense;
            this.element = new Element(ElemenType.Rayo);
        }

        public override void setAttack(Attack attack)
        {

            if (attack.getElemenType() == ElemenType.Rayo || attack.getElemenType() == ElemenType.Neutral)
            {
                this.attacks.Add(attack);
            }
            else
            {
                try
                {
                    throw new Exception(
                        $"Este ataque no es de {ElemenType.Rayo}" +
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
}
