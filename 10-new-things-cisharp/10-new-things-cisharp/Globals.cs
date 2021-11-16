namespace _10_new_things_cisharp;

// *** Beginning with C# 10, you can use the using directive across an entire project. Add the global keyword before the using phrase:

// *** Thus, the using directive allows you not to duplicate the same namespaces in different files.

// Important. Use global using construction BEFORE code lines that include using without global keyword. Example:

//global using System.Text;
//using System;
//using System.Linq;
//using System.Threading.Tasks;

//using System;
//using System.Linq;
//using System.Threading.Tasks;
//global using System.Text;
// Error CS8915
// A global using directive must precede
// all non-global using directives.

// If you wrote the namespace that was previously written with the global keyword, the IDE will warn you (IDE: 0005: Using directive is unnecessary).