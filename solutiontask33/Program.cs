
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

//Метод решения задачи 33 наивный
bool ColculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;                     //Переменная куда мы положим результат
    int i = 0;                                     //Оператор который будет переключаться и пробегать по всему массиву
    while (i < 12)
    {
        if(inputArray[i]==searchNumber)            //Если этот элемент будет равен тому числу которое мы ищем
        {
            resultSearch=true;                     //Тогда результат кладем в тру
            break;                                 //Прерываем операцию сразу после нахождения числа
        }
        i++;
    }
    return resultSearch;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("Введите число для поиска: ");
int searchNumber = int.Parse(Console.ReadLine());
Console.WriteLine(ColculateTask(bufferArray,searchNumber));
