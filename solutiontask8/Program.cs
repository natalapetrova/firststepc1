string? inputLineOne = Console.ReadLine();

if(inputLineOne != null)
{
    int inputNumber = int.Parse(inputLineOne);

    int startNumber = (2);

    string lineOutput = "";

    while (startNumber < inputNumber)
    {
        lineOutput = lineOutput+startNumber+", ";
        startNumber = startNumber + 2;
    }

    Console.WriteLine(lineOutput);
}