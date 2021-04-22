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
        public int[] sleepNumbers = {0,1,2,3,4,5,6,7,8,9};
        public List<int> countedNumbers = new List<int>();
        public int testcaseNumber = 0;
        public int multiplyAmount = 1;
        public string caseOutcome;

        public Pluus()
        {
            handler.ReadNumbers();
        }

        public void CountNumbers()
        {
            foreach (var countNumber in handler.Numbers)
            {
                while (CompareNumbers() == false)
                {
                    int numberToAdd = countNumber;
                    numberToAdd = MultiplyNumber(numberToAdd, multiplyAmount);
                    AddNumber(numberToAdd.ToString());
                    CompareNumbers();
                    multiplyAmount++;
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
                    caseOutcome = numberToAdd;
                    countedNumbers.Sort();
                }
            }
        }

        public int MultiplyNumber(int number , int amount)
        {
            number = number * amount;
            return number;
        }
    }
}
