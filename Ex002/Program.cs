// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha54()
{
Random random = new Random();
int rows = random.Next(2, 6);
int columns = random.Next(3, 6);
int[,] array = new int[rows, columns]; 
FillArray(array);
PrintArray(array);
Sum(array);

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

void Sum(int[,] array)
{
    int sumTemp = 0;
    int minSum = 0;
    int row = 1;
    int minRow = 1;
    for (int i = 0; i < rows; i++)
    {
        int sumCount = 0;
        for (int j = 0; j < columns; j++)
        {
            sumCount += array[i,j];
        }
        if (sumCount < sumTemp)
        {
            minSum = sumCount;
            minRow = i + 1;
        }
        else
        {
            sumTemp = sumCount;
        }
    Console.WriteLine ($"Сумма строки {row} = {sumCount}");
    row++;
    }
Console.WriteLine ($"Cтрока c минимальной суммой: {minRow}");    
}
}
Zadacha54();