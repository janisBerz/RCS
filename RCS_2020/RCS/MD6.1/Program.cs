using System;

namespace TicTacToe
{
    enum FieldEnum
    {
        Empty,
        X,
        O
    }

    class Program
    {
        static void Main(string[] args)
        {
            FieldEnum[,] board = new FieldEnum[3, 3];
            var currentPlayer = FieldEnum.O;
            bool gameFinished = false;

            Console.WriteLine("Sveiki! Šī ir spēle DESAS jeb TIC TAC TOE!");
            Console.WriteLine("Spēle diviem spēlētājiem.");

            Console.WriteLine("Spēle sākas!");
            PrintBoard(board);

            do
            {
                Console.WriteLine(); //ievadam tukšu rindu, lai atdalītu paziņojumus/gājienus
                Console.Write("Ievadi lūdzu rindas skaitli:");
                string rinda = Console.ReadLine();

                Console.Write("Ievadi lūdzu kolonas skaitli:");
                string kolona = Console.ReadLine();

                //Speciālā programmētāja izeja ar atslēgvārdu STOP
                if (rinda == "STOP" || kolona == "STOP")
                {
                    break;
                }

                //Pārbaudīsim, vai ievadītās vērtības IR tukšas
                if (string.IsNullOrEmpty(rinda) || string.IsNullOrEmpty(kolona))
                {
                    WriteError("Lūdzu neievadīt tukšas vērtības!");
                    continue;
                }

                //Pārbaudīsim, vai ievadītās vērtības ir skaitļi
                int i, j;
                bool rindasParveidosana = int.TryParse(rinda, out i);
                bool kolonasParveidosana = int.TryParse(kolona, out j);

                if (!rindasParveidosana || !kolonasParveidosana)
                {
                    WriteError("Lūdzu ievadi skaitļu vērtības!");
                    continue;
                }

                //Pārbaudam, vai ievadītie skaitļi atbilst laukuma robežās
                if (i < 1 || i > 3 || j < 1 || j > 3)
                {
                    //Nepareizi ievadīta vērtība
                    WriteError("Lūdzu ievadiet abus skaitļus robežās [1-3]!");
                    continue;
                }

                //Pārbaudam, vai šajā šūnā/lauciņā jau nav kāda vērtība
                if (board[i - 1, j - 1] != FieldEnum.Empty)
                {
                    WriteError("Šis lauciņš jau ir aizņemts, izvēlies citu!");
                    continue;
                }

                board[i - 1, j - 1] = currentPlayer;
                PrintBoard(board);

                //samainīsim spēlētājus
                currentPlayer = currentPlayer == FieldEnum.O ? FieldEnum.X : FieldEnum.O;

                gameFinished = IsGameFinished(board);
            } while (!gameFinished);
        }

        private static bool IsGameFinished(FieldEnum[,] board)
        {

            switch (board)
            {
                case board[1,1];
                    break;
                case FieldEnum.X:
                    break;
                case FieldEnum.O:
                    break;
                default:
                    break;
            }

            return false;
        }

        private static void PrintBoard(FieldEnum[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    switch (board[i, j])
                    {
                        case FieldEnum.Empty:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"_ ");
                            break;
                        case FieldEnum.X:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"X ");
                            break;
                        case FieldEnum.O:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"O ");
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }

            //Uzliekam krāsas atpakaļ
            Console.ResetColor(); //alternatīva: Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void WriteError(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
