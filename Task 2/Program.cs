// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int b;
Console.WriteLine("Введите число");
b = Convert.ToInt32(Console.ReadLine());

if (b > 100) {
Console.WriteLine(b%10);
}

else {
    Console.WriteLine("Третьей цифры нет");
}