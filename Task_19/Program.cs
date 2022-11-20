// Напишите программу, которая принимает на вход
//  пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");

int numIn = Convert.ToInt32(Console.ReadLine());
int multiply = 10000;
int result = 0;
int numInInitial = numIn;

for (int i = 0; i <= 4; i++)
{
    int remainder = numIn % 10;
    numIn = numIn / 10;
    result = result + remainder * multiply;
    multiply = multiply / 10;
}
if (numInInitial < 10000 || numInInitial > 99999)
{
    Console.WriteLine($"Число {numInInitial} вне диапазона");
}
else if (result == numInInitial && result != 0)
{
    Console.WriteLine($"Число {numInInitial} палиндром");
}
else
{
    Console.WriteLine($"Число {numInInitial} не является палиндромом");
}