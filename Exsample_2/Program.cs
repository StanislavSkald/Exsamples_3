// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int CoordInt(){return Convert.ToInt32 (Console.ReadLine());}

Console.WriteLine ("Ведите координаты двух точек в 3D пространстве");
int x1 = CoordInt();
int y1 = CoordInt();
int z1 = CoordInt();
int x2 = CoordInt();
int y2 = CoordInt();
int z2 = CoordInt();
double res = Math.Sqrt (Math.Pow (x2 - x1, 2) + Math.Pow (y2 - y1, 2) + Math.Pow (z2 - z1, 2));
Console.WriteLine (res);