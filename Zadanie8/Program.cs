// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите целое число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number1 = 2;
// if (number2 < 2)


// {
//     Console.WriteLine($"{number2} Неверный ввод");
// }

// if (number2 % 2 == 0)

// {
//     Console.Write(number2++);
// }

// Console.WriteLine(number2);




 
        
        Console.Write("Напишите целое число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number2 < 2)

        {
            Console.WriteLine($"{number2} Неверный ввод");
        }

        
        for (int i = 1; i <= number2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();