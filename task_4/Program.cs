﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
Console.Write("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (num >= count)
{
   Console.WriteLine(count);
   count += 2; 
}