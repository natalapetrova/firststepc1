// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Вводим глобальные переменные
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

// Метод печатает все натуральные числа в промежутке от M до N
void PrinterNumber(int numberM, int numberN)
{
    if (numberM - 1 == numberN) return; // Если M дошло до значения N прерываем метод
    Console.Write(numberM + " "); // Печатаем числа
    PrinterNumber(numberM + 1, numberN); // Снова вызываем метод, выполняем инкремент для перебора всех чисел в промежутке
}

ReadNumber();
PrinterNumber(numberM, numberN);