// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number>100)
   {
   int a = number % 10 ;
   Console.WriteLine("Третья цифра: " + a);
   }
else
{
Console.WriteLine("третей цифры нет");
}