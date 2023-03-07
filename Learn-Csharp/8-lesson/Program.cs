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
Task53();