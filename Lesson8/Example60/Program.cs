// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.Clear();

// Вариант 1

// int a = 3, b = 3, c = 3;
// int [,,] array = new int [a,b,c];
// int [] save = new int [array.Length];
// bool exist = false;
// int count  = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine($"List{i}");
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             array [i,j,k] = new Random().Next(10,100);
//             exist = false;

//             for (int index = 0; index < count; index++)
            
//             if (array[i,j,k] == save[index])
//             {
//                 exist = true;
//                 k--;
//                 break;
//             }
//             if (exist == false)
//             {
//                 System.Console.Write($"[{i},{j},{k}] - {array[i,j,k]}" + " ");
//                 save[count] = array[i,j,k];
//                 count++;
//             }
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// Вариант 2

int [,,] array = new int [3,3,3];

bool Method(int [,,] array, int find)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (find == array [i,j,k])
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void FillArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int a = new Random().Next(10,100);
                while (Method(array, a))
                {
                    a = new Random().Next(10,100);
                }
                array[i,j,k] = a;
            }
        }
    }
}

void PrintArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write(array[i,j,k] + " ");
            }
        System.Console.WriteLine();
        }
    }
}

FillArray(array);
PrintArray(array);