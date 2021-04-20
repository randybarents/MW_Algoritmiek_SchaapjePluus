using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmiek_SchaapjePluus
{
    public class Pluus
    {
        IOHandler handler = new IOHandler();
        int[] sleepNumbers = {1,2,3,4,5,6,7,8,9,0};
        List<int> countedNumbers = new List<int>();
        int testcaseNumber = 0;
        int multiplyAmount = 1;
        string caseOutcome;

        public void CountNumbers()
        {
            handler.ReadNumbers();
            foreach (var countNumber in handler.Numbers)
            {
                while (CompareNumbers() == false)
                {
                    AddNumber(countNumber.ToString());
                    CompareNumbers();
                    multiplyAmount++;
                    MultiplyNumber(countNumber, multiplyAmount);
                }
                if (CompareNumbers() == true)
                {
                    testcaseNumber++;
                    handler.WriteTestCase(testcaseNumber , caseOutcome);
                }
            }
        }
        
        public bool CompareNumbers()
        {
            if (countedNumbers.SequenceEqual(sleepNumbers))
            {
                return true;
            }
            return false;
        }

        public void AddNumber(string numberToAdd)
        {
            var tempNumberList = numberToAdd.Select(digit => int.Parse(digit.ToString()));
            List<int> numbersList = tempNumberList.ToList();
            foreach (var item in numbersList)
            {
                if (!countedNumbers.Contains(item))
                {
                    countedNumbers.Add(item);
                    caseOutcome = item.ToString();
                    countedNumbers.Sort();
                }
            }
        }

        public int MultiplyNumber(int number , int amount)
        {
            return number * amount;
        }
    }
}
