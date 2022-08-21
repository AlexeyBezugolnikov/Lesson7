Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[5, 5];

for (int i = 0; i < 5; i++) 
{
    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = new Random().Next(-10,10); 
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
int flag = 0;
for (int i = 0; i < 5; i++) 
{
    for (int j = 0; j < 5; j++) 
    {
        if (i == n && j == m) 
        {
            Console.WriteLine(matrix[i, j]);
            flag++;
        }
        
    }
    Console.WriteLine();
}
if (flag==0)
Console.WriteLine("Такого элемента нет");

