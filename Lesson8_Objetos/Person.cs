using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Person
{
    public string name;
    public string surname;

    public Person()
    {

    }

    public Person(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }

    public string getName()
    {
        return this.name;
    }

    public string getSurname()
    {
        return this.surname;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setSurname(string surname)
    {
        this.surname = surname;
    }

    public virtual string doWork()
    {
        this.ToString();

        return "trabajando como Person";
    }

    public override string? ToString()
    {
        return "Mi nombre es: " + this.name +
               " y mi apellido " + this.surname;
    }
}
