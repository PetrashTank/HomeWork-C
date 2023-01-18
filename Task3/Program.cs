/*Console.WriteLine("Введите число 1:");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);
Console.WriteLine("Введите число 2:");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);
int c = a / b;
if (c == b)
{
  Console.WriteLine ("Число является квадратом");
}
else 
{
Console.WriteLine("Число не является квадратом");
}
*/
/*
Напишите программу, которая на вход принимает 
число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Введите число:");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);
if (a % 2 == 1)
{
Console.WriteLine("Число " + a + " нечетное");
}
else
{
Console.WriteLine("Число " + a + " четное");
}
