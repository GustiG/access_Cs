﻿// THE CODE THAT NEEDS FIXING:

// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// foreach (int number in numbers)
// {
//     int total;

//     total += number;

//     if (number == 42)
//     {
//        bool found = true;

//     }

// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");

// THE SOLUTION:


// int[] numbers = [4, 8, 15, 16, 23, 42];
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//     {
//         found = true;
//     }

// }

// if (found)
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");


// EXERCISES:

// works:

// int i = 1;
// bool t = true;

// if (t)
// {
//     int j = 8;
//     int sum = i + j;
//     Console.WriteLine(sum);
// }


// throws an out of scope error:

// int x = 5;
// bool t = true;

// if (t)
// {
//     int y = 6;
// }
// int suma = x + y;
