int counter = 0;

do
{
    counter++;
    Console.WriteLine(counter);  // counts from 1 to 5 because the print is after the increment
}
while (counter < 5);

// FOR LOOP below -- the for loop is optimized for counting

for (   
    int i = 0;  // setup/initialize (start) 
    i < 5;      // conditional
    i++)        // iteration (increment)
{
    Console.WriteLine(i);       // counts from 0 to 4
}
