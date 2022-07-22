Console.WriteLine("Введите 5-ти значное число");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    char[] numberArray = inputLine.ToCharArray();
    if (numberArray.Length == 5)
    {
        if ((numberArray[0] == numberArray[4]) && (numberArray[1] == numberArray[3]))
        {
            Console.WriteLine("Число палиндром");
        }
        else
        {
            Console.WriteLine("Число не палиндром");
        }
    }

    else
        {
            Console.WriteLine("Число не пятизначное");
        }
}