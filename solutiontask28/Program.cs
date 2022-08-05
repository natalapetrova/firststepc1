// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N

Console.Write("Введите число: ");          // Просим ввести число
string? inputLine = Console.ReadLine();    // Считываем число
int inputNum = int.Parse(inputLine);       // Превращаем в вещественный тип

Console.WriteLine(sumNums(inputNum));      //вызываем метод
Console.WriteLine(mulRec(inputNum));      //вызываем метод

// Метод выдает и принимает
int sumNums(int num)                       // 
{
    int sum = 1;                           //
    for (int i = 1; i <= inputNum; i++)     //
    {
        sum *= i;                          // Запись равносильна sum = sum * i
    }
    return sum;                            //
}

// Решение с рекурсией

int mulRec(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        return num * mulRec(num - 1);
    }
}