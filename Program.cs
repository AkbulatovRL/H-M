// Напишите программу,
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int i;
Console.WriteLine("Введите число");
i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((i/10)%10);

