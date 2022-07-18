//Первое решение
// string? inputLineOne = Console.ReadLine();
// string? inputLineTwo = Console.ReadLine();

// if(inputLineOne != null && inputLineTwo != null)
// {
//     int inputNumberOne = int.Parse(inputLineOne);
//     int inputNumberTwo = int.Parse(inputLineTwo);

//     int div = inputNumberTwo%inputNumberOne;
//     if(div == 0)
//     {
//         Console.WriteLine("yes");
//     }
//     else
//     {
//         Console.WriteLine(div);

//     }
// }

//Второе решение
Console.Write("Enter first number: ");
string? firstLine = Console.ReadLine();
Console.Write("Enter second number: ");
string? secondLine = Console.ReadLine();
int first = int.Parse(firstLine);
int second = int.Parse(secondLine);

if(second%first == 0)
{
        Console.WriteLine("Кратное");
}
else
{
        Console.WriteLine("Не кратное, " + second%first);
}
