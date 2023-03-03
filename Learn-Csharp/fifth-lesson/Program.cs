/*
Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

Задача 45: Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного 
копирования.
*/


int[] FillArray(int length, int first, int last){
    int[] massiv = new int[length];
    for (int i = 0; i < massiv.Length; i++)
    {
        Random rnd = new Random();
        massiv[i] = rnd.Next(first, last);
    }
    return massiv;
}



void PrintArray(int[] massiv){

    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"[{i}]={massiv[i]} | ");
    }
    Console.WriteLine();
}


int[] GetArray(int[] massiv){
    int length = massiv.Length; // Старый массив
    int[] massiv1 = new int[length];// Новый массив
    for (int i = 0; i < length; i++)
    {
        massiv1[i] = massiv[i];
    }
    return massiv1;
}

void DeepCopy(){

    int[] massiv = new int[10];
    Console.Write("Введите размер массива >>> ");
    int massivLength = Convert.ToInt32(Console.ReadLine());
    FillArray(massivLength, 1, 99); // Заполнение массива
    System.Console.WriteLine("\nНаш массив:");
    PrintArray(massiv); // Вывод массива
    int[] newMassiv = GetArray(massiv);
    System.Console.WriteLine("\nНовый массив:");
    PrintArray(newMassiv); // Вывод массива
}

     
void Fiboinachi() {
    Console.Write("Введите длинну массива >>> ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    Console.Write($"{array[0]}\t {array[1]}\t");
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
        Console.Write($"{array[i]}\t");
    }
}

//Fiboinachi();
//DeepCopy();

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int GetCountOfEvenNumbers(int[] massiv){
    int count = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i] % 2 == 0){
            count++;
        }
    }
    return count;
}


//Task34 - Done !!!
void Task34 (){
    Console.Write("Введите размер массива >>> ");
    int massivLength = Convert.ToInt32(Console.ReadLine());
    int[] newArray = FillArray(massivLength, 100, 1000);
    PrintArray(newArray);
    Console.WriteLine($"Количество четных чисел: {GetCountOfEvenNumbers(newArray)}");
}

//Task34();
/*

Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

int SumOfOddArrayElements(int[] array){
    int sum = 0;
    for (int item = 1; item < array.Length; item+=2)
    {
        sum+=array[item];
    }
    return sum;
}

//Task36 Done !!!
void Task36(){
    int[] array = FillArray(11, 1, 10);
    PrintArray(array);
    Console.WriteLine(SumOfOddArrayElements(array));
}

Task36();

/*

Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] FillDoubleArray(int length, double first, double last){
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (first - last) + last;
    }
    return array;
}

double MaxElement(double[] array){
    double max = array[0];
    for (int item = 0; item < array.Length; item++)
    {
        if(array[item] > max){
            max = array[item];
        }
    }
    return max;
}
double MinElement(double[] array){
    double min = array[0];
    for (int item = 0; item < array.Length; item++)
    {
        if(array[item] < min){
            min = array[item];
        }
    }
    return min;
}

double DifferenceBetweenMaxMinElements(double[] array){
    double max = MaxElement(array);
    double min = MinElement(array);
    Console.WriteLine($"максимальный элемент = {max:f2} и минимальный элемент = {min:f2} ");
    return max - min;
}

void PrintDoubleArray(double[] massiv){
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"[{i}]={massiv[i]:f2} | ");
    }
    Console.WriteLine();
}

//Task38 Done !!!
void Task38(){
    double[] array = FillDoubleArray(10, 1.0, 100.0);
    PrintDoubleArray(array);
    Console.WriteLine($"{DifferenceBetweenMaxMinElements(array):f2}");
}

Task38();
