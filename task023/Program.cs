// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
int Prompt (string msg)
{
    Console.Write (msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void CubeNumber (int num)
{
    for(int i = 1; i <= num; i++)
    {
        double cubeNum = Math.Pow(i, 3);
        Console.Write($"{cubeNum} ");
    }
}
int num = Prompt("Введите число: ");
CubeNumber(num);