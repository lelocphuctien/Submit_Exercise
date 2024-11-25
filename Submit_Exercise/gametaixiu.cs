using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submitted_Ex01
{
    internal class gametaixiu
    {
        public static int rollDice()
        {
            Random random = new Random();
            int die_1 = random.Next(6) + 1;
            int die_2 = random.Next(6) + 1;
            int die_3 = random.Next(6) + 1;
            int sumofdice = die_1 + die_2 + die_3;
            return sumofdice;
        }
        public static void playground()
        {
            int com_dice = rollDice();
            Console.Write("Ban doan Tai hay Xiu <T/X>: ");
            string user_guess = Console.ReadLine();
            if (user_guess.ToUpper().Equals("T"))
            {
                if (com_dice >= 10)
                    Console.WriteLine("Ban thang.");
                else Console.WriteLine("Ban thua.");
            }
            else if (user_guess.ToUpper().Equals("X"))
            {
                if (com_dice < 10)
                    Console.WriteLine("Ban thang.");
                else Console.WriteLine("Ban thua.");
            }
            else Console.WriteLine("Vui long chon cho dung.");
        }
        public static void game()
        {
            do
            {
                playground();
                Console.Write("Ban choi nua khong? <C/K>");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                    break;
            }
            while (true);
            Console.WriteLine("Mai choi nua nhe.");
        }
        public static void Maintx()
        {
            game();
        }
    }
}