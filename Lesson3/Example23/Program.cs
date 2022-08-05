// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число");
System.Console.Write($"n = ");
int n = int.Parse(System.Console.ReadLine());
int i = 1;

while (i <= n )
{
    System.Console.Write(i);
    System.Console.Write("^3 = ");
    System.Console.WriteLine(i*i*i);;
    i++;
}