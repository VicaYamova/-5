int summ = 0;
Random Rnd = new Random();
int[] a = new int[10];
Console.Write("Исходный массив:");


for (int i = 0; i < a.Length; i++)
{
a[i] = Rnd.Next(1, 10);
Console.Write(a[i] + " ");
}
Console.WriteLine();
Console.Write("Результат: ");

for (int i = 0; i < a.Length; i++)
{
if (a[i] % 2 == 1)
{
summ = a[i] + summ ;
}

}
Console.Write(summ);