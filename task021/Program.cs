// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt (string msg)
{
    Console.Write (msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
// double distAB = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
double distAB = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
Console.Write ($"Расстояние между точками AB в 3D пространстве равно {Math.Round(distAB,4)}");
}

int x1 = Prompt("Введите координату x1 точки A: ");
int y1 = Prompt("Введите координату y1 точки A: ");
int z1 = Prompt("Введите координату z1 точки A: ");
int x2 = Prompt("Введите координату x2 точки B: ");
int y2 = Prompt("Введите координату y2 точки B: ");
int z2 = Prompt("Введите координату z2 точки B: ");
Dist (x1, y1, z1, x2, y2, z2);
