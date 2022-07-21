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
    
    int sumMin = 0;
    int minRow = 0;
    for (int j = 0; j < columns; j++)
    {
        sumMin += array[0,j];
    }
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i,j];
        }
        Console.WriteLine ($"Сумма строки {i+1}-й = {sum}");
        if (sum < sumMin)
        {
            sumMin = sum;
            minRow = i + 1;
        }
    }
Console.WriteLine ($"Cтрока c минимальной суммой: {minRow} и равна {sumMin}");    
}
}
Zadacha54();