// В двумерном массиве n×k заменить четные элементы на противоположные
void FillMatrix( int[,] matrix)
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i, j] = new Random().Next(1,10); // Заполняем рандомными числами
        }
    
    }


}

void PrintMatrix(int [,] matrix) // функция печати матрицы
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}
Console.Clear();  
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);

for ( int  i = 0; i < matrix.GetLength(0); i++)
{
    for ( int j = 0; j < matrix.GetLength(1) ; j++)
    {
        if ( matrix[i, j] % 2 == 0 )
        matrix[i,j] = matrix[i,j]*-1; 
    }
    
}
Console.WriteLine();
PrintMatrix(matrix);