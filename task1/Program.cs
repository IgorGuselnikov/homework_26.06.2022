// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int firstStep = number / 10;
    int secondStep = firstStep % 10;
    Console.WriteLine("Давайте выведем вторую цифру числа:" + secondStep);
}
else 
{
    Console.Write ("Введено число не соответствующее формату задания");
}

