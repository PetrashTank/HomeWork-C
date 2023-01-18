/*
 Напишите программу, которая принимает на 
 вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите число 1:");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);
Console.WriteLine("Введите число 2:");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);
Console.WriteLine("Введите число 3:");
string numberStr3 = Console.ReadLine();
int c = Convert.ToInt32(numberStr3);
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число: " + a);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + c);
    }
}
else if (b > c)
    {
        Console.WriteLine("Максимальное число: " + b);
    }
else
    {
        Console.WriteLine("Максимальное число: " + c);
    }