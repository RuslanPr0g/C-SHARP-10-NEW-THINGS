// * The class keyword

// C# 10.0 introduces the optional keyword - class. The class keyword helps understand whether a record is of a reference type.

// Therefore, the two following records are identical:

//public record class Test(string Name, string Surname);
//public record Test(string Name, string Surname);

// * Record structs

// Now it's possible to create record structs:

// record struct Test(string Name, string Surname)

// By default, the properties of the record struct are mutable, unlike the standard record that have init modifier.

//string Name { get; set; }
//string Surname { get; set; }

// We can set the readonly property to the record struct. Then access to the fields will be equivalent to the standard record:

readonly record struct Test(string Name, string Surname);

// where the properties are written as:

//string Name { get; init; }
//string Surname { get; init; }

// The equality of two record struct objects is similar to the equality of two structs.
// Equality is true if these two objects store the same values:

//var firstRecord = new Person("Nick", "Smith");
//var secondRecord = new Person("Robert", "Smith");
//var thirdRecord = new Person("Nick", "Smith");

//Console.WriteLine(firstRecord == secondRecord);
// False
//Console.WriteLine(firstRecord == thirdRecord);
// True

// Note that the compiler doesn't synthesize a copy constructor for record struct types.
// If we create a copy constructor and use the with keyword when initializing a new object,
// then the assignment operator will be called instead of the copy constructor (as it happens when working with the record class).

// * Seal the ToString() method on records

//  There is an interesting point about inheritance as related to this method.
//  The child objects cannot inherit the overriden toString method from the parent record.
//  C# 10 introduces the sealed keyword so that the child objects can inherit the ToString method.
//  This keyword prevents the compiler from synthesizing the ToString implementation for any derived records.
//  Use the following keyword to override the ToString method:

//public sealed override string ToString()
//{
//    ....
//}

public record TestRec(string name, string surname)
{
    public override string ToString()
    {
        return $"{name} {surname}";
    }
}

public record InheritedRecord : TestRec
{
    public InheritedRecord(string name, string surname)
    : base(name, surname)
    {

    }
}

//TestRec myObj = new("Alex", "Johnson");
//Console.WriteLine(myObj.ToString());
// Alex Johnson

//InheritedRecord mySecObj = new("Thomas", "Brown");
//Console.WriteLine(mySecObj.ToString());
// inheritedRecord { name = Thomas, surname = Brown}

// As we can see, the InheritedRecord did not inherit the toString method.

// Let's slightly change the TestRec record and add the sealed keyword:

public record TestRec2(string name, string surname)
{
    public sealed override string ToString()
    {
        return $"{name} {surname}";
    }
}

//TestRec myObj = new("Alex", "Johnson");
//Console.WriteLine(myObj.ToString());
// Alex Johnson

//InheritedRecord mySecObj = new("Thomas", "Brown");
//Console.WriteLine(mySecObj.ToString());
// Thomas Brown