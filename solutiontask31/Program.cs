// Переменные для накопления результата

int posetivSum = 0;
int negativSum = 0;

// Метод возвращает массив заполненый случайными числами от -9 до 9

int[] FillingArray()
{
    // обязательно вызываем new чтобы выделить памятьдля массива
    int[] outArray = new int[12];                               //Выходной массив

    int i = 0;                                                  // Переменный оператор

    System.Random numberSintezator = new System.Random();       // Экземпляр класса который создает рандомные номера

    while (i < 12)
    {
        // Получаем новое значение
        outArray[i] = numberSintezator.Next(-9, 10);
        // Увеличиваем инкремент
        i++;
    }
    // Возвращаем значение
    return outArray;
}

//Метод ничего не возвращает, но принимает массив метод подсчета положительных и отрицательных значений
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            posetivSum++;
        }
        else
        {
            negativSum++;
        }
        i++;
    }
}

// Выводим результат на консоль
void PrintResult()
{
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativSum);

}

void VariantNaive()
{
    int[] bufferArray = FillingArray();
    PrintIntArray(bufferArray);
    ColculateTask(bufferArray);
    PrintResult();
}

VariantNaive();

void PrintIntArray(int[] inputArray)
{
    int i = 0;

    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ",");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}
