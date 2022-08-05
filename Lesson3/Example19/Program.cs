// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
System.Console.Write($"number = ");
int number = int.Parse(System.Console.ReadLine());

if (number > 9999 & number <= 99999) 
{
int first = number / 10000;
int fifth = number % 10;
int second = (number / 1000) % 10;
int fourth = (number /10) % 10;

if (first == fifth & second == fourth)

{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}
}
else
{
System.Console.WriteLine("Число не пятизначное");
}