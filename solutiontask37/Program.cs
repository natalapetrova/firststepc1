
int[] FillingArray()
{
    // обязательно вызываем new чтобы выделить память для массива
    int[] outArray = new int[123];                               //Выходной массив

    int i = 0;                                                  // Переменный оператор

    System.Random numberSintezator = new System.Random();       // Экземпляр класса который создает рандомные номера

    while (i < 123)
    {
        // Получаем новое значение
        outArray[i] = numberSintezator.Next(-1000, 1000);
        // Увеличиваем инкремент
        i++;
    }
    // Возвращаем значение
    return outArray;
}


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

int[] ColculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2 + 1];
    int i = 0;

    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        i++;
    }
    return resultArray;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintIntArray(resultArray);