

// Вводим глобальные переменные
int pointB1;
int pointK1;
int pointB2;
int pointK2;
int coordyX=0;
int coordyY=0;
string coordy;

// Метод считывания точек с консоли
void ReadPoint()
{
    Console.WriteLine("Введите значение b1");
    pointB1 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение k1");
    pointK1 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение b2");
    pointB2 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение k2");
    pointK2 = int.Parse(Console.ReadLine()?? "");
}

// Метод вычисления точек пересечения
void ColculateTask()
{
    if ((pointK1 == pointK2)&&(pointB1 == pointB2))
    
        Console.WriteLine("Прямые совпадают"); //проверка на совпадение прямых
    else
        if (pointK1 == pointK2)
        Console.WriteLine("Прямые параллельны"); //проверка на параллельность прямых       
    else
        {
            coordyX=(pointB2-pointB1)/(pointK1-pointK2); //вычисление по уравнению
            coordyY=(pointK1*(pointB2-pointB1))/(pointK1-pointK2)+pointB1;
        }  
    coordy = "Координаты точки пересечения: " + coordyX + "," + coordyY;
}

// Метод выводит ответ в консоль
void PrintCoordinates() 
{
    Console.WriteLine(coordy);
}    

// Вызываем методы 
ReadPoint();
ColculateTask();
PrintCoordinates();

