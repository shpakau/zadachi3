// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Как вы мне и писали, делаю одним блоком
Console.WriteLine("Задача 19");
Console.Write("Введите число согласно условию задачи: ");
string? palindrom = Console.ReadLine();

void CheckingPalindrom(string palindrom)
{
    if (palindrom[0] == palindrom[4] || palindrom[1] == palindrom[3])
        {
            Console.WriteLine($"Введенное число: {palindrom} - является палиндромом. Ура!");
        }
    else Console.WriteLine($"Введенное число: {palindrom} - не палиндром.");
// проверили условие на палиндром
}
if (palindrom!.Length == 5)
{
    CheckingPalindrom(palindrom);
}
else Console.WriteLine($"Не правильное число.");