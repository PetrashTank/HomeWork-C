/*
Напишите программу, которая на вход 
принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число:");
string numberStr1 = Console.ReadLine();
int N = Convert.ToInt32(numberStr1);
int i = 1;
bool no = true;

while (i <= N)
{
    if (i % 2 !=1)
    {
        Console.Write(i + ", ");
        no = false;
    }
    i++;
}
 if (no)
{
  Console.WriteLine ("Нет четных чисел");
}
