// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


System.Console.WriteLine("Введите набор чисел");
string str = System.Console.ReadLine();

string [] array = str.Split(" ");

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (double.Parse(array[i]) > 0) count += 1;
}
System.Console.WriteLine($"Количество элементов больше нуля составляет {count}");