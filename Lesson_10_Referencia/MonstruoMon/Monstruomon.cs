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
    protected Element element;
    protected List<Attack> attacks;

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

    public ElemenType getWeaknessElement()
    {
        return this.element.getWeakness();
    }

    public ElemenType getMightinessElement()
    {
        return this.element.getMightiness();
    }
    public abstract void setAttack(Attack attack);

    public List<Attack> getAttack()
    {
        return this.attacks;
    }

    public ElemenType getElemenType()
    { return this.element.getElemenType(); }

    public void receiveAttack(int attackStrength)
    {
        int netAttack = attackStrength - getDefense();
        if (getHealth() > netAttack)
        {
            this.health -= netAttack;
        }
        else
        {
            this.health = 0;
        }
    }

    public bool isDead()
    {
        return this.health <= 0;
    }





}
