using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public abstract class Monstruomon
{
    protected string name;
    protected int health;
    protected int strength;
    protected int defense;
    protected ElemenType elemenType;
    protected List<Attack> attacks;

    public Monstruomon()
    {

    }

    public string getName()
    {
        return this.name;
    }

    public int getHealth()
    {
        return this.health;
    }

    public int getStrength()
    {
        return this.strength;
    }

    public int getDefense()
    {
        return this.defense;
    }

    public List<Attack> getAttack()
    {
        return this.attacks;
    }

    public ElemenType getElemenType()
    { return this.elemenType; }

    public void receiveAttack(Attack attack)
    {
        this.health -= (attack.getAttackStrength() - getDefense());
    }





}
