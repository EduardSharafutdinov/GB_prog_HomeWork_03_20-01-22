// Подсчитать сумму цифр в числе

Console.Write("Введите число у которого надо подсчитать сумму цифр: ");
int N = int.Parse(Console.ReadLine()!); 
int sum = 0;

while (N != 0)
{
    sum += N % 10;
    N / 10;   
}

Console.WriteLine(sum);
