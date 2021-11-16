// Sometimes you need to use the namespace within the entire file. This action may shift the tabs to the right.
// To avoid this problem, you can now use the namespace keyword. Write the namespace keyword without braces:

//using System;
//using System.Linq;
//using System.Threading.Tasks;
//namespace TestC10;
//public class TestClass
//{
//    ....
//}

// Before C# 10, it was necessary to keep namespace braces open on the entire file:

//using System;
//using System.Linq;
//using System.Threading.Tasks;
//namespace TestC10
//{
//    public class TestClass
//    {
//        ....
//    }
//}

// Clearly, you can declare only one namespace in the file. Accordingly, the following code fragment is incorrect:

//namespace TestC10;
//namespace MyDir;
// Error CS8954
// Source file can only contain one file-scoped namespace declaration.

// as well as the following piece of code:

//namespace TestC10;
//namespace MyDir
//{
//    ....
//}
// Error CS8955
// Source file can not contain both
// file-scoped and normal namespace declarations.

