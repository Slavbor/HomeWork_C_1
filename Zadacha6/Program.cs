using static System.Console;

Write("Введите целое число: ");
int a = int.Parse(ReadLine()!);

if (a % 2 == 0) // остаток от деления
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}
