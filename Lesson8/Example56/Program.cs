/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

Console.Clear();

int n = 1;
int m = 10;

int [,] array = new int [3,3];

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(n,m);
        }
    }
}

void PrintArray(int [,] array)
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
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int sum;
int Summa = m*3;
int index = 0;

void MinSum (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }

        if (sum < Summa) 
        {
            Summa = sum;
            index = i ;
        } 
    }
    System.Console.WriteLine($"Минимальная сумма элементов строки, равная {Summa} находится в строке с index = {index}");
}
MinSum(array);
