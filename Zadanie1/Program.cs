Console.Write("Введите длину стороны квадрата: ");
int sideLength = int.Parse(Console.ReadLine());

Console.Write("Введите символ для квадрата: ");
char symbol = Console.ReadLine()[0];

PrintSquare(sideLength, symbol);

static void PrintSquare(int sideLength, char symbol)
{
    for (int i = 0; i < sideLength; i++)
    {
        for (int j = 0; j < sideLength; j++)
        {
            Console.Write(symbol);
        }
        Console.WriteLine();
    }
}