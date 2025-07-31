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

    public virtual object Clone()
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

    public bool hasAttacks()
    {
        return this.attacks.Count > 0;
    }
    
    public List<Attack> getAttacks()
    {
        return this.attacks;
    }

    public string[] getAttackNames()
    {
        String[] attackNames = new String[getAttacks().Count];
        for (int i = 0; i < attackNames.Length; i++)
        {
            attackNames[i] = getAttacks()[i].getName();
        }
        return attackNames;
    }


    public ElemenType getElemenType()
    { return this.element.getElemenType(); }

    public void receiveAttack(int attackStrength)
    {
        int netAttack = attackStrength - getDefense();
        if (netAttack < 0)
        {
            netAttack = 0;
        }

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

    public string[] getObjectString()
    {
        string[] monsterString = new string[8];

        monsterString[0] = "Nombre " + this.getName();
        monsterString[1] = " Salud " + this.getHealth().ToString(); 
        monsterString[2] = " Elemento " + this.element.ToString();
        monsterString[3] = " Fuerza " + this.getStrength().ToString();
        monsterString[4] = " Defensa " + this.getDefense().ToString();
        string[] attackames = getAttackNames();
        for (int i = 5; i < monsterString.Length; i++)
        {   
            Console.Clear();
            Console.WriteLine("Valor: " + i + attackames[0]);
            monsterString[i] = attackames[i-5];
        }

        return monsterString;
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
