using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAlon
{
    class RandomNumber
    {
        private static Random Random = new Random();
        public static string RandomGenerator()
        {
            string[] RandomNumberArray = new string[4];
            byte Counter = 0;
            do
            {
                {
                    RandomNumberArray[Counter] = Convert.ToString(Random.Next(0, 9));
                    Counter++;
                } while (Counter < 3) ;
            } while (RandomNumberArray[0] == RandomNumberArray[1] || RandomNumberArray[0] == RandomNumberArray[2] || RandomNumberArray[0] == RandomNumberArray[3] || RandomNumberArray[1] == RandomNumberArray[2] || RandomNumberArray[1] == RandomNumberArray[3] || RandomNumberArray[2] == RandomNumberArray[3]);
            string Result = RandomNumberArray[0] + RandomNumberArray[1] + RandomNumberArray[2] + RandomNumberArray[3];
            return Result;
        }
    }
}
