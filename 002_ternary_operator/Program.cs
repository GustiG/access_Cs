Console.WriteLine("Type in an integer to check if it's even or odd: ");
int number = Convert.ToInt32(Console.ReadLine());

Thread.Sleep (255);
string answer = (number % 2 == 0) ? "even" : "odd";
Console.WriteLine($"{number} is {answer}");


int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// or remove the temporary variable "discount"

// int saleAmount = 1001;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");