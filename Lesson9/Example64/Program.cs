// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 6; N = 2. -> "6, 5, 4, 3, 2"
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Clear();
System.Console.WriteLine("Введите число N");
int N = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите число M");
int M = int.Parse(System.Console.ReadLine());

if (N < M)
{
    void A (int N, int M)
    {
        if (N == M + 1)
        {
        return;
        }
        System.Console.Write(N + " ");
        A(N + 1, M);
    }
    A(N,M);
}

if (N > M)
{
    void B (int N, int M)
    {
        if (M == N + 1)
        {
          return;
        }
        System.Console.Write(N + " ");
        B(N - 1 , M);
    }   
    B(N,M);
}