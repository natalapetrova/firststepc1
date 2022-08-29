// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int value1 = 0;         // вводим глобальную переменную

// метод для заполнения двумерного массива рандомными числами
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

// метод инициализации числа
int initiation()
{
    Console.Write("Введите элемент: ");
    int value = Convert.ToInt32(Console.ReadLine()); // конвертируем в число и вкладываем в переменную

    return value; //вернули массив

}

int IndexOf(int[,] inputArray, int value)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if (inputArray[i, j] == value)
            {
                Console.WriteLine(inputArray[i, j]);
                return inputArray[i, j];
            }
            j++;
        }
        i++;
    }
    Console.WriteLine("такого числа в массиве нет");
    return -1;
}


int[,] bufArray = FillTwoDimArray(5, 8);
PrintTwoDimArray(bufArray);
int bufElement =  initiation();
IndexOf(bufArray, bufElement);