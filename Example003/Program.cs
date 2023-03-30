/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/


void Random(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];

Random(numbers);

PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"Разница между максимальным и минимальным = {max - min}");