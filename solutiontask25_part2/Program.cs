Console.Clear();
Console.WriteLine("Введите операцию используя один из знаков + - / * ^");
Console.WriteLine("В данном формате используйте целые числа");

void Calculate(string[] getNum)
{
    double result;

    switch (getNum[1])
    {
        case "+":
            result = int.Parse(getNum[0]) + int.Parse(getNum[2]);
            Console.WriteLine(getNum[0] + " " + getNum[1] + " " + getNum[2] + " = " + result);
            break;

        case "-":
            result = int.Parse(getNum[0]) - int.Parse(getNum[2]);
            Console.WriteLine(getNum[0] + " " + getNum[1] + " " + getNum[2] + " = " + result);
            break;

        case "*":
            result = int.Parse(getNum[0]) * int.Parse(getNum[2]);
            Console.WriteLine(getNum[0] + " " + getNum[1] + " " + getNum[2] + " = " + result);
            break;

        case "/":
            result = int.Parse(getNum[0]) / int.Parse(getNum[2]);
            Console.WriteLine(getNum[0] + " " + getNum[1] + " " + getNum[2] + " = " + result);
            break;

        case "^":
            result = Math.Pow(int.Parse(getNum[0]), int.Parse(getNum[2]));
            Console.WriteLine(getNum[0] + " " + getNum[1] + " " + getNum[2] + " = " + result);
            break;

        default:
        Console.Write("Введен неверный формат");
        break;
    }
}

try
{
    string[] operation = Console.ReadLine().Split(" ");

    Calculate(operation);
}
catch
{

    Console.WriteLine("");

}
