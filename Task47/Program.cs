Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];
Random r = new Random();

for (int i = 0; i<n; i++)
{
    for (int j = 0; j < m; j++)
    {
    matrix[i, j] = Convert.ToDouble(r.Next(-100, 100)/10.0);
     Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

