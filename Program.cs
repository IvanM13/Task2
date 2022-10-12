/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("a = ");
string Firstnumber = Console.ReadLine();
Console.Write("b = ");
string Secondnumber = Console.ReadLine();

int firstNum = int.Parse(Firstnumber);
int secondNum = int.Parse(Secondnumber);

if (firstNum > secondNum)
Console.Write($"-> max = {firstNum}");

else
Console.Write($"-> max = {secondNum}");


