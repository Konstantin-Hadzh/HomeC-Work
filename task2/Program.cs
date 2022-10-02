/*
Задача 2: Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите знаение числа a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение числа b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"a = {a}; b = {b} -> max = {a}, min -> {b} ");
}
if (a < b)
{
    Console.WriteLine($"a = {a}; b = {b} -> max = {b}, min -> {a} ");
}
if (a == b)
{
    Console.WriteLine($"a = {a}; b = {b} -> a = b ");
}
