// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if ((num/10000 == num%10) && ((num/1000)%10 == (num%100)/10))
{
Console.WriteLine("да");
}
else     Console.WriteLine("нет"); 