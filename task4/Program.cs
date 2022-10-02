/*
Задача 4: Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите значение первого числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второго числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение третьего числа: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1) max = number2;
if (number3 > number2) max = number3;
Console.WriteLine($" {number1}, {number2}, {number3} -> {max} ");
