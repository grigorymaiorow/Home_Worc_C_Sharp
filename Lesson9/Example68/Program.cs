// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

System.Console.WriteLine("Введите число m");
int m = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите число n");
int n = int.Parse(System.Console.ReadLine());

int Akkerman (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, n);
    }

    else if (m > 0 && n > 0)
    {
        Akkerman(m - 1, Akkerman(m, n - 1));
    }

    return Akkerman(m,n);
}
System.Console.WriteLine(Akkerman(m,n));