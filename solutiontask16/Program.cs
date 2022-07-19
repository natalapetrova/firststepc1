//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру обозначающую день недели");
string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 8 )
{
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник. Не выходной";
    dayOfWeek[1] = "Вторник. Не выходной";
    dayOfWeek[2] = "Среда. Не выходной";
    dayOfWeek[3] = "Четверг. Не выходной";
    dayOfWeek[4] = "Пятница. Не выходной";
    dayOfWeek[5] = "Суббота. Выходной";
    dayOfWeek[6] = "Воскресенье. Выходной";

    Console.WriteLine(dayOfWeek[inputNumber-1]);
}
else
{
           Console.WriteLine("Данная цифра не обозначает день недели, введите значение от 1 до 7");

}
}