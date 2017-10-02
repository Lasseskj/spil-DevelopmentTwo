using System;

namespace spil
{
    public class TicTacToeMenu
    {
        TicTacToe ticTacToe { get; set; }
        bool running = true; //så længe running = true vil spillet køre.
        public void Show()
        {
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }

        public void ShowMenu()
        {
            Console.Clear();
            if (ticTacToe != null)
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
                if (TicTacToe.Validate(ticTacToe.GameBoard) != ' ') //Hvis metoden Validate registrerer 3 på stribe ud fra koden i TicTacToe.cs - så afsluttes spillet(running = false) og nedenstående strings printes
                {
                    Console.WriteLine("player " + TicTacToe.Validate(ticTacToe.GameBoard)); //Sidste del er for at finde ud af om det er spilleren X eller O.
                    Console.WriteLine("A Winner is You!");
                    running = false; //her afsluttes spillet.
                }
            }
            Console.WriteLine("tic tac toe");
            Console.WriteLine();
            Console.WriteLine("1. Opret et nyt spil");
            Console.WriteLine("2. Set en brik");
            Console.WriteLine("3. Flyt en brik");
            Console.WriteLine();
            Console.WriteLine("0. exit");
        }


        private string GetUserChoise()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }

        private void ShowMenuSelectionErroe()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();
        }

        private void DoActionFor1()
        {
            ticTacToe = new TicTacToe(); //Får spillebrættet frem
        }
        private void DoActionFor2()
        {
            Console.WriteLine("indtast koordinater");
            ticTacToe.Place(Int32.Parse(Console.ReadLine()) - 1, Int32.Parse(Console.ReadLine()) - 1); //Hvad sker der her???
        }
        private void DoActionFor3()
        {
            Console.WriteLine("intast move from koordinater, derefter move to koordinater");
            ticTacToe.Move()
        }
    }
}