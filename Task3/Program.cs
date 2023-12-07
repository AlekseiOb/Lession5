// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int FindRowMinSum(int[,] array)
{
    int minSum = 100000000;
    int rowIndex = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            rowIndex = i;
        }
    }
    return rowIndex;
}

Console.WriteLine("Задайте прямоугольный массив");
Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
int col = row;
Console.WriteLine("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row,col,min,max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
int minRowIndex = FindRowMinSum(created2dArray);
Console.WriteLine($"Строка с индексом {minRowIndex} имеет наименьшую сумму элементов");