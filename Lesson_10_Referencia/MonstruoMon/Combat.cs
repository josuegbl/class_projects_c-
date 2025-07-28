using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class Combat
{
    Monstruomon attacker;
    Monstruomon defender;

    public Combat(Monstruomon attacker, Monstruomon defender)
    {
        this.attacker = attacker;
        this.defender = defender;
    }


    public void attack(int attackOption)
    {
        int attackBase = this.attacker.getAttack()[attackOption].getAttackStrength() +
                         this.attacker.getStrength();
    }

    private float getAttckModifier(ElemenType attElement, ElemenType defElement)
    {
        if (attElement == ElemenType.Agua &&)
    }
}
