/*
Rule 1: Your code should only display one message.

Rule 2: If the user's subscription will expire in 10 days or less, display the message:
    Your subscription will expire soon. Renew now!

Rule 3: If the user's subscription will expire in five days or less, display the messages:
    Your subscription expires in _ days.
    Renew now and save 10%!

Rule 4: If the user's subscription will expire in one day, display the messages:
    Your subscription expires within a day!
    Renew now and save 20%!

Rule 5: If the user's subscription has expired, display the message:
    Your subscription has expired.

Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here