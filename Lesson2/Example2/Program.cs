// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100,1000);
System.Console.WriteLine($"число {a}");

int fir = a / 100;
int sec = a % 10;

int res = fir * 10 + sec;
System.Console.WriteLine(res);