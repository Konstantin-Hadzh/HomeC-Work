/*
Задача 8: Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
int numBegin = 1;
Console.Write($" {numN} -> ");
while(numBegin <= numN)
{
    if (numBegin % 2 == 0)
    Console.Write(numBegin + ", "); // (numBegin + ", ")
    numBegin ++;
}
