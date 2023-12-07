// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int FindElement(int[,] array, int row, int column)
{
    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
    {
        return array[row, column];
    }
    else
    {
        return -1;
    }
}

int [,] created2dArray = Create2dArray(3,4,1,9);
Show2dArray(created2dArray);
Console.WriteLine();
Console.Write("Введите номер строки искомого элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента: ");
int column = Convert.ToInt32(Console.ReadLine());
int result = FindElement(created2dArray, row, column);

if (result != -1)
{
    Console.WriteLine($"Элемент [{row}, {column}] равен {result}");
}
else
{
    Console.WriteLine($"Элемента [{row}, {column}] нет.");
}
