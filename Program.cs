// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Пожалуйста! Введите день недели и мы проверим, является ли он выходным");
int number = Convert.ToInt32(Console.ReadLine());
bool Weekend(int number)
{
    if (number > 5)
    {
        return true;
    }
    return false;
}
bool CorrectWeekDay(int number)
{
    if (number <= 0 || number > 7)
    {
        Console.WriteLine("Не корректный ввод. Число не соответствует дню недели");
        return false;
    }
    return true;
}
if (CorrectWeekDay(number))
{
    if (Weekend(number))
    {
        Console.WriteLine("Да это выходной день!");
    }
    else
        Console.WriteLine("Нет это интересный рабочий день! Успехов и свежих идей!");
}