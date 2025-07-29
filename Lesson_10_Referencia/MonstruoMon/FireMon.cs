using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon
{
    public class FireMon : Monstruomon
    {
        public FireMon(string name, int health, int strength, int defense)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.defense = defense;
            this.element = new Element(ElemenType.Fuego);
        }

        public override void setAttack(Attack attack)
        {

            if (attack.getElemenType() == ElemenType.Fuego || attack.getElemenType() == ElemenType.Neutral)
            {
                this.attacks.Add(attack);
            }
            else
            {
                try
                {
                    throw new Exception(
                        $"Este ataque no es de {ElemenType.Fuego}" +
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
