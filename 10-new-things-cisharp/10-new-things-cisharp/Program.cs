namespace TEN_NEWS;

// * Enhancements of structure types

// ** Initialization of field structure

// *** Now you can set initialization of fields and properties in structures:

public struct User
{
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 18;
}

// ** Parameterless constructor declaration in a structure type

// *** Beginning with C# 10, you can declare a parameterless constructor in structures:

public struct User2
{
    public User2()
    {

    }

    public User2(string name, int age)
    {
        Name = name;
        Age = age;
    }

    string Name { get; set; } = string.Empty;
    int Age { get; set; } = 18;
}

// *** Important. You can use parameterless constructors only if all fields and/or properties have initializers.
// *** For example, if you do not set the Age initializer, a compiler will issue an error:
// *** Error CS0843: Auto - implemented property 'User2.Age' must be fully assigned before control is returned to the caller.

// ** Applying the with expression to a structure

// *** Before, you could use the with expression with records. With C#10, you can use this expression with structures. Example:

public struct User3
{
    public User3()
    {

    }

    public User3(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 18;
}

public class User3Test
{
    public void Test()
    {
        User3 myUser = new("Chris", 21);
        User3 otherUser = myUser with { Name = "David" };
        Console.WriteLine(otherUser);
    }
}

// *** It is clear that the property that we are changing (in this case, the Name field) must have a public access modifier.