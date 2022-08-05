// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
string A = System.Console.ReadLine();
int sum = 0;

for (int i = 0; i < A.Length; i++)
{
    sum = sum + A[i] - '0';
}
System.Console.WriteLine($"Сумма цифр в числе {A} = {sum}");