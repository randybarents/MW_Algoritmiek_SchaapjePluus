using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
        string fileName = @"D:\Git\MW_Algoritmiek_SchaapjePluus\Algoritmiek_SchaapjePluus\Algoritmiek_SchaapjePluus\Resources\OutputFile.txt";
        public StreamWriter writer;

        public Pluus()
        {
            handler.ReadNumbers();
            writer = new StreamWriter(fileName);

        }

        public void CountNumbers()
        {
            foreach (var countNumber in handler.Numbers)
            {
                if (countNumber == 0)
                {
                    caseOutcome = "Insomnia";
                    writer.WriteLine("Testcase #" + testcaseNumber + ": " + caseOutcome);
                    continue;
                }
                while (countedNumbers.Count < 10)
                {
                    int numberToAdd = countNumber;
                    numberToAdd = MultiplyNumber(numberToAdd, multiplyAmount);
                    AddNumber(numberToAdd.ToString());
                    multiplyAmount++;
                }
                if (countedNumbers.Count == 10)
                {
                    testcaseNumber++;
                    writer.WriteLine("Testcase #" + testcaseNumber + ": " + caseOutcome);
                    writer.Flush();
                    countedNumbers.Clear();
                    multiplyAmount = 0;
                    continue;
                }
            }
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
