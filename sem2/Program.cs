// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int Sum(int number)
// {
//    int sum = 1;
//    for(int i = 1; i <= number; i++)
//    {
//        sum*=i;
//    }
//    return sum;
// }

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(N);
// Console.WriteLine(sum);

// Задача 30:

int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
}

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}