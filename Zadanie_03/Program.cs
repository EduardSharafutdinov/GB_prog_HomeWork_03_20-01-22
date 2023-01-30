// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число до которой надо вычислить произведения: ");
int N = int.Parse(Console.ReadLine()!);
int number =1;
int p=1;

for (int i=number; i<=N; i++)
{
    p=p*i;
    Console.WriteLine(p);
}

