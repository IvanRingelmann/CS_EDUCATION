// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите Пятизначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num/10000 == num%10) && ((num/1000)%10 == (num%100)/10)) {
    Console.Write(" -> Да ");
} else {
    Console.Write(" -> Нет ");
}