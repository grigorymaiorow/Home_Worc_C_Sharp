// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,11);
    }
}
void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
int MaxElement (int [] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
int MinElenet(int [] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int [] array = new int [5];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int Max = MaxElement(array);
int Min = MinElenet(array);
int Difference = Max - Min;
System.Console.WriteLine($"Разница между максимальны и минимальным значением составляет {Difference}");