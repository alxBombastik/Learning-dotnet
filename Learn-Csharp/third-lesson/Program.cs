/*

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/

bool isPalindrom(string value){
    int length = value.Length - 1;
    for(int i = 0, j = length; i <= (length / 2); i++, j--){
        if(Convert.ToUInt32(value[i]) != Convert.ToUInt32(value[j])){
            return false;
        }
    }
    return true;
}

void InputFunction(){
    while(true){
        Console.Write("Enter a number >>>");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{value} {value.ToString().Length}");
        if(isPalindrom(value.ToString())){
            Console.WriteLine("Palindrom");
        }
        else{
             Console.WriteLine("No palindrom");
            break;
        }
    }
}

InputFunction();
/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/