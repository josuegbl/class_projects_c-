using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class Employee : Person
{
    private string position;

    public Employee()
    {

    }
    public Employee(string  name, string surname, string position)
        : base(name, surname)
    {
        this.position = position;
    }

    // use default doWork();

    public override string? ToString()
    {
        return base.ToString() +
               " y posicion es " + this.position;
    }


}
