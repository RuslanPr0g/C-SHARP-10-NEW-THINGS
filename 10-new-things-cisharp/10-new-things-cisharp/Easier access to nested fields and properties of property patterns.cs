// C# 8.0 introduced the property pattern that allows you to easily match on fields
// and/or properties of an object with the necessary expressions.

// Before, if you needed to check any nested property, the code could look too cumbersome:
// ....{property: {subProperty: pattern}}....

// With C#10, you just need to add the dots between the properties:
// ....{property.subProperty: pattern}....

// Let's see the change using the example of the method of taking the first 4 symbols of the name.

//public record TestRec(string name, string surname);

//string TakeFourSymbols(TestRec obj) => obj switch
//{
//    // old way:
//    //TestRec { name: {Length: > 4} } rec => rec.name.Substring(0,4),

//    // new way:
//    TestRec { name.Length: > 4 } rec => rec.name.Substring(0, 4),
//    TestRec rec => rec.name,
//};

// The example above shows that the new type of property access is simpler and clearer than before.