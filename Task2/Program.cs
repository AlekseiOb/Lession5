// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

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


void SwapRows(int[,] array, int row1, int row2)
{
    int numCol = array.GetLength(1);
    for (int j = 0; j < numCol; j++)
    {
        int temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp;
    }
}

Console.WriteLine("Задайте новый массив");
Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row,col,min,max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
SwapRows(created2dArray, 0, created2dArray.GetLength(0) - 1);
Console.WriteLine("Массив после замены строк:");
Show2dArray(created2dArray);