//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 1000 && inputNumber > 99)
{
char[] numberTwo = inputLine.ToCharArray();
Console.WriteLine(numberTwo[1]);
}
else
{
Console.WriteLine("Число не соответсвует трехзначному значению");
}
}