using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.model
{
    public class Account: Identifiable<int> {
    private int id;
    private String username;
    private String password;
    private bool admin;

    public Account(int id, String username, String password, bool admin)
    {
        this.id = id;
        this.username = username;
        this.password = password;
        this.admin = admin;
    }

    public Account(String username, String password, bool admin)
    {
        this.id = 0;
        this.username = username;
        this.password = password;
        this.admin = admin;
    }

    public Account(String username, String password)
    {
        this.id = 0;
        this.username = username;
        this.password = password;
        this.admin = false;
    }

    public Account(int id, String username, String password)
    {
        this.id = id;
        this.username = username;
        this.password = password;
        this.admin = false;
    }

    public Account()
    {
        this.id = 0;
        this.username = "";
        this.password = "";
        this.admin = false;
    }

    public String getUsername()
    {
        return username;
    }

    public void setUsername(String username)
    {
        this.username = username;
    }

    public String getPassword()
    {
        return password;
    }

    public void setPassword(String password)
    {
        this.password = password;
    }

    public bool isAdmin()
    {
        return admin;
    }

    public void setAdmin(bool admin)
    {
        this.admin = admin;
    }
   
    public int getID()
    {
        return id;
    }
    public void setID(int id)
    {
        this.id = id;
    }

    public String toString()
    {
        return "Account{" +
                "id=" + id +
                ", username='" + username + '\'' +
                ", password='" + password + '\'' +
                ", admin=" + admin +
                '}';
    }
}
}
