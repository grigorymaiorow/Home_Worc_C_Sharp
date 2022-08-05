// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();
System.Console.WriteLine("Введите размерность матрицы n");
int n = int.Parse(System.Console.ReadLine());

int [,] array = new int  [n,n];

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
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

FillMatrix(array);
PrintMatrix(array);

System.Console.WriteLine("Введите x");
int x = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите y");
int y = int.Parse(System.Console.ReadLine());
System.Console.WriteLine();

int z = 0;
if ( x < n-1 &&  0 <= x && y < n-1 && 0 <= y )
{
    z = array [x,y];
    System.Console.WriteLine($"В заданной позиции находится элемент {z}");
}
else System.Console.WriteLine("Элемента нет в заданных координатах");

