/* Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int num_tmp = 0;
if (num < 100)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}

else
{
    num_tmp = num;
    while (num_tmp > 999)
    {
        num_tmp = num_tmp / 10;
    }
    Console.WriteLine($"{num} -> {num_tmp % 10}");
}