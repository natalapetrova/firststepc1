// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень


// Вводим глобальные переменные
int inputNumberA;
int inputNumberB;
double numberAB;

// Метод считывает число А и В
void ReadNumber()
{

    Console.WriteLine("Введите число A");                    // Просим пользователя ввести число
    inputNumberA = int.Parse(Console.ReadLine());            // Превращаем значение в везественное
 
    Console.WriteLine("Введите число B");                    // Повторяем то же самое со вторым числом
    inputNumberB = int.Parse(Console.ReadLine());            //

}

// Метод возвод число в натуральную степень / Калькурятор
void ConculateNumberAB()
{
    numberAB = Math.Pow(inputNumberA, inputNumberB);          // вводим переменную и применяем математическую функцию

}

ReadNumber();                                                 // вызываем первый метод
ConculateNumberAB();                                          // вызываем второй метод
Console.WriteLine(numberAB);                                  // выводим результат в консоль

