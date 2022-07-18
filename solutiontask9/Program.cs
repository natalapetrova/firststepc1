System.Random numberSintezator = new Random();
// int number = numberSintezator.Next(10,100);

//     Console.WriteLine(number);


// int firstNumber = number/10;
// int secondNumber = number%10;

// if(firstNumber > secondNumber)
// {
//     Console.WriteLine(firstNumber);
// }

// else
// {
//     Console.WriteLine(secondNumber);

// }

// Второй вариант
// int numberStart = new Random().Next(10, 100);

// Console.Write("The random number is: ");
// Console.WriteLine(numberStart);

// string stringNum = numberStart.ToString();

// Console.Write("The biggest digit is: ");
// if (stringNum[0] > stringNum[1])
// {
//     Console.WriteLine(stringNum[0]);
// }
// else
// {
//     Console.WriteLine(stringNum[1]);

// }

//Третий вариант
char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();

Console.WriteLine(digits);

int firstNumber = ((int)digits[0]) - 48;
int secondNumber = ((int)digits[1]) - 48;

int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;

Console.WriteLine(resultNumber);
