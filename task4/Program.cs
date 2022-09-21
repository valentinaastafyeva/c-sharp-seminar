// 4

Console.WriteLine("Which number is greater? Enter the first one: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second one: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third one: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num2 > max) Console.WriteLine($"{num2} is the greatest");
else if(num3 > max) Console.WriteLine($"{num3} is the greatest");
else  Console.WriteLine($"{max} is the greatest");