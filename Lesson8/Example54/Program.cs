// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();

int [,] array = new int  [4,4];

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

void Selection(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1);j++)
        {
            
            int iMax = i;
            int jMax = j;
            
            for (int k = j + 1; k < array.GetLength(0); k++)
            {
                if (array[i,k] > array[iMax, jMax])
                {
                    iMax = i;
                    jMax = k;
                }
            }
            int  temp = array[i,j];
            array[i,j] = array[iMax, jMax];
            array[iMax, jMax] = temp;
        }
    }
}

Selection(array);
PrintMatrix(array);