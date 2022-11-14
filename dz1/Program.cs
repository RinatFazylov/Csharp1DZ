//Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа");
int a , b ;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a==b)
{
    Console.WriteLine ("Числа равны");
}
else
{
if (a > b)
{
    Console.WriteLine($"Наибольшое число {a}");
}
else
{
    Console.WriteLine($"Наибольшое число {b}");
}
}
