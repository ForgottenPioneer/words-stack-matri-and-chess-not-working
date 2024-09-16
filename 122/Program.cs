//using System;
//using System.Text;


//class Program
//{
//    static void Main()
//    {
//        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
//        var enc1251 = Encoding.GetEncoding(1251);

//        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
//        System.Console.InputEncoding = enc1251;
//        // Ввод размеров первой матрицы
//        Console.WriteLine("Введите размеры первой матрицы (MxN):");
//        int M = int.Parse(Console.ReadLine());
//        int N = int.Parse(Console.ReadLine());

//        // Ввод первой матрицы
//        int[,] matrixA = new int[M, N];
//        Console.WriteLine("Введите элементы первой матрицы:");
//        for (int i = 0; i < M; i++)
//        {
//            for (int j = 0; j < N; j++)
//            {
//                matrixA[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        // Ввод размеров второй матрицы
//        Console.WriteLine("Введите размеры второй матрицы (LxF):");
//        int L = int.Parse(Console.ReadLine());
//        int F = int.Parse(Console.ReadLine());

//        // Проверка возможности перемножения
//        if (N != L)
//        {
//            Console.WriteLine("Перемножение матриц невозможно. Число столбцов первой матрицы должно равняться числу строк второй.");
//            return;
//        }

//        // Ввод второй матрицы
//        int[,] matrixB = new int[L, F];
//        Console.WriteLine("Введите элементы второй матрицы:");
//        for (int i = 0; i < L; i++)
//        {
//            for (int j = 0; j < F; j++)
//            {
//                matrixB[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        // Создание результирующей матрицы
//        int[,] resultMatrix = new int[M, F];

//        // Перемножение матриц
//        for (int i = 0; i < M; i++)
//        {
//            for (int j = 0; j < F; j++)
//            {
//                resultMatrix[i, j] = 0;
//                for (int k = 0; k < N; k++)
//                {
//                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
//                }
//            }
//        }

//        // Преобразование результирующей матрицы в одномерный массив для сортировки
//        int size = M * F;
//        int[] flatResult = new int[size];
//        int index = 0;

//        for (int i = 0; i < M; i++)
//        {
//            for (int j = 0; j < F; j++)
//            {
//                flatResult[index++] = resultMatrix[i, j];
//            }
//        }

//        // Сортировка результирующей матрицы
//        Array.Sort(flatResult);

//        // Вывод отсортированной матрицы
//        Console.WriteLine("Отсортированная результирующая матрица:");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write(flatResult[i] + " ");
//            if ((i + 1) % F == 0)
//                Console.WriteLine();
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Text;

//class Program
//{
//    static HashSet<string> usedWords = new HashSet<string>();
//    static string lastWord = string.Empty;

//    static void Main()
//    {
//        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
//        var enc1251 = Encoding.GetEncoding(1251);

//        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
//        System.Console.InputEncoding = enc1251;
//        Console.WriteLine("Добро пожаловать в игру 'Слова'!");
//        Console.WriteLine("Игроки по очереди вводят слова, которые начинаются на последнюю букву предыдущего слова.");
//        Console.WriteLine("Введите 'сдаться', чтобы выйти из игры.\n");

//        while (true)
//        {
//            Console.Write("Игрок 1, введите слово: ");
//            if (!PlayerTurn(1))
//                break;

//            Console.Write("Игрок 2, введите слово: ");
//            if (!PlayerTurn(2))
//                break;
//        }

//        Console.WriteLine("Игра окончена!");
//    }

//    static bool PlayerTurn(int playerNumber)
//    {
//        string input = Console.ReadLine().Trim().ToLower();

//        // Проверка на сдачу
//        if (input == "сдаться")
//        {
//            Console.WriteLine($"Игрок {playerNumber} сдался. Игра окончена.");
//            return false;
//        }

//        // Проверка на пустой ввод
//        if (string.IsNullOrWhiteSpace(input))
//        {
//            Console.WriteLine("Слово не может быть пустым. Попробуйте снова.");
//            return true;
//        }

//        // Проверка на уникальность слова
//        if (usedWords.Contains(input))
//        {
//            Console.WriteLine("Это слово уже было использовано. Попробуйте снова.");
//            return true;
//        }

//        // Проверка на соответствие правилам
//        char requiredLetter = GetLastValidLetter(lastWord);

//        if (lastWord != string.Empty && input[0] != requiredLetter)
//        {
//            Console.WriteLine($"Слово должно начинаться на '{requiredLetter}'. Попробуйте снова.");
//            return true;
//        }

//        // Добавление слова в список использованных
//        usedWords.Add(input);
//        lastWord = input;

//        Console.WriteLine($"Игрок {playerNumber} ввёл слово: {input}");
//        return true;
//    }

//    static char GetLastValidLetter(string word)
//    {
//        if (string.IsNullOrEmpty(word))
//            return '\0';

//        char lastChar = word[word.Length - 1];

//        // Если последний символ - мягкий знак, берем предыдущий
//        if (lastChar == 'ь' && word.Length > 1)
//            lastChar = word[word.Length - 2];

//        return lastChar;
//    }
//}
















//using System;
using System.Collections.Generic;
using System.Text;

//namespace MeatRecipe
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
//                  var enc1251 = Encoding.GetEncoding(1251);

//                  System.Console.OutputEncoding = System.Text.Encoding.UTF8;
//                    System.Console.InputEncoding = enc1251;
//            Console.WriteLine("Введите количество мяса в кг или граммах:");
//            string input = Console.ReadLine();
//            double meatQuantity;

//            if (input.Contains("кг"))
//            {
//                meatQuantity = double.Parse(input.Replace("кг", ""));
//            }
//            else if (input.Contains("г"))
//            {
//                meatQuantity = double.Parse(input.Replace("г", "")) / 1000;
//            }
//            else
//            {
//                Console.WriteLine("Неправильный формат ввода. Пожалуйста, введите количество мяса в кг или граммах.");
//                return;
//            }

//            Console.WriteLine("Введите время приготовления в минутах (опционально):");
//            string timeInput = Console.ReadLine();
//            int cookingTime = 0;

//            if (!string.IsNullOrEmpty(timeInput))
//            {
//                cookingTime = int.Parse(timeInput);
//            }

//            Console.WriteLine("Введите ингредиенты (опционально), разделенные запятыми:");
//            string ingredientsInput = Console.ReadLine();
//            List<string> ingredients = new List<string>();

//            if (!string.IsNullOrEmpty(ingredientsInput))
//            {
//                ingredients = ingredientsInput.Split(',').Select(i => i.Trim()).ToList();
//            }

//            Recipe recipe = GetOptimalRecipe(meatQuantity, cookingTime, ingredients);

//            if (recipe != null)
//            {
//                Console.WriteLine("Оптимальный рецепт:");
//                Console.WriteLine($"Блюдо: {recipe.Dish}");
//                Console.WriteLine($"Ингредиенты: {string.Join(", ", recipe.Ingredients)}");
//                Console.WriteLine($"Время приготовления: {recipe.CookingTime} минут");
//                Console.WriteLine($"Инструкции: {recipe.Instructions}");
//            }
//            else
//            {
//                Console.WriteLine("Не удалось найти подходящий рецепт.");
//            }
//        }

//        static Recipe GetOptimalRecipe(double meatQuantity, int cookingTime, List<string> ingredients)
//        {
//            // Здесь можно реализовать логику поиска оптимального рецепта
//            // на основе введенных данных и базы рецептов
//            // Для примера, мы будем использовать простую логику

//            if (meatQuantity < 0.5)
//            {
//                return new Recipe
//                {
//                    Dish = "Мини-бургер",
//                    Ingredients = new List<string> { "мясо", "хлеб", "сыр" },
//                    CookingTime = 10,
//                    Instructions = "Обжарьте мясо, положите на хлеб, добавьте сыр и подайте."
//                };
//            }
//            else if (meatQuantity < 1.0)
//            {
//                return new Recipe
//                {
//                    Dish = "Бургер",
//                    Ingredients = new List<string> { "мясо", "хлеб", "сыр", "овощи" },
//                    CookingTime = 20,
//                    Instructions = "Обжарьте мясо, положите на хлеб, добавьте сыр и овощи, подайте."
//                };
//            }
//            else
//            {
//                return new Recipe
//                {
//                    Dish = "Мясной стейк",
//                    Ingredients = new List<string> { "мясо", "овощи" },
//                    CookingTime = 30,
//                    Instructions = "Обжарьте мясо, подайте с овощами."
//                };
//            }
//        }
//    }

//    public class Recipe
//    {
//        public string Dish { get; set; }
//        public List<string> Ingredients { get; set; }
//        public int CookingTime { get; set; }
//        public string Instructions { get; set; }
//    }
//}




























using System;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);

            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;
            // Инициализируем доску
            char[,] board = new char[8, 8];
            InitializeBoard(board);

            // Инициализируем игроков
            Player whitePlayer = new Player("Белые");
            Player blackPlayer = new Player("Чёрные");

            // Начинаем игру
            bool isWhiteTurn = true;
            while (true)
            {
                // Выводим доску
                PrintBoard(board);

                // Определяем текущего игрока
                Player currentPlayer = isWhiteTurn ? whitePlayer : blackPlayer;

                // Спрашиваем у игрока ход
                Console.WriteLine($"Ход {currentPlayer.Name}:");
                string moveInput = Console.ReadLine();

                // Обрабатываем ход
                if (TryMakeMove(board, moveInput, currentPlayer))
                {
                    // Меняем очередь хода
                    isWhiteTurn = !isWhiteTurn;
                }
                else
                {
                    Console.WriteLine("Неправильный ход. Попробуйте снова.");
                }

                // Проверяем, есть ли победитель
                if (IsCheckmate(board, blackPlayer))
                {
                    Console.WriteLine("Белые победили!");
                    break;
                }
                else if (IsCheckmate(board, whitePlayer))
                {
                    Console.WriteLine("Чёрные победили!");
                    break;
                }
            }
        }

        static void InitializeBoard(char[,] board)
        {
            // Инициализируем доску
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        board[i, j] = ' ';
                    }
                    else
                    {
                        board[i, j] = '-';
                    }
                }
            }

            // Инициализируем фигуры
            board[0, 0] = board[0, 7] = 'Р'; // Ладьи
            board[0, 1] = board[0, 6] = 'К'; // Кони
            board[0, 2] = board[0, 5] = 'С'; // Слоны
            board[0, 3] = 'В'; // Ферзь
            board[0, 4] = 'Г'; // Король
            board[1, 0] = board[1, 7] = 'П'; // Пешки

            board[7, 0] = board[7, 7] = 'р'; // Ладьи
            board[7, 1] = board[7, 6] = 'к'; // Кони
            board[7, 2] = board[7, 5] = 'с'; // Слоны
            board[7, 3] = 'в'; // Ферзь
            board[7, 4] = 'г'; // Король
            board[6, 0] = board[6, 7] = 'п'; // Пешки
        }

        static void PrintBoard(char[,] board)
        {
            Console.WriteLine("  A B C D E F G H");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool IsValidKingMove(char[,] board, int startX, int startY, int endX, int endY)
        {
            return (Math.Abs(startX - endX) <= 1 && Math.Abs(startY - endY) <= 1);
        }

        static bool IsValidQueenMove(char[,] board, int startX, int startY, int endX, int endY)
        {
            return IsValidBishopMove(board, startX, startY, endX, endY) || IsValidRookMove(board, startX, startY, endX, endY);
        }

        static bool IsValidBishopMove(char[,] board, int startX, int startY, int endX, int endY)
        {
            int dx = Math.Abs(startX - endX);
            int dy = Math.Abs(startY - endY);
            return (dx == dy && dx != 0);
        }

        static bool IsValidKnightMove(char[,] board, int startX, int startY, int endX, int endY)
        {
            int dx = Math.Abs(startX - endX);
            int dy = Math.Abs(startY - endY);
            return (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
        }

        static bool IsValidRookMove(char[,] board, int startX, int startY, int endX, int endY)
        {
            return (startX == endX || startY == endY);
        }

        static bool IsValidPawnMove(char[,] board, int startX, int startY, int endX, int endY)
        {
            if (board[startX, startY] == 'П')
            {
                if (startX == 6 && endX == 4)
                {
                    return true;
                }
                else if (startX != endX)
                {
                    return false;
                }
                else
                {
                    return (endY == startY + 1 || endY == startY - 1);
                }
            }
            else if (board[startX, startY] == 'п')
            {
                if (startX == 1 && endX == 3)
                {
                    return true;
                }
                else if (startX != endX)
                {
                    return false;
                }
                else
                {
                    return (endY == startY + 1 || endY == startY - 1);
                }
            }
            else
            {
                return false;
            }
        }

        static bool TryMakeMove(char[,] board, string moveInput, Player player)
        {
            // Парсим ввод
            int startX, startY, endX, endY;
            if (!TryParseMove(moveInput, out startX, out startY, out endX, out endY))
            {
                return false;
            }

            // Проверяем, является ли ход корректным
            if (!IsValidMove(board, startX, startY, endX, endY, player))
            {
                return false;
            }

            // Делаем ход
            board[endX, endY] = board[startX, startY];
            board[startX, startY] = ' ';

            return true;
        }

        static bool IsValidMove(char[,] board, int startX, int startY, int endX, int endY, Player player)
        {
            // Проверяем, является ли фигура игрока
            if (board[startX, startY] != player.Piece)
            {
                return false;
            }

            // Проверяем, является ли ход корректным для фигуры
            switch (board[startX, startY])
            {
                case 'Г': // Король
                    return IsValidKingMove(board, startX, startY, endX, endY);
                case 'В': // Ферзь
                    return IsValidQueenMove(board, startX, startY, endX, endY);
                case 'С': // Слон
                    return IsValidBishopMove(board, startX, startY, endX, endY);
                case 'К': // Конь
                    return IsValidKnightMove(board, startX, startY, endX, endY);
                case 'Р': // Ладья
                    return IsValidRookMove(board, startX, startY, endX, endY);
                case 'П': // Пешка
                    return IsValidPawnMove(board, startX, startY, endX, endY);
                default:
                    return false;
            }
        }

        static bool IsCheckmate(char[,] board, Player player)
        {
            // Проверяем, является ли король игрока в мате
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] == player.Piece && IsInCheck(board, i, j))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool IsInCheck(char[,] board, int x, int y)
        {
            // Проверяем, является ли король в мате
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] != ' ' && IsValidMove(board, i, j, x, y, new Player("")))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool TryParseMove(string moveInput, out int startX, out int startY, out int endX, out int endY)
        {
            // Парсим ввод
            string[] parts = moveInput.Split(' ');
            if (parts.Length != 2)
            {
                startX = startY = endX = endY = -1;
                return false;
            }

            string startCoord = parts[0];
            string endCoord = parts[1];

            if (startCoord.Length != 2 || endCoord.Length != 2)
            {
                startX = startY = endX = endY = -1;
                return false;
            }

            startX = 8 - (startCoord[1] - '0');
            startY = startCoord[0] - 'A';
            endX = 8 - (endCoord[1] - '0');
            endY = endCoord[0] - 'A';

            return true;
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public char Piece { get; set; }

        public Player(string name)
        {
            Name = name;
            Piece = name[0];
        }
    }
}