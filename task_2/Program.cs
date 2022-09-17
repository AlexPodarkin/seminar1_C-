/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number:");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.Write($"Max = {num1} the first maximal number !\n");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"Max = {num2} the second maximal number ! !\n"); 
}
else
{
  Console.WriteLine($"Max = {num3} the third maximal number \n");  
}