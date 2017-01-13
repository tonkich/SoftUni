using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RepresentingSumWithUnlimitedAmountOfCoins
{
    class Solver
    {
        private List<List<decimal>> mResults;

        public List<List<decimal>> Solve(decimal goal, decimal[] elements)
        {

            mResults = new List<List<decimal>>();
            RecursiveSolve(goal, 0.0m,
                new List<decimal>(), new List<decimal>(elements), 0);
            return mResults;
        }

        private void RecursiveSolve(decimal goal, decimal currentSum,
            List<decimal> included, List<decimal> notIncluded, int startIndex)
        {

            for (int index = startIndex; index < notIncluded.Count; index++)
            {

                decimal nextValue = notIncluded[index];
                if (currentSum + nextValue == goal)
                {
                    List<decimal> newResult = new List<decimal>(included);
                    newResult.Add(nextValue);
                    mResults.Add(newResult);
                }
                else if (currentSum + nextValue < goal)
                {
                    List<decimal> nextIncluded = new List<decimal>(included);
                    nextIncluded.Add(nextValue);
                    List<decimal> nextNotIncluded = new List<decimal>(notIncluded);
                    nextNotIncluded.Remove(nextValue);
                    RecursiveSolve(goal, currentSum + nextValue,
                        nextIncluded, nextNotIncluded, startIndex++);
                }
            }
        }
    }
}
