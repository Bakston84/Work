string[,] table = new string[2, 5];  //инициализация строкового двумерного массива с 2-мя строчками и 5-ю столбцами
// String.Empty (инициализация строк)
// table[0, 0]  table[0, 1] table[0, 2]...table[0, 4]
// table[1, 0]  table[1, 1] table[1, 2]...table[1, 4]

table[1, 2] = "string";  //обращаемся к нужному элименту в 1-вой строке 2-го столбца массива

for (int rows = 0; rows < 2; rows++)    //цикл для строк
{
    for (int columns = 0; columns < 5; columns++)   //цикл для столбцов
    {
        System.Console.Write($"|{table[rows, columns]}| ");    //выводим двумерный массив в консоль
    }
    System.Console.WriteLine();
}

void PrintArray(int[,] matrix)  //функция вывода двумерного массива
{

    for (int i = 0; i < matrix.GetLength(0); i++)    //цикл для строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //цикл для столбцов
        {
            System.Console.Write($"|{matrix[i, j]}| ");    //выводим двумерный массив в консоль
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matrix)   //функция генирации двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)    //цикл для строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //цикл для столбцов
        {
            matrix[i, j] = new Random().Next(1, 10);   //генерируем в двумерный массив гениратором случайных чисел элементы по индексу i, j с интервалом от 1 до 10
        }
    }
}

int[,] printMatrix = new int[3, 4];  //инициализация числового двумерного массива с 3-мя строчками и 4-мя столбцами
FillArray(printMatrix);
PrintArray(printMatrix);