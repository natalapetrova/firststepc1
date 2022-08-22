
// Метод который создает массив и заполняет его случайными числами
int[] FillingArray()
{
    // обязательно вызываем new чтобы выделить память для массива
    int[] outArray = new int[5];                               //Выходной массив

    int i = 0;                                                  // Переменный оператор

    System.Random numberSintezator = new System.Random();       // Экземпляр класса который создает рандомные номера

    while (i < 5)
    {
        // Получаем новое значение
        outArray[i] = numberSintezator.Next(0, 100);
        // Увеличиваем инкремент
        i++;
    }
    // Возвращаем значение
    return outArray;
}

// Метод который печатает массив в консоль
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

// Метод который находит разницу между максимальным и минимальным эл-ом массива
void ColculateTask(int[] outArray)       // Метод ничего не возвращает, принимает массив
{                                           
    int resultMin = outArray.Min();     // Находим минимальное значение
    int resultMax = outArray.Max();     // Находим максимальное значение
    int result = resultMax - resultMin; // Вычитаем
    Console.WriteLine(result);         // печатаем массив в консоль
}

int[] bufferArray = FillingArray();         // вызываем методы
PrintIntArray(bufferArray);
ColculateTask(bufferArray);