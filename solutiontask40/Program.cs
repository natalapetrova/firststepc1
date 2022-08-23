// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

// задаем три глобальные переменные
int sideA = 0;
int sideB = 0;
int sideC = 0;

ReadSides();
bool res = TestTriangle(sideA, sideB, sideC);
PrintAnswer(res);

// Первый метод считывает точки с консоли
void ReadSides()
{
    Console.Write("Введите число 1: ");
    sideA = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите число 2: ");
    sideB = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите число 3: ");
    sideC = int.Parse(Console.ReadLine() ?? "");

}

// Метод который возвращает значение bool
bool TestTriangle(int num1, int num2, int num3)
{
    bool answer = ((num1 + num2 > num3)
    && (num2 + num3 > num1)
    && (num1 + num3 > num2)) ? true : false;
    return answer;
}

// Метод который выводит ответ
void PrintAnswer(bool answer)
{
    if (answer)
    {
        Console.WriteLine("Из этих отрезков можно создать треугольник");
    }
    else
    {
        Console.WriteLine("Из этих отрезков нельзя создать треугольник");
    }
}