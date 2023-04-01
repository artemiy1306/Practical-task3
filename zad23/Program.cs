// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number;i++) 
{
double cube = Math.Pow(i,3);
Console.WriteLine($"{cube}");
}

