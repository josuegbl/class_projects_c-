using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Objetos;

public class User : Person
{
    private string email;
    
    public User()
    {

    }

    public User(string email)
    {
        this.email = email;
    }

    public User(string name, string surname, string email)
        : base(name, surname)
    {

        this.email = email;
    }
    public string getEmail()
    {
        return this.email;
    }
    public void setEmail(string email)
    {
        this.email = email;
    }

    public override string doWork()
    {
        return base.doWork() + " y trabajando como User";
    }

    public override string? ToString()
    {
        return base.ToString() +  
               " y mi email es " + this.email;
    }


}
