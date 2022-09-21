// 2

Console.WriteLine("Which number is greater? Enter the first one: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second one: ");
int num2 = Convert.ToInt32(Console.ReadLine());;
if(num1 > num2) Console.WriteLine($"{num1} is greater than {num2}");
else Console.WriteLine($"{num2} is greater than {num1}");