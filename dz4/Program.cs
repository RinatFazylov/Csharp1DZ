// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число :");
int index = 2;
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2)
{
    Console.WriteLine("Неверное число");
}
else
{
    while (index <= N)
    {
        Console.Write ($"{index} ");
        index = index + 2;
    }
}

