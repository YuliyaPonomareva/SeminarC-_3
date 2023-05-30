/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int Prompt (string msg)
{
    Console.Write (msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Palindrome (int num)
{
    int a = num / 10000;
    int a1 = num % 10;
    int num1 = (num - a * 10000) / 10;
    int b = num1 / 100;
    int b1 = num1 % 10;

    if (a==a1 && b==b1)
    {
    Console.WriteLine($"Да, число {num} - палиндром!"); 
    }
    else
    {
        Console.WriteLine($"Нет, число {num} не является палиндромом!");
    }
}
int num = Prompt("Введите пятизначное число: ");
Palindrome(num);