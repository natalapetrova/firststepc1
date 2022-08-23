// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.


// Метод который создает массив и заполняет его случайными числами
int[] FillingArray(int arrayLength)
{
    // обязательно вызываем new чтобы выделить память для массива
    int[] outArray = new int[arrayLength];                               //Выходной массив

    int i = 0;                                                  // Переменный оператор

    System.Random numberSintezator = new System.Random();       // Экземпляр класса который создает рандомные номера

    while (i < arrayLength)
    {
        // Получаем новое значение
        outArray[i] = numberSintezator.Next(-1000, 1000);
        // Увеличиваем инкремент
        i++;
    }
    // Возвращаем значение
    return outArray;
}

// Метод который печатает массив в консоль
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

// Метод создания нового массива

int[] ReversNewArray(int[] array)
{
    int length = array.Length;              // в переменную кладем длину масива
    int[] newArray = new int[length];       // создаем такой же длины массив

    for (int i = 0; i < length; i++)            
    {
        newArray[length - 1 - i] = array[i];    // Вычитаем 1 т.к. длина на 1 больше чем последний индекс, и вычитаем индекс первого эл-та
    }                                           // находим значение зекрального эл-та и присваевываем ему начальный индекс(меняем местами)
    return newArray;                            //
}

int[] ReverseSwapArray(int[] array){
    int length = array.Length;
    int buf;

    for (int i = 0; i < length/2; i++)
    {
        //i=1
        buf = array[i];
        array[i] = array[length - 1 - i];
        array[length - 1 - i] = buf;
    }
    return array;
}

int[] testArray = FillingArray(13);
int[] reversedArray = ReversNewArray(testArray);

PrintIntArray(testArray);
PrintIntArray(reversedArray);
PrintIntArray(ReverseSwapArray(testArray));
PrintIntArray(testArray);




