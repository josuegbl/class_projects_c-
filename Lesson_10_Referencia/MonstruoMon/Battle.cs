using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class Battle
{
    private Monstruomon pMonster;
    private Monstruomon AIMonster;

    public Battle(Monstruomon pMonster, Monstruomon AIMonster)
    {
        this.pMonster = pMonster;
        this.AIMonster = AIMonster;
    }

    public Monstruomon getPersonMon()
        { return pMonster; }

    public Monstruomon getAIMon()
        { return AIMonster; }

    public void doBattle()
    {
        Menu menu = new Menu();
        int round = 1;
        bool isFinished = false;

        do
        {
            int attackOption;
            bool AIwon = false;
            Monstruomon attacker;
            Monstruomon defender;

            menu.printBattleMenu(getPersonMon().getObjectString()
                                 , getAIMon().getObjectString());
            
            if (round % 2 != 0)
            {
                attacker = getPersonMon();
                defender = getAIMon();
                menu.selector(3, -19, 8);
                attackOption = menu.getOption();
            }
            else
            {
                attacker = getAIMon();
                defender = getPersonMon();
                AIwon = true;

                int numOfAttacks = attacker.getAttacks().Count;
                Random random = new Random();
                attackOption = random.Next(0, numOfAttacks);
            }

            BattleRound newBattleRound = new BattleRound(attacker, defender);
            newBattleRound.attackRound(attackOption);
            
            isFinished = newBattleRound.defenderIsDead();

            if (isFinished)
            {
                menu.defenderLost(defender.getName(), AIwon);
            }
            round++;

        } while (!isFinished);
    }
}
