using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreTester
{
    internal class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmout = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            //dzielenie wyniku rzutu przez pole DivideBy
            double divided = RollResult / DivideBy;

            //dodawanie AddAmount do wyniku dzielenia
            int added = AddAmout + (int)divided;

            //jeśli wynik jest za niski, użyj minimum
            if (added < Minimum)
                Score = Minimum;
            else
                Score = added;
        }
    }
}
