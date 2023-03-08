string UserMessage(string message){
    return $"Введите {message} >>> ";
}

int GetRows(string message){
    Console.Write($"{UserMessage(message)}");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int GetCols(string message){
    Console.Write($"{UserMessage(message)}");
    int cols = Convert.ToInt32(Console.ReadLine());
    return cols;
}


double[,] FillArrayRandomDoubleValues(double[,] matrix, double first, double last){
    double[,] newMatrix = matrix;
    for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
        {
            newMatrix[rows,cols] = new Random().NextDouble() * (first - last) + last;

        }    
    }
    return newMatrix;
}

void PrintDoubleMatrix(double[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows,cols]:f2}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillArrayRandomIntValues(int[,] matrix, int first, int last){
    int[,] newMatrix = matrix;
    for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
        {
            newMatrix[rows,cols] = new Random().Next(first, last);

        }    
    }
    return newMatrix;
}

void PrintIntMatrix(int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows,cols]}\t");
        }
        Console.WriteLine();
    }
}

/*

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

void Task47(){
    int rows = GetRows("количество строк");
    int cols = GetCols("количество столбцов");
    double[,] matrix = new double[rows, cols];
    FillArrayRandomDoubleValues(matrix, -10, 10);
    PrintDoubleMatrix(matrix);
}

//Task47();
/*

Задача 50. Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, и возвращает 
 значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> по данным индексам такого числа в массиве нет

*/

void GetMatrixItemByIndex(int [,] matrix, int row, int col){
    if((row < matrix.GetLength(0) && col < matrix.GetLength(1)) && (col > 0 && row > 0)){
        Console.WriteLine($"По данным индексам matrix[{row},{col}] = {matrix[row,col]}");
    }
    else{
        Console.WriteLine("По данным индексам такого числа в массиве нет");
    }
}

void Task50(){
    int row = GetRows("индекс строки");
    int col = GetCols("индекс столбца");
    int[,] matrix = new int[5, 5];
    FillArrayRandomIntValues(matrix, -10, 10);
    PrintIntMatrix(matrix);
    GetMatrixItemByIndex(matrix, row, col);
}

Task50();

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

