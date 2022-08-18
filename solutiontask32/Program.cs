
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
// Метод инвертирует элементы массива простой
int[] ColculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i < 12)
    {
        inputArray[i] = inputArray[i] * (-1);
        i++;
    }
    return outputArray;
}

//Метод инверсии числа через специальный оператор

int[] InvertArrayTilda(int[] inputArray)
{
    //Буферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length)
    {
        //Инвертируем элемент
        inputArray[i] = (~inputArray[i]) + 1;
        //Увеличиваем инкримент
        i++;
    }
    //Выводим массив
    return inputArray;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintIntArray(resultArray);
resultArray = InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);

