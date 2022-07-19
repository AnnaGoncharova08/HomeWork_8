// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

void Zadacha54()
{
Random random = new Random();
int rows = random.Next(2, 6);
int columns = random.Next(3, 7);
int[,] array = new int[rows, columns]; 
FillArray(array);
PrintArray(array);
Sort(array);
Console.WriteLine();
PrintArray(array);

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {   
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void Sort(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < columns; j++)
        {
            if (array[i,j] < array[minPosition,j])
            {
                minPosition = j;
            }
        int temp = array[i,j];
        array[i,j] = array[minPosition,j];
        array[minPosition,j] = temp;
        }
    }
}
}
Zadacha54();