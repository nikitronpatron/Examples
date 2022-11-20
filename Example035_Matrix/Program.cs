// string[,] table = new string[2, 3];
// // обращение к нужному элементу // индексы от нуля // в моем случае максимальный индекс строки 1 столбца 2
// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 3; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < 3; rows++) // matrix.GetLength(0) - вместо 3
    {
        for (int columns = 0; columns < 4; columns++) // matrix.GetLength(1) - вместо 4
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(matrix);
Console.WriteLine();
void FillArray(int[,] matr)
{
    for (int rows = 0; rows < 3; rows++)
    {
        for (int columns = 0; columns < 4; columns++)
        {
            matr[rows, columns] = new Random().Next(1, 10);
        }
    }
}
FillArray(matrix);
PrintArray(matrix);