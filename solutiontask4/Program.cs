//Первое решение
// string? inputLine = Console.ReadLine();

// if(inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);

//     int outputNumber = inputNumber%10;

//     Console.WriteLine(outputNumber);
// }

//Второе решение
// string? inputLineOne = Console.ReadLine();

// if(inputLineOne != null)
// {
//     string lastNum = inputLineOne.Substring(2,1);
//     Console.WriteLine(lastNum);
// }

//Третий вариант решения
string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    char[] M = inputLine.ToCharArray();
    Console.WriteLine(M[2]);
}