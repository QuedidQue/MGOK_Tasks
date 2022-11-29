Console.Write("Введите количество Столбцов: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество Строк: ");
int y = int.Parse(Console.ReadLine());
int[,] myArray = new int[x, y];
Console.WriteLine();

Console.WriteLine("Заполни матрицу");

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write("array[" + i + "," + j + "]: ");
        myArray[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write(" array[" + i + "," + j + "]: " + myArray[i, j] + "\t");
    }
        Console.WriteLine();
}
Console.ReadLine();

