// Before, this feature was not supported. C# 10 allows you to use string interpolation for constant strings:
//const string constStrFirst = "FirstStr";
//const string summaryConstStr = $"SecondStr {constStrFirst}";

// Interesting fact. This change relates only to string interpolation for constant strings,
// i.e the addition of a constant character is not allowed:

//const char a = 'a';
//const string constStrFirst = "FirstStr";
//const string summaryConstStr = $"SecondStr {constStrFirst} {a}";
// Error CS0133
// The expression being assigned to
// 'summaryConstStr' must be constant

