Console.WriteLine("Hello, World!");
Thread.Sleep(255);
Console.WriteLine("Please write your name: ");
 string name = Console.ReadLine();
 string failure = "Restart and try again until I learn the loops for C#.";



 if (name != "")
 {
    Console.WriteLine($"Hello, {name}.\nNice to meet you!");
 }
 else 
 {
   foreach (char c in failure)            // print every character separately
   {
      Thread.Sleep(111);                  // with 111 ms delay
      Console.Write(c);                   // all on the same line
   }
 }

 // Console.ReadKey();
