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

//Task51();


/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int Promt(string message){
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] GetFillingArray(int arrayLength){
    int[] array = new int[arrayLength];
    for (int item = 0; item < array.Length; item++)
    {
        array[item] = Promt("Введите число >>> ");
    }
    return array;
}

int GetCountPositiveNumbers(int[] array){
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0){
            count++;
        }
    }
    return count;
}

void Task41(){
      int[] array = GetFillingArray(Promt("Введите количество элементов >>> "));
      Console.WriteLine(GetCountPositiveNumbers(array));
}

Task41();
/*
Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
