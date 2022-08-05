// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введи первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)

{
    Console.Write("Большее число: ");
    Console.WriteLine(num1);
    Console.Write("Меньшее число: ");
    Console.WriteLine(num2);
}

if (num1 < num2)

{
    Console.Write("Большее число: ");
    Console.WriteLine(num2);
    Console.Write("Меньшее число: ");
    Console.WriteLine(num1);
}

else

{
    Console.Write("Числа равны другу");
}