/*
Declare an array and initialize it to contain the following elements:

B123
C234
A345
C15
B177
G3003
C235
B179

These values represent the fraudulent Order ID data that your application use.

Create a foreach statement to iterate through each element of your array.

Report the Order IDs that start with the letter "B".
*/

string[] ids = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach(string id in ids)
{
    if (id.StartsWith('B'))
    {
        Console.WriteLine(id);
    }
}