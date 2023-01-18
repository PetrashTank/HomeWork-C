/*
Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число 1");
string number1 = Console.ReadLine(); 
int N = Convert.ToInt32(number1);
Console.WriteLine("Введите число 2");
string number2 = Console.ReadLine(); 
int M = Convert.ToInt32(number2);
if (N > M)
{
    Console.WriteLine($"Наибольшее число {N}");
}
else 
{
    Console.WriteLine($"Наибольшее число {M}");
}
if (N == M)
{
    Console.WriteLine("Числа равны");
}