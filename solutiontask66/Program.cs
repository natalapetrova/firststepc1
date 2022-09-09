// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Вводим глобальные переменные
int sum = 0;
int numberM;
int numberN;

// Метод считаывает значения переменных с консоли
void ReadNumber()
{

    Console.WriteLine("Введите значение M");
    numberM = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите начение N");
    numberN = int.Parse(Console.ReadLine());

}

void PrintNumber(int numberM, int numberN)
{
    if (numberM -1 >= numberN)  // Если M дошло до значения N прерываем метод и выводим результат
    {
        Console.Write(sum);
        return;                    
    }
    sum = sum + numberM;
    PrintNumber(numberM + 1, numberN); // Снова вызываем метод, выполняем инкремент для перебора всех чисел в промежутке
}

ReadNumber();
PrintNumber(numberM, numberN);