// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = number / 2 ;

if (num % 2 == 0 )

{
    Console.WriteLine($"{num} Да");
}

else
{
    Console.WriteLine($"{num} Нет");
}