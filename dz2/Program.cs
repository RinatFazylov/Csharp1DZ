//Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите 3 числа");
int x, y, z;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
z = Convert.ToInt32(Console.ReadLine());
int max = x;
if (max > y)
{
    max = max;
}
else
{
    max = y;
}
if (max > z)
{
    max = max;
}
else
{
    max = z;
}
Console.WriteLine($"Наибольшое число >>> {max}");

