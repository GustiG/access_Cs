// state is used to describe the condition of the execution environment at a specific moment in time. (stateful or instance)
 // stateless methods are implemented so that they can work without referencing or changing any values already stored in memory
// Random dice = new Random(); // An instance of a class is called an object. To create a new instance of a class, you use the new operator. 
// or the new C# way:
// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

/*
To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.
When calling a stateless method, you don't need to create a new instance of its class first.
When calling a stateful method, you need to create an instance of the class, and access the method on the object.
Use the new operator to create a new instance of a class.
An instance of a class is called an object.
*/

// // Overloaded methods:
Random dice = new Random();
int roll1 = dice.Next();                // doesn't specify with a parameter
int roll2 = dice.Next(101);             // specifies the maximum
int roll3 = dice.Next(50, 101);         // specifies both min and max values

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
