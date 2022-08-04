//Напишите программу, которая принимает на вход
//  число и выдаёт количество цифр в числе.

Console.Write("Введите число: ");

string inputLineNumber = Console.ReadLine() ?? "";
// глобальная переменная
int inputNumber = int.Parse(inputLineNumber);


//метод, который находит кол-во цифр в числе через массив - узнает длину массива

int VariantChar()
{
    //int numberLength = 0;                          // создаем переменную
    //char[] array = inputLineNumber.ToCharArray();  // положили в массив символы из которых состоит число
    //numberLength = array.Length;                   // измерили длину 

    //эти три строчки кода можно записать следующей строкой

    return inputLineNumber.ToCharArray().Length;
}

//Метод, который считает кол-во цифр в числе путем умножения (пример 1*10 = 10, 10*10 = 100 и т.д. и когда наше число будет превышать значения входящего числа мы выведем счетчик (кол-вл умножений))

int VariantSimple()
{
    int numberLength = 0; //вводим переменную
    int digits = 1;      //переменная для разряда

    while (digits < inputNumber)
    {
        digits = digits * 10;  //будем число умножать на 10 и когда наще число станет больше вхдящего числа выведим значение
        numberLength++; // счетчик // инкремент
    }
    return numberLength;  // возвращаем из этого метода длину
}


//метод решения через логарифм
int VariantLog10()
{
    return (int)Math.Log10(inputNumber)+1;  // обращаемся к матеаматической функции и и находим логорифм 10 нашего числа
}

// вводим переменную
int result = 0;

//Вызываем методы по очереди

result = VariantChar(); // так как метод возвращает значение int мы кладем его в переменную result
Console.WriteLine(result);

result = VariantSimple();  // оператор = кладет из того что справа в то что слева
Console.WriteLine(result);  // выводим результат в консоль

result = VariantLog10();
Console.WriteLine(result);