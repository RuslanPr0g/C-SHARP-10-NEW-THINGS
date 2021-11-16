// In earlier versions of C#,
// a deconstruction could assign values to EITHER declared variables (all are declared),
// OR variables that we initialize during calling (all are NOT declared):

//Car car = new("VAZ 2114", "Blue");

//var (model, color) = car;
// Initialization

//string model = string.Empty;
//string color = string.Empty;
//(model, color) = car;
// Assignment

// The new version of the language allows simultaneous use of both previously declared and undeclared variables in deconstruction:

//string model = string.Empty;
//(model, var color) = car;
// Initialization and assignment

// The following error occurred in the C#9 version:
// Error CS8184: A deconstruction cannot mix declarations and expressions on the left-hand-side.