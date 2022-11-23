//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

string arr = $"{num}";

if (num<10000 || num>99999)
{
    Console.WriteLine("Число должно состоять из пяти знаков.Попробуйте снова.");
}
else if (arr[0] == arr[4] && arr[1] == arr[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
