Console.WriteLine("Введите размерность массива");
int raz=Convert.ToInt32(Console.ReadLine());
int[] mass = new int[raz];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < raz; i++)
{
    mass[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < raz; i++)
{
    Console.Write($" {mass[i]}");
}
{
    for (int i = 1; i < raz; i += 2)
    {
        int temp = mass[i];
        mass[i] = mass[i-1];
        mass[i-1] = temp;
    }
}
for(int i = 0; i < raz; i++)
{
    Console.Write($" {mass[i]}");
}