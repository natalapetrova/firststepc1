
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

//Метод решения задачи 35 наивный
int ColculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;                     //Переменная куда мы положим результат
    int i = 0;                                     //Оператор который будет переключаться и пробегать по всему массиву
    while (i < inputArray.Length)
    {
        if (inputArray[i] >= downBorder && inputArray[i] <= upBorder)            //Если этот элемент будет равен тому числу которое мы ищем
        {
            Console.Write(inputArray[i]+" ");
            resultCount++;                                //Прерываем операцию сразу после нахождения числа
        }
        i++;
    }
    return resultCount;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine(ColculateTask(bufferArray, 10, 99));
