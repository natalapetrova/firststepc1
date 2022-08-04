Console.Write("Введите число: ");


// глобальная переменная
int inputNumber = int.Parse(Console.ReadLine());

void VariantSimple()
{
    // переменная которая будет накапливать значения
    int sumOfNumbers = 0;

    for (int i = 1; i <= inputNumber; i++)
    {
        sumOfNumbers += i;
        //sumOfNumbers = sumOfNumbers + i;
    }
    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

void VariantGauss()
{
    int sumOfNumbers = 0;

    sumOfNumbers = ((inputNumber + 1) * inputNumber) / 2;

    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);

}

VariantSimple();

VariantGauss();