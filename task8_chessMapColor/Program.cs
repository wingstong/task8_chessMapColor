using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите координаты обоих полей через пробел (например, a1 b4):");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');
            string firstField = coordinates[0];
            string secondField = coordinates[1];

            char firstXChar = firstField[0];
            char firstYChar = firstField[1];
            char secondXChar = secondField[0];
            char secondYChar = secondField[1];

            static bool IsValidCoordinate(char x, char y)
            {
                return x >= 'a' && x <= 'h' && y >= '1' && y <= '8';
            }

            if (!IsValidCoordinate(firstXChar, firstYChar) || !IsValidCoordinate(secondXChar, secondYChar) || input.Length != 5 || coordinates.Length != 2)
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            static bool IsSameColor(char x1, char y1, char x2, char y2)
            {
                int x1Int = x1 - 'a'; // Вычитаем код символа
                int y1Int = y1 - '1';
                int x2Int = x2 - 'a';
                int y2Int = y2 - '1';

                return (x1Int + y1Int) % 2 == (x2Int + y2Int) % 2;
            }

            if (IsSameColor(firstXChar, firstYChar, secondXChar, secondYChar))
            {
                Console.WriteLine("Поля одного цвета\n");
            }
            else
            {
                Console.WriteLine("Поля разного цвета\n");
            }
        }
    }
}
