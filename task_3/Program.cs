/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.Write("Enter a number to check for parity:");
int num = Convert.ToInt32(Console.ReadLine());
int rem = num % 2 ;
if (rem == 0)
{
    Console.WriteLine($"{num} = this number is divisible by 2 ");
}
else
{
    Console.WriteLine($"{num} = this number is not divisible by 2 !");
}
