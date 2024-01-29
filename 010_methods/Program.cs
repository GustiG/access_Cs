// state is used to describe the condition of the execution environment at a specific moment in time. (stateful or instance)
 // stateless methods are implemented so that they can work without referencing or changing any values already stored in memory
Random dice = new Random(); // An instance of a class is called an object. To create a new instance of a class, you use the new operator. 
// or the new C# way:
// Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

/*
To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.
When calling a stateless method, you don't need to create a new instance of its class first.
When calling a stateful method, you need to create an instance of the class, and access the method on the object.
Use the new operator to create a new instance of a class.
An instance of a class is called an object.
*/
