                            // string? readResult;
                            // bool validEntry = false;
                            // Console.WriteLine("Enter a string containing at least three characters:");
                            // do
                            // {
                            //     readResult = Console.ReadLine();
                            //     if (readResult != null)
                            //     {
                            //         if (readResult.Length >= 3)
                            //         {
                            //             validEntry = true;
                            //         }
                            //         else
                            //         {
                            //             Console.WriteLine("Your input is invalid, please try again.");
                            //         }
                            //     }
                            // } while (validEntry == false);

/*
The int.TryParse() method can be used to convert a string value to an integer. 
The method uses two parameters, a string that will be evaluated and the name of an integer variable 
that will be assigned a value. The method returns a Boolean value. 
The following code sample demonstrates using the int.TryParse() method:
*/

// capture user input in a string variable named readResult

                            // int numericValue = 0;
                            // bool validNumber = false;

                            // validNumber = int.TryParse(readResult, out numericValue);

/*
Code project 1 - write code that validates integer input
Here are the conditions that your first coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: 
your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement 
to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement 
to inform the user that their input value has been accepted.
*/

// string? userInput;
// int integer = 0;
// Console.WriteLine("Please enter an integer between 5 and 10");
// bool validInput = false;

// do
// {
//     userInput = Console.ReadLine();
//     if (userInput != null)
//     {
//         validInput = int.TryParse(userInput, out integer);
//         if (integer < 5 || integer > 10)
//         {
//             Console.WriteLine("Fail.");
//         }
//         else
//         {
//             Console.WriteLine("Success.");
//         }
//     } 
    
// } while (validInput);


/*
Code project 2 - write code that validates string input
Here are the conditions that your second coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement 
to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement 
to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement 
to inform the user that their input value has been accepted.
*/

string? userInput2;
string role = "";
bool validInput2 = false;

do
{
    Console.WriteLine("Please enter your role: ");
    userInput2 = Console.ReadLine();
    if (userInput2 != null)
    {
        role = userInput2.Trim();
    }

    if (role.ToLower() == "administrator" || role.ToLower() == "manager" || role.ToLower() == "user")
    {
        validInput2 = true;
    }
    else
    {
        Console.WriteLine($"The role {role} is not valid.");
    }
} while (!validInput2);

Console.WriteLine($"Your role of {role} has been accepted.");

//----------------------- CODE 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}



