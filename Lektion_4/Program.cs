void MassiveString()
{
    string[,] table = new string[2, 5];
// string.Empty - инициализация строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] 
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] 

    table[1, 2] = "слово";

    for (int rows = 0; rows < 2; rows++)
    {
        for (int colums = 0; colums < 5; colums++)
        {
            Console.WriteLine($"{table[rows, colums]} - ");
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) - количество строк в массиве
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) - количество столбцов в массиве
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        matr[i, j] = new Random().Next(1,10);   // [1, 10)
    }
}

int[,] pic = new int[,]
// Если есть фиксированные данные, 
// указание размера строк и столбцов можно не указывать
{
    {0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 1, 0, 0},
    {0, 1, 0, 0, 0, 1, 0},
    {1, 0, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 1, 1, 1},
};

void PrintImage(int[,] image) // заполнение пробелами и +
{
    for (int i = 0; i < image.GetLength(0); i++) 
    {
        for (int j = 0; j < image.GetLength(1); j++) 
        {
            //Console.Write($"{matr[i, j]} ");
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine();
    }
}

void FillImage(int row, int col) // раскрашивание замкнутой области 1 (+)
{
    if (pic[row, col] == 0) 
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic);
FillImage(2, 3);
PrintImage(pic);

//int[,] matrix = new int[3, 4];
//PrintArray(matrix);
//FillArray(matrix);
//Console.WriteLine();
//PrintArray(matrix);




// MassiveString();