/*

Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.

m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5

*/

string UserMessage(string message){
    return $"Введите количество {message} >>> ";
}

int GetRows(){
    Console.Write($"{UserMessage("строк")}");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int GetCols(){
    Console.Write($"{UserMessage("столбцов")}");
    int cols = Convert.ToInt32(Console.ReadLine());
    return cols;
}


int[,] FillArray(int[,] matrix){
    int[,] newMatrix = matrix;
    for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
        {
            newMatrix[rows,cols] = rows + cols;
        }    
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows,cols]}\t");
        }
        Console.WriteLine();
    }
}

void Task48(){
    int rows = GetRows();
    int cols = GetCols();
    int[,] matrix = new int[rows, cols];
    FillArray(matrix);
    PrintMatrix(matrix);
}

//Task48();

/*
Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
*/

int[,] FillMatrix(int[,] matrix, int low, int higth){
    int[,] newMatrix = matrix;
    Random random = new Random();    
    for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
        {
            matrix[rows, cols] = random.Next(low, higth);
        }    
    }
    return newMatrix;
}

int[,] GetMatrixEvenRowColsToPow(int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            if(rows % 2 == 0 && cols % 2 == 0){ // && - И   || - ИЛИ
                matrix[rows,cols] = Convert.ToInt32(Math.Pow(matrix[rows,cols], 2)); 
            }
        }
    }
    return matrix;
}


void Task49(){
    int rows = GetRows();
    int cols = GetCols();
    int[,] matrix = new int[rows, cols];
    FillMatrix(matrix, 1, 50);
    PrintMatrix(matrix);
    Console.WriteLine();
    GetMatrixEvenRowColsToPow(matrix);
    PrintMatrix(matrix);
}

//Task49();

/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int GetSumMatrixsDiagonal(int[,] matrix){
    int sum = 0;
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            if(rows == cols){
                sum = sum + matrix[rows,cols];
            }
        }
    }
    return sum;
}

void Task51(){
    int rows = GetRows();
    int cols = GetCols();
    int[,] matrix = new int[rows, cols];
    FillMatrix(matrix, 1, 50);
    PrintMatrix(matrix);
    Console.WriteLine();
    System.Console.WriteLine($"{GetSumMatrixsDiagonal(matrix)}");
}

Task51();
