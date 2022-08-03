// Считывает координаты точек A и B

int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengthAB;

void readDataOfPoint()
{

    Console.WriteLine("Введите координату X точки A");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки A");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

}

//Вычисляет растояние между точками A и B 

void conculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordXPointA - coordXPointB), 2));

}


readDataOfPoint();
conculateLengthAB();
Console.WriteLine(lengthAB);