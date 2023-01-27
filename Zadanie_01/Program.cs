// Найти кубы чисел от 1 до N

Console.Write("Введите число от 1, до которого надо возводить в кубы: ");
int N = int.Parse(Console.ReadLine()!);  //Число на котором остановится возведение в куб
int number = 1;

while (number <= N)
{
    Console.WriteLine(number * number * number);
    number++;
}

