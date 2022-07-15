//Напишите программу, которая на вход принммает три числа и выдает максимальное из этих чисел.
//
string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();
string? inputLineThree = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null && inputLineThree != null)
{
    int inputNumberOne = int.Parse(inputLineOne);
    int inputNumberTwo = int.Parse(inputLineTwo);
    int inputNumberThree = int.Parse(inputLineThree);
    
    if(inputNumberOne > inputNumberTwo)
    {
        if(inputNumberOne > inputNumberThree)
        {
            Console.Write(inputNumberOne);
        }
        else
        {
            Console.Write(inputNumberThree);
        }
    }
    else
    {
        if(inputNumberTwo > inputNumberThree)
        {
            Console.Write(inputNumberTwo);
        }
        else
        {
            Console.Write(inputNumberThree);
        }
    }
}
