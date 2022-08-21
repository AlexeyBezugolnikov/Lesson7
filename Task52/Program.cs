Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[n, m];
double s = 0;
double sr = 0;

for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++) {
        matrix[i, j] = new Random().Next(1,10); 
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int j = 0; j < m; j++) 
{
    for (int i = 0; i < n; i++) 
    {
        s = s + matrix[i, j];
        sr = s/m;
    }
    Console.WriteLine(sr);
    s = 0;
}