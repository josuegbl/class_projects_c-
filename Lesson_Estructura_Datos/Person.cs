using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class Person
{
    string name;
    
    public Person()
    {

    }

    public Person(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return this.name;
    }

    protected void setName(string name)
    {
        this.name = name;
    }
}
