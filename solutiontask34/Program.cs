
// Метод который создает массив и заполняет его случайными числами
int[] FillingArray()
{
    // обязательно вызываем new чтобы выделить память для массива
    int[] outArray = new int[4];                               //Выходной массив

    int i = 0;                                                  // Переменный оператор

    System.Random numberSintezator = new System.Random();       // Экземпляр класса который создает рандомные номера

    while (i < 4)
    {
        // Получаем новое значение
        outArray[i] = numberSintezator.Next(100, 1000);
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

// Метод который считает кол-во четных чисел в массиве
void ColculateTask(int[] outArray)       // Метод ничегоне возвращает, принимает массив
{                                           
    int resultArray = 0;                    // вводим переменную для счетчика четных чисел
    int i = 0;                              // счетчик для прогона массива

    while (i < outArray.Length)             // пока индекс меньше длины масссива, делаем:
    {
        if (outArray[i] % 2 == 0)           // проверяем число на четность
        {
            resultArray = resultArray + 1;  // если число четное - увеличиваем счетчик
        }
        i++;                                // увеличичваем инкремент
    }
    Console.WriteLine(resultArray);         // печатаем массив в консоль
}

int[] bufferArray = FillingArray();         // вызываем методы
PrintIntArray(bufferArray);
ColculateTask(bufferArray);








