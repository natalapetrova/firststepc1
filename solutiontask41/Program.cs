// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.

// Метод с помощью которого пользователь заполняет массив
int[] FillingArray()                                // принимает массив из консоли и возвращает его
{
    Console.Write("Введите длину массива:\t");
    int lenght = int.Parse(Console.ReadLine());     // парсим размер из консоли
    int[] myArray = new int[lenght];                // создаем массив с длиной пользователя


    for (int i = 0; i < myArray.Length; i++)    // проходим по каждуму индексу и заполняем
    {
        Console.Write("Введите значение под индексом:\t" + i + "\t");

        myArray[i] = int.Parse(Console.ReadLine());
    }
    return myArray;
}

// Выводим массив в консоль
void PrintIntArray(int[] outArray)
{
    int i = 0;

    while (i < outArray.Length - 1)
    {
        Console.Write(outArray[i] + ",");
        i++;
    }
    Console.WriteLine(outArray[i]);
}

// Метод который считает кол-во чисел больше 0
void ColculateTask(int[] outArray)       // Метод ничего не возвращает, принимает массив
{
    int resultArray = 0;                    // вводим переменную для счетчика чисел

    for (int i = 0; i < outArray.Length; i++)
    {
        if (outArray[i] > 0)
        {
            resultArray++;
        }
    }
    Console.WriteLine(resultArray);         // печатаем массив в консоль
}


int[] bufferArray = FillingArray();         // вызываем методы
PrintIntArray(bufferArray);
ColculateTask(bufferArray);





