// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

// Вводим глобальные переменные
int m;
int n;

// Метод считаывает значения переменных с консоли
void ReadNumber()
{
    Console.WriteLine("Введите значение M");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите начение N");
    n = int.Parse(Console.ReadLine());

}

int Akker(int m, int n)         // Метод вычисления функции Аккермана
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akker(m - 1, 1);
    else return Akker(m - 1, Akker(m, n - 1));
}

void PrintResult()          // Печать результата
{
    Console.WriteLine(Akker(m, n));
}

ReadNumber();
Akker(m, n);
PrintResult();
