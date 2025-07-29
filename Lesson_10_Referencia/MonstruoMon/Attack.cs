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
    Element element;

    public Attack(string nameAttack, int attackStrength, Element element)
    {
        this.nameAttack = nameAttack;
        this.attackStrength = attackStrength;
        this.element = element;
    }

    public string getName()
    {
        return this.nameAttack;
    }

    public ElemenType getElemenType()
    {
        return this.element.getElemenType();
    }

    public int getAttackStrength()
    {
        return this.attackStrength;
    }

}
