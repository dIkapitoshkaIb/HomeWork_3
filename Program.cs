//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int pow = a;

for (int i = 1; i < b; i++)
{
    pow = pow * a;
}
Console.WriteLine("A в степени B равно: " + pow);




//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/* Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("Сумма всех цифр числа: " + sum); */




//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.

/* int[] num = new int[8];
Console.Write("[");

for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(0, 99);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return num[a];
} */