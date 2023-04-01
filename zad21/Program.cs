// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("X координата первой точки");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Y координата первой точки");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Z координата первой точки");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("X координата второй точки");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Y координата второй точки");
int уb = int.Parse(Console.ReadLine());
Console.WriteLine("Z координата второй точки");
int zb = int.Parse(Console.ReadLine());

double segment = Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((уb-ya),2)+ Math.Pow((zb-za),2));

Console.WriteLine(segment);