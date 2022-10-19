// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}

Console.WriteLine(InCenter(num));