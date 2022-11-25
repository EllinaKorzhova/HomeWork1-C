/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/

Console.WriteLine ("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number % 2 == 0) {
    Console.WriteLine ($" число {number} четное");
} else {
    Console.WriteLine ($" число {number} НЕчетное");
}
