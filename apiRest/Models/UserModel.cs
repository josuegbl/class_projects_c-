namespace apiRest.Models;

public class UserModel
{
    private string id;
    private string name;
    private int age;

    public string Id { 
        get => id; set => id = value ;
    }
    public string Name {
        get => name; set => name = value;
    }
    public int Age {
        get => age; set => age = value;
    }

    public UserModel()
    {
    }

    public UserModel(string id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }

    public void setId(string id)
    {
        this.id = id;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public void setAge(int age)
    {
        this.age = age;
    }
    public string getId()
    {
        return this.id;
    }
    public string getName()
    {
        return this.name;
    }
    public int getAge()
    {
        return this.age;
    }
}
