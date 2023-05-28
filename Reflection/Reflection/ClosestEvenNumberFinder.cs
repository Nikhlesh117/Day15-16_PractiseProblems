using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class ClosestEvenNumberFinder
    {
        public int FindClosestEvenNumber(int N)
        {
            string strNum = Math.Abs(N).ToString();
            int closestNum = N;
            int minDiff = int.MaxValue;

            foreach (char digit in strNum)
            {
                int num = int.Parse(digit.ToString());

                if (num % 2 != 0)
                {
                    num++; // Make the digit even
                }

                int newNum = int.Parse(strNum.Replace(digit, num.ToString()[0]));

                int diff = Math.Abs(newNum - Math.Abs(N));

                if (diff < minDiff || (diff == minDiff && newNum < closestNum))
                {
                    minDiff = diff;
                    closestNum = newNum;
                }
            }

            if (N < 0)
            {
                closestNum *= -1; // Maintain the negative sign
            }

            return closestNum;
        }
    }
}
