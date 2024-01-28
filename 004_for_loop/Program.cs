int[] intsToCompress = [1, 1, 2, 3, 5, 8, 13, 21];   // make an array

//______________________________________________________________________________________________________________________
int total = 0;
DateTime startTime = DateTime.Now;

for (int i = 0; i < intsToCompress.Length; i++)     // iterate over the array
{
    total += intsToCompress[i];                     
}

Console.WriteLine(total);
Console.WriteLine($"The answer was found in {(DateTime.Now - startTime).TotalSeconds} seconds with the for loop");
double time = (DateTime.Now - startTime).TotalSeconds;

//______________________________________________________________________________________________________________________

DateTime startTime2 = DateTime.Now;
int total2 = 0;
foreach(int j in intsToCompress)
{
    total2 += j;
}
Console.WriteLine($"The answer was found in {(DateTime.Now - startTime2).TotalSeconds} seconds with the foreach loop");
double time2 = (DateTime.Now - startTime2).TotalSeconds;

//______________________________________________________________________________________________________________________

if (time > time2)
{
    Console.WriteLine($"The foreach loop is faster than the for loop by {(time2 - time)*(-1)} seconds.");
}
else
{
    Console.WriteLine($"The for loop is faster than the foreach loop by {(time - time2)*(-1)} seconds.");
}