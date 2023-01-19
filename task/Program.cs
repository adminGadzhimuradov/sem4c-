// Задача.32 Напишите программу которая заменяет элементы массива
// положительные элементы замените на соотвествующие отрицательные и наоборот

int[] FillArrayWithRandom(int [] array)
{
    for(int i = 0; i < array.Length; i++)

{
    array[i] = new Random().Next(-9, 10);
}
return array;
}

int[] array = new int[5];
array = FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(", ", array));
for(int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}
Console.WriteLine();
Console.Write(string.Join(", ", array));
