/*Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Clear();

Console.Write("Введите день недели от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num < 6)
{
    Console.WriteLine($"{num} -> нет");
}

if (num > 5 && num <= 7)
{
    Console.WriteLine($"{num} -> да");
}

else
{
    Console.WriteLine("Некорректное число");
    Console.WriteLine("Перезапустите программу и введите значение от 1 до 7");
}