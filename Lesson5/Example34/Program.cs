//Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел вмассиве.
// [345, 897, 568, 234] -> 2

void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int count = 0;

void EvenNumber (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }   
    }
    System.Console.WriteLine($"Колличество чётных чисел в массиве"
                            + $" array составляет {count}");
}

int [] array = new int [6];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
EvenNumber(array);