namespace Fitness_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool started = true;

            while (true)
            {
                if(started == true)
                {
                Show_menue();
                }
                else
                {
                    break;
                }
            }

            // Show the Main Menu with all Controlles
            void Show_menue()
            {
                started = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("### MAIN MENU ###");
                Console.WriteLine("#################");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" 1- Leistungsumsatz berechnen");
                Console.WriteLine(" 2- BodyMassIndex Berechnen");
                Console.WriteLine(" 3- Program Beenden");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Was möchtest du berechnen? ");
                int selected = Convert.ToInt16(Console.ReadLine());

                switch (selected)
                {
                    case 1:
                        started = true;
                        Console.Clear();
                        Console.WriteLine("### Leistungsumsatzrechner ###");
                        Console.WriteLine();
                        Console.WriteLine("Gebe dein Gewicht in Kg ein:");
                        int weight = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Gebe dein Geschlecht(m/w) an:");
                        int gender = Convert.ToChar(Console.ReadLine());

                        if (gender == 'm')
                        {
                            Console.Clear();
                            Console.WriteLine(Calc_caloriesM(weight));

                        }
                        else if (gender == 'w')
                        {
                            Console.Clear();
                            Console.WriteLine(Calc_caloriesW(weight));
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                        break;
                    case 2:
                        started = true;
                        Console.Clear();
                        Console.WriteLine("### Body Mass Index berechnen ###");
                        Console.WriteLine();
                        Console.WriteLine("Gebe dein Gewicht in Kg ein:");
                        weight = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Gebe deine Größe in Meter ein: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc_BMI(height, weight)); 
                        break;
                    case 3:
                        started = false;
                        break;
                }
            }

            // Calculate the calories for Men.
            double Calc_caloriesM(int weight)
            {
                Console.WriteLine("Dein Leistungsumsatz ist: ");
                return Math.Round(1.1 * weight * 24,0);
            }

            // Calculate the calories for Woman.
            double Calc_caloriesW(int weight)
            {
                Console.WriteLine("Dein Leistungsumsatz ist: ");
                return Math.Round(0.9 * weight * 24, 0);
            }

            double calc_BMI(double height, int weight)
            {
                Console.WriteLine("Dein BodyMassIndex liegt bei: ");
                return Math.Round(weight / Math.Pow(height,2), 1);
            }
        }

    }
}