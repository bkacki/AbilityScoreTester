
namespace AbilityScoreTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();

            while(true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Początkowy rzut 4d6");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Dzielone przez");
                calculator.AddAmout = ReadInt(calculator.AddAmout, "Dodawana wartość");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Obliczone punkty umiejętności: " + calculator.Score);
                Console.WriteLine("Wciśnik [Q] aby zakończyć, lub inny klawisz aby kontynuować.");

                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q'))
                    return;
            }
        }

        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();

            if (double.TryParse(line, out double doubleValue))
            {
                Console.WriteLine("\t użycie wartości " + doubleValue);
                return doubleValue;
            }
            else
            {
                Console.WriteLine("\t użycie wartości domyślnej " + lastUsedValue);
                return lastUsedValue;
            }
        }

        private static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" +  lastUsedValue + "]: ");
            string line = Console.ReadLine();

            if(int.TryParse(line, out int intValue))
            {
                Console.WriteLine("\t użycie wartości " +  intValue);
                return intValue;
            }
            else
            {
                Console.WriteLine("\t użycie wartości domyślnej " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
