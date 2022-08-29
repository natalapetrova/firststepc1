//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            outArray[i, j] = numberSyntezator.Next(0, 10);
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

void CalcAverage(int[,] inputArray)
{

for (int j = 0; j < inputArray.GetLength(1); j++)
{
    double outAverage = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        outAverage += inputArray[i, j];
    }
    Console.Write($"{ outAverage / inputArray.GetLength(0)} ");
}
}

int[,] bufArray = FillTwoDimArray(3, 3);
PrintTwoDimArray(bufArray);
CalcAverage(bufArray);
