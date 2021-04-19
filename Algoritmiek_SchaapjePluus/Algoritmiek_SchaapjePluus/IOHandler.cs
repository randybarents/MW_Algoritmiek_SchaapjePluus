using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Algoritmiek_SchaapjePluus
{
    public class IOHandler
    {
        public List<int> Numbers = new List<int>();
        string textLine;

        public void ReadNumbers()
        {
            using (Stream fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Algoritmiek_SchaapjePluus.Resources.NumberInput.txt"))
            {
                using (StreamReader fileReader = new StreamReader(fileStream))
                {
                    while ((textLine =fileReader.ReadLine()) != null)
                    {
                        Numbers.Add(Convert.ToInt32(textLine));
                    }
                    fileReader.Close();
                }
            }
        }

        public void WriteTestCase(int caseNumber, string caseOutcome)
        {
            string fileName = @"D:\Git\MW_Algoritmiek_SchaapjePluus\Algoritmiek_SchaapjePluus\Algoritmiek_SchaapjePluus\Resources\OutputFile.txt";
            using (StreamWriter fileWriter = new StreamWriter(fileName))
            {
                fileWriter.WriteLine("Testcase #" + caseNumber + ": " + caseOutcome);
            }           
        }
    }
}

