// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число до которой будут возводиться в кубы: ");
int N = int.Parse(Console.ReadLine()!);
int number = 1;
int stepen = 3;
int kub = 1;

while (number <= N)
{
    kub = Convert.ToInt32(Math.Pow(number, stepen));
    if (kub%2==0) Console.WriteLine(kub);
    number++;
}