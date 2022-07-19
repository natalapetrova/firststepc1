//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    char[] numberArray = inputLine.ToCharArray();
    int inputNumber = int.Parse(inputLine);

    if (inputNumber > 99 )
        {
           Console.WriteLine(numberArray[2]);
        }
    else
    {
           Console.WriteLine("Третьей цифры нет");

    }
}