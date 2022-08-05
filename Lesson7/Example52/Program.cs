// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

System.Console.WriteLine("Введите размерность массива n");
int n = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите размерность массива m");
int m = int.Parse(System.Console.ReadLine());

int [,] array = new int  [n,m];
void FillMatrix(int [,] array)
{   for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(0,10);
            }
        }
}
void PrintMatrix(int [,] array )
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "  ");
        }
        System.Console.WriteLine();
    }
}

FillMatrix(array);
PrintMatrix(array);
System.Console.WriteLine();

double sum;
for (int j = 0; j < array.GetLength(1); j++)
{
    sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,j];
    }
    System.Console.Write(sum/n + " ");
    
}