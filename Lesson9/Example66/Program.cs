// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

System.Console.WriteLine("Введите число N");
int N = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите число M");
int M = int.Parse(System.Console.ReadLine());
int sum = 0;

int  Summ (int N, int M)
{
    if (N == M + 1)
    {
        return sum;
    }
    sum += N;
    Summ(N + 1, M);
    return sum;
}    
System.Console.WriteLine(Summ(N,M));

