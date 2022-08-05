// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи первое число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if (( 1 < num) & ( num < 6))
{
System.Console.WriteLine("Сегодня будний день");
}
else
{
System.Console.WriteLine("Сегодня выходной");
}