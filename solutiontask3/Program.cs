// Первый варинат решения
string? inputLineOne = Console.ReadLine();

if(inputLineOne != null)
{
    int inputNumber = int.Parse(inputLineOne);

    int startNumber = (inputNumber * -1);

    string lineOutput = "";

    while (startNumber < inputNumber)
    {
        lineOutput = lineOutput+startNumber+", ";
        startNumber++;
    }

    Console.WriteLine(lineOutput);
}

// Второй вариант решения
// string? inputLineOne = Console.ReadLine();

// if(inputLineOne != null)
// {
//     int inputNumber = int.Parse(inputLineOne);

//     int startNumber = 1;

//     string lineOutput = "0";

//     while (startNumber <= inputNumber)
//     {
//         lineOutput = startNumber*(-1)+", "+lineOutput+", "+startNumber;
//         startNumber++;
//     }

//     Console.WriteLine(lineOutput);
// } 