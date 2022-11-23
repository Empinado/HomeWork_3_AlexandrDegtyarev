// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//

Console.WriteLine("Введите координату х первой точки:");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки:");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки:");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату х второй точки:");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки:");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки:");
int Bz = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Round(Math.Sqrt(Math.Pow(Bx-Ax,2) + Math.Pow(By-Ay,2)+ Math.Pow(Bz-Az,2)),2);

Console.WriteLine($"Растояние между точками = {distanse}");