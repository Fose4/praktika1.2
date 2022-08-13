// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X для первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X для второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для второй точки: ");
int y2 = int.Parse(Console.ReadLine());

double cord = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

Console.WriteLine(Math.Round(cord, 2));