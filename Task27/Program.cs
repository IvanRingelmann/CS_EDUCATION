// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите любое целое число: ");

int i = Convert.ToInt32(Console.ReadLine());

int head = i;

int summ = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
summ = summ + num;
}

Console.WriteLine($"{head} -> " + summ);
