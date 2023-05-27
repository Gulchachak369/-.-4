// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number) 
{
    int sum = 0; 
    int[] arr = new int [number];
    int n = arr.Length;
    int i = 0;
    while (i < n)
    {
        sum = sum+arr[i];
        i++;
    }
    return sum;
}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = Sum(num);
System.Console.WriteLine($"Сумма цифр в числе = {sum}");
