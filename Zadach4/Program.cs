using static System.Console;

Write("Введите число а: ");
int a = int.Parse(ReadLine()!);
Write("Введите число b: ");
int b = int.Parse(ReadLine()!);
Write("Введите число c: ");
int c = int.Parse(ReadLine()!);
if (a > b && a > c)
{
    WriteLine("max =" + a);
}
else if (b > a && b > c)
{
    WriteLine("max = " + b);
}
else if (c > a && c > b)
{
    WriteLine("max = " + c);
}
else if (c == a && a == b)
{
    WriteLine("Числа равны.");
}
