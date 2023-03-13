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
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. В случае, 
если это невозможно, программа должна вывести сообщение для пользователя.
*/

void ReverseRowsInMatrix(int[,] matrix){
    int temp = 0;
    for (int rows = 0; rows < matrix.GetLength(1); rows++)
    {
        temp = matrix[0, rows];
        matrix[0, rows] = matrix[matrix.GetLength(0) - 1, rows];
        matrix[matrix.GetLength(0) - 1, rows] = temp;
    }
}

void Task53(){
    int row = GetRows("индекс строки");
    int col = GetCols("индекс столбца");
    int[,] matrix = new int[row, col];
    FillArrayRandomIntValues(matrix, -10, 10);
    Console.WriteLine("Старый массив");
    PrintIntMatrix(matrix);
    ReverseRowsInMatrix(matrix);
    Console.WriteLine("Новый массив");
    PrintIntMatrix(matrix);

}
//Task53();

int[,] NewMatrix(int[,] matrix){    
    int[,] transpoceMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            transpoceMatrix[j, i] = matrix[i, j];
        }        
    }
    return transpoceMatrix;
}

void Task55(){
    int row = GetRows("величину строки");
    int col = GetCols("величину столбца");
    int[,] matrix = new int[row, col];
    FillArrayRandomIntValues(matrix, -10, 10);
    Console.WriteLine("Старый массив");
    PrintIntMatrix(matrix);    
    Console.WriteLine("Новый массив");
    int[,] newMatrix = NewMatrix(matrix);
    PrintIntMatrix(newMatrix);
    
}
//Task55();

/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//Описание функции сортировки методом простого включения

void SortElementsOfRowsInDescendingMatrix(int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if(matrix[rows, k] < matrix[rows, k + 1]){
                    int temp = matrix[rows, k + 1];
                    matrix[rows, k + 1] = matrix[rows, k];
                    matrix[rows, k] = temp;
                }
            }
        }
    }
}

void Task54(){
    int row = GetRows("количество строк");
    int col = GetCols("количество столбцов");
    int[,] matrix = new int[row, col];
    FillArrayRandomIntValues(matrix, -10, 10);
    System.Console.WriteLine("Старая матрица");
    PrintIntMatrix(matrix);
    SortElementsOfRowsInDescendingMatrix(matrix);
    System.Console.WriteLine("Новая матрица");
    PrintIntMatrix(matrix);

}
//Task54();
/*


Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int[] GetArrayOfSumRowsElementsInMatrix(int[,] matrix){
    int[] sumArray = new int[matrix.GetLength(0)];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        int sum = 0;
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            sum += matrix[rows, cols];
        }
        sumArray[rows] = sum;
    }
    return sumArray;
}

int GetIndexSmallestAmount(int[] array){
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]){
            min = array[i];
            index = i;
        }
    }
    return index;
}

void Task56(){
    int[,] matrix = new int[3,5];
    FillArrayRandomIntValues(matrix, -10, 10);
    PrintIntMatrix(matrix);
    int[] array = GetArrayOfSumRowsElementsInMatrix(matrix);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {GetIndexSmallestAmount(array) + 1} - строка");

}
//Task56();

/*

Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
 
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:

18 20
15 18
*/


void MultiplyMatrix(int[,] matrixC, int[,] matrixA, int[,] matrixB){
    if(matrixA.GetLength(0) != matrixB.GetLength(0)){
        return;
    }
    else
    {
    for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            for (int j = 0; j < matrixC.GetLength(1); j++)
            {
                matrixC[i,j] = 0;
                for (int k = 0; k < matrixC.GetLength(1); k++)
                {
                    matrixC[i,j] += matrixA[i,k] * matrixB[k, j];
                }
            }
        }
    }
    
}

void Task58(){
    int[,] matrixA = new int[2,2];
    FillArrayRandomIntValues(matrixA, 1, 5);
    PrintIntMatrix(matrixA);
    System.Console.WriteLine();
    int[,] matrixB = new int[2,2];
    FillArrayRandomIntValues(matrixB, 1, 5);
    PrintIntMatrix(matrixB);
    System.Console.WriteLine();
    int[,] matrixc = new int[2,2];
    MultiplyMatrix(matrixc, matrixA, matrixB);
    PrintIntMatrix(matrixc);
}
Task58();

/*


Задача 60. ...Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/