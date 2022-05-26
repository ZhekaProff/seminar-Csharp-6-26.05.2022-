// В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
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

int[,] matrix = new int[3, 3];

Console.Write("Введите искомое число: ");
int count = int.Parse(Console.ReadLine());

bool isHas = false;
FillMatrix(matrix);
PrintMatrix(matrix);

for (int i=0; i< matrix.GetLength(0); i++)
    for (int j=0; j< matrix.GetLength(1); j++)
        if (matrix[i,j] == count)
        {
            Console.WriteLine($"Число {count} есть в заданном массиве в {i+1} строке, в {j+1} столбце");
            isHas = true;
        }
if (!isHas) Console.WriteLine($"Числа {count} нет в заданном массиве");