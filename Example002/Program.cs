//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void Random(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
}


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
Random(numbers);

PrintArray(numbers);

int sum = 0;

for (int z = 1; z < numbers.Length; z += 2)
    sum = sum + numbers[z];

Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");