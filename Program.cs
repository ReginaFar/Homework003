// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 10 == number / 10000 || (number / 10) % 10  == (number / 1000) % 10)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
Zadacha19();

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Zadacha21()
{
    Console.WriteLine("Введите координаты точки A");
    Console.WriteLine("X:");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y:");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z:");
    int az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки Б");
    Console.WriteLine("X:");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y:");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z:");
    int bz = Convert.ToInt32(Console.ReadLine());
    int k = bx - ax;
    int m = by - ay;
    int n = bz - az;
    double length = Math.Sqrt (k * k + m * m + n *n);
    length = Math.Round(length,2);
    Console.WriteLine("Длина = " + length);
}
Zadacha21();

//Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Zadacha23()
{
    Console.WriteLine("Введите число");
    int last_number = Convert.ToInt32(Console.ReadLine());
    int number = 1;
    double Cubes;
    while (number <= last_number)
    {
        Cubes = Math.Pow (number,3);
        Console.WriteLine($"| {number} | {Cubes} |");
        number = number + 1;
    }
}
Zadacha23();