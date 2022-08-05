// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.Clear();

//Работает для матриц 2 на 2.

int [,] array = new int  [2,2];
int [,] mass = new int [2,2];

void FillMatrix(int [,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
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
System.Console.WriteLine();

FillMatrix(mass);
PrintMatrix(mass);
System.Console.WriteLine();

int [,] matrix = new int [2,2];
int Length = matrix.GetLength(0);
System.Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix[i,j] =  array[i,0] * mass [0,j] + array[i, 1] * mass [1,j] ;
    }
}
PrintMatrix(matrix);