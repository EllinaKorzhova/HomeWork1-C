/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine ("Напишите первое число: ");
string numberStr1 = Console.ReadLine();
int number1 = int.Parse(numberStr1);
Console.WriteLine ("Напишите второе число: ");
string numberStr2 = Console.ReadLine();
int number2 = int.Parse(numberStr2);
Console.WriteLine ("Напишите третье число: ");
string numberStr3 = Console.ReadLine();
int number3 = int.Parse(numberStr3);

/*int max = Math.Max(number1, Math.Max(number2, number3));
*/

int max = number1;

if (number2 > max) {
    max = number2;
}
if (number3 > max){
    max = number3;
}
Console.WriteLine ($"Максимальное число {max} ");