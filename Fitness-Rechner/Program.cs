﻿namespace Fitness_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe dein Gewicht in Kg ein:");
            int weight = Convert.ToInt16(Console.ReadLine());
            
            // Shows the the Headline für the MainMenu.
            void Show_Headline()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("### Calories Calculater & BMI Calculater ###");
                Console.WriteLine("############################################");
            }

            // Shows the Headline for the Calories Calculater.
            void Show_headline_menue()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("### Calories Calculater ###");
                Console.WriteLine("###########################");
            }

            // Calculate the calories for Men.
            double Calc_caloriesM(int weight)
            {
                Console.WriteLine("Dein Leistungsumsatz ist: ");
                return 1.1 * weight * 24;
            }

            // Calculate the calories for Woman.
            double Calc_caloriesW(int weight)
            {
                Console.WriteLine("Dein Leistungsumsatz ist: ");
                return 0.9 * weight * 24;
            }

            // float calc_BMI(int height, int weight)
        }

    }
}