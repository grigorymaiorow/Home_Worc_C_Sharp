// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19    ;    [-4, -6, 89, 6] -> 0

void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,100);
    }
}
void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int sum = 0;

void SumElementOddIndex (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях"
                           + $" составляет {sum}");
}

int [] array = new int [5];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SumElementOddIndex(array);
