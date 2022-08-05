// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите первое число");
int A = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int B = int.Parse(System.Console.ReadLine());

Console.WriteLine();

//Вариант1

double C = Math.Pow(A, B);
System.Console.Write($"Число {A} в степени числа {B} = {C}");

System.Console.WriteLine();

//Вариант2
int result = 1;
for (int i = 0; i < B; i++)
{
    result = A * result;
}
System.Console.WriteLine($"Число {A} в степени числа {B} = {result}");