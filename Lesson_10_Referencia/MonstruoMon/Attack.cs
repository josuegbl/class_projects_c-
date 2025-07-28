using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class Attack
{
    string nameAttack;
    int attackStrength;
    ElemenType elemenType;

    public Attack(string nameAttack, int attackStrength, ElemenType elemenType)
    {
        this.nameAttack = nameAttack;
        this.attackStrength = attackStrength;
        this.elemenType = elemenType;
    }

    public string getName()
    {
        return this.nameAttack;
    }

    public ElemenType getElemenType()
    {
        return this.elemenType;
    }

    public int getAttackStrength()
    {
        return this.attackStrength;
    }

}
