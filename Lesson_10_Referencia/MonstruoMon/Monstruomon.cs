using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Referencia.MonstruoMon;

public class Monstruomon : ICloneable
{
    protected string name;
    protected int health;
    protected int strength;
    protected int defense;
    protected Element element;
    protected List<Attack> attacks;

    public Monstruomon(string name, int health, int strength, int defense, Element element)
    {
        this.name = name;
        this.health = health;
        this.strength = strength;
        this.defense = defense;
        this.element = element;
        this.attacks = new List<Attack>();
    }

    public Monstruomon(string name, int health, int strength, int defense, Element element, List<Attack> attacks)
    {
        this.name = name;
        this.health = health;
        this.strength = strength;
        this.defense = defense;
        this.element = element;
        this.attacks = attacks;
    }

    public object Clone()
    {
        return new Monstruomon(name, health, strength, defense, element, attacks);
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

    public ElemenType getWeaknessElement()
    {
        return this.element.getWeakness();
    }

    public ElemenType getMightinessElement()
    {
        return this.element.getMightiness();
    }
    public virtual void setAttack(Attack attack)
    {
        this.attacks.Add(attack);
    }

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

    public override string ToString()
    {
        string monsterString = this.getName() + " Elemento: "
                             + this.element + " Salud: "
                             + this.getHealth().ToString() + " Fuerza: "
                             + this.getStrength().ToString() + " Defensa: "
                             + this.getDefense().ToString();
        return monsterString;
    }

}
