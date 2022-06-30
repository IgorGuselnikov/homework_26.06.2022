// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите пожалуйста номер дня в неделе");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay >= 1 && numberDay <= 7)
{
    if (numberDay == 6 || numberDay == 7)
    {
        Console.WriteLine("Сегодня выходной день");
    }
    else 
    {
        Console.WriteLine("Сегодня рабочий день");
    }
}
else
{ 
    Console.WriteLine("Таких дней недели не существует!");
}
