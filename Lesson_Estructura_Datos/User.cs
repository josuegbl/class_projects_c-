using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Estructura_Datos;

public class User
{
    private bool isAdmin;

    public User()
    {
        this.isAdmin = false;
    }

    public bool getIsAdmin()
    {
        return this.isAdmin;
    }

    private void setIsAdmin(bool isAdmin)
    {
        this.isAdmin = isAdmin;
    }

    public void adminPasswdCheck(string username, string passwd)
    {
        string[] usersCredentials = AdminHandler.getCredentials();

        foreach (string line in usersCredentials)
        {
            string[] userLine = line.Split(',');
            if (username == userLine[0] && passwd == userLine[1])
            {
                setIsAdmin(true);
                break;
            }
        }
    }

}
