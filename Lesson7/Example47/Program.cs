// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
System.Console.WriteLine("Введите количество строк");
int m = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int n = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();

double [,] array = new double [m,n];

void FillArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()* 20 - 10;
        }
    }
}

void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(" {0:F20} ",array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine();