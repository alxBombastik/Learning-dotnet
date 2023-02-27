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

//InputFunction();
/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

void FillPoints(out int[] firstPoint, out int[] secondPoint){
    //Координаты точки (x1,y1,z1)
    Console.Write("Enter coordinates of x1 point >>> ");
    int firstXPoint = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter coordinates of y1 point >>> ");
    int firstYPoint = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter coordinates of z1 point >>> ");
    int firtsZPoint = Convert.ToInt32(Console.ReadLine());

    //Координаты точки (x2,y2,z2)
    Console.Write("Enter coordinates of x2 point >>> ");
    int secondXPoint = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter coordinates of y2 point >>> ");
    int secondYPoint = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter coordinates of z2 point >>> ");
    int secondZPoint = Convert.ToInt32(Console.ReadLine());
    firstPoint= new int[]{firstXPoint, firstYPoint, firtsZPoint};
    secondPoint= new int[]{secondXPoint, secondYPoint, secondZPoint};

}

double DistanceBetweenPoints(){
    int[] firstPoint;
    int[] secondPoint;
    FillPoints(out firstPoint, out secondPoint);
    return Math.Sqrt(Math.Pow(secondPoint[0] - firstPoint[0], 2) + 
                Math.Pow(secondPoint[1] - firstPoint[1], 2) + 
                    Math.Pow(secondPoint[1] - firstPoint[1], 2));

}

void Task21(){
    Console.WriteLine(DistanceBetweenPoints());
}

//Task21();

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

int FillValue(){
    Console.Write("Enter number >>>");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void task23(){
    int number = FillValue();
    double result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = Math.Pow(i, 3);
        if(i < number){
            Console.Write($"{result}, ");
        }
        else{
            Console.Write($"{result}. ");
        }
    }
}
task23();