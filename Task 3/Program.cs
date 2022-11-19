// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
 if (i==1){
    Console.WriteLine("Не выходной день");
 }
if (i==2){
    Console.WriteLine("Не выходной день");
}
if (i==3){
    Console.WriteLine("Не выходной день");
}
if (i==4){
    Console.WriteLine("Не выходной день");
}
if (i==5){
    Console.WriteLine("Не выходной день");
}
else if (i==6 || i==7){
    Console.WriteLine("Выходной день");
}