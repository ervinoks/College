using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W113
{
	internal class Hundred
	{
		static string[] HundredCreator()
		{
			string[] hundred = new string[100];
			for (int i = 1; i <= 100; i++) { hundred[i - 1] = i.ToString(); }
			return hundred;
        }
        static readonly Func<int, List<string>> tenValues = startDigit =>
        {
            List<string> tens = new List<string>();
            for (int j = 0; j < 10; j++)
            {
                startDigit += j;
                tens.Add(startDigit.ToString());
            }
            return tens;
        };
		static readonly Func<List<string>, string> toString = tensList => tensList.ToString(); 
        static List<List<string>> HundredArrayToListOfTens(string[] hundredArray)
		{
			List<string> hundredList = new List<string>();
            foreach (string str in hundredArray) { hundredList.Add(str); }
			List<List<string>> allTens = new List<List<string>>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0) { allTens.Append(tenValues(i)); }
            }
			return allTens;
        }
        static void Main(string[] args)
		{
			string fileName = @"\1-100.txt";
			string filePath = $@"{Directory.GetCurrentDirectory()}\..\..";
            Directory.SetCurrentDirectory(filePath);
            fileName = filePath + fileName;
            File.WriteAllText(fileName, "");
            string[] hundred = HundredCreator();
            File.OpenWrite(fileName);
            File.AppendText("A hundred with each digit on seperate lines: ");
            File.AppendText(hundred[0]);
            List<List<string>> linesOfTensOfHundred = HundredArrayToListOfTens(hundred);
            File.AppendText("____________________________________\nTens of a hundred on seperate lines: \n").Close(); ;
            for (int i = 0; i < linesOfTensOfHundred.Count; i++) { File.AppendAllLines(fileName, linesOfTensOfHundred[i]); }
            Console.ReadKey();
        }                                          
    }
}
