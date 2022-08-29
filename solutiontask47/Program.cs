// Задача №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

//метод введения размера массива
double[,] FillTwoDimArray()
{
    Console.Write("Введите кол-во строк: ");
    int line = Convert.ToInt32(Console.ReadLine()); // конвертируем в число и вкладываем в переменную

    Console.Write("Введите кол-во столбцов: ");
    int column = Convert.ToInt32(Console.ReadLine()); // конвертируем в число и вкладываем в переменную

    double[,] myArray = new double[line, column];  //объявляем массив

    return myArray; //вернули массив

}

// метод заполнения двумерного массива вещественными числами
void UpdateTwoDimArray(double[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().NextDouble() * 30; // превращение чисел в вещественные
        }
    }
}

//метод для печати двумерного массива
void PrintTwoDimArray(double[,] myArray)
{
    int i = 0; int j = 0;

    while (i < myArray.GetLength(0))
    {
        j = 0;
        while (j < myArray.GetLength(1))
        {
            Console.Write(myArray[i, j] + " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}


double[,] bufArray = FillTwoDimArray();
UpdateTwoDimArray(bufArray);
PrintTwoDimArray(bufArray);
