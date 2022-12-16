using static System.Console;

Write("Введите целое число: ");
int n = int.Parse(ReadLine()!);
int count = 1;

while (count != n + 1)
{
    if (count % 2 == 0)
        WriteLine(count);
    count++;
}