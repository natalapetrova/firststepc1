// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
int coordZPointA;
int coordZPointB;
double lengthAB;


// Метод считывает координаты точек A и B
void readDataOfPoint()
{

    Console.WriteLine("Введите координату X точки A");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки A");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки A");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки B");
    coordZPointB = int.Parse(Console.ReadLine());

}

//Метод вычисляет растояние между точками A и B в 3D пространстве

void conculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordZPointA - coordZPointB), 2));

}


readDataOfPoint();
conculateLengthAB();
Console.WriteLine(lengthAB);