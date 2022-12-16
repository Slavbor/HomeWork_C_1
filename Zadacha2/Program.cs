using static System.Console;

Write("Введите число а: ");
int a = int.Parse(ReadLine()!);
Write("Введите число b: ");
int b = int.Parse(ReadLine()!);
if (a > b)
{
    WriteLine("max =" + a);
}
else if (a == b)
{
    WriteLine("Числа равны.");
}
else
{
    WriteLine("max = " + b);
}
