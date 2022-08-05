// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введи число");
int N = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i <= N)
{
    int b = i % 2;

    if ( b == 0 )
    {
        Console.Write($"{i}, " );
    }
i++;
}

