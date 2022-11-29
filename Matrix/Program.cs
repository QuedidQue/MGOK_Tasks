int[,] myArray = new int[,]
{
    { 2, 435, 546, 65,4 },
    { 76,36,75,3,57 },
    { 2458,586,42,5,74 }
};
for (int y = 0; y < myArray.GetLength(0); y++)
{
    for (int x = 0; x < myArray.GetLength(1); x++)
    {
        Console.Write(myArray[y, x] + "\t");
    }
    Console.WriteLine();
}
