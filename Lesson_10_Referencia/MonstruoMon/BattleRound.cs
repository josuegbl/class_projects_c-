using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class BattleRound
{
    private Monstruomon attacker;
    private Monstruomon defender;

    public BattleRound(Monstruomon attacker, Monstruomon defender)
    {
        this.attacker = attacker;
        this.defender = defender;
    }

    public void attackRound(int attackOption)
    {
        Attack pickedAttack = this.attacker.getAttacks()[attackOption];

        float attackBase = (float)pickedAttack.getAttackStrength() + this.attacker.getStrength();
        int attackStrength = (int)Math.Round(attackBase * getAttckModifier(pickedAttack));
        this.defender.receiveAttack(attackStrength);
    }

    private float getAttckModifier(Attack pickedAttack)
    {
        if (pickedAttack.getElemenType() == defender.getWeaknessElement())
        {
            return 2F;
        }
        else if (pickedAttack.getElemenType() == defender.getMightinessElement())
        {
            return 0.5F;
        }
        else
        {
            return 1F;
        }
    }

    public bool defenderIsDead()
    {
        return defender.isDead();
    }


}
