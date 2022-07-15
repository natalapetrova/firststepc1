//Напишите программу, которая на вход принммает два числа и выдает, какое число больше, а какое меньше.
//
string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null)
{
    int inputNumberOne = int.Parse(inputLineOne);
    int inputNumberTwo = int.Parse(inputLineTwo);
    
    if(inputNumberOne > inputNumberTwo)
    {
        Console.Write("max = ");
        Console.Write(inputNumberOne);
        Console.Write(" min = ");
        Console.Write(inputNumberTwo);
    }
    else
    {
        Console.Write("max = ");
        Console.Write(inputNumberTwo);
        Console.Write(" min = ");
        Console.Write(inputNumberOne);
    }
}