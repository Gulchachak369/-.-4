// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int multiplication(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult *= i;
    }
    return mult;
}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int mult = multiplication(num);
System.Console.WriteLine($"Произведение от 1 до {num} = {mult}");

