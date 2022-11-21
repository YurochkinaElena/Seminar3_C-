// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите значения x1: ");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения y1: ");
var y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения x2: ");
var x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения y2: ");
var y2 = Convert.ToInt32(Console.ReadLine());
var result = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));
Console.WriteLine(result);
