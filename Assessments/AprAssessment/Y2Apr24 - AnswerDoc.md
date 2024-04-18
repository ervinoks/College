<table>
  <tr>
   <td><strong>Centre number</strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong>Candidate number</strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td>
   </td>
  </tr>
  <tr>
   <td><strong>Surname</strong>
   </td>
   <td colspan="10" ><strong>Oks</strong>
   </td>
  </tr>
  <tr>
   <td><strong>Forename(s)</strong>
   </td>
   <td colspan="10" ><strong>Ervin</strong>
   </td>
  </tr>
  <tr>
   <td><strong>Programming Language</strong>
   </td>
   <td colspan="10" ><strong>C# (7517/1A) </strong>
   </td>
  </tr>
</table>

# A-LEVEL COMPUTER SCIENCE
## April Assessment 2024
Time allowed: 40 minutes

### Materials
For this paper you must have:

- a computer
- appropriate software
- the Electronic Answer Document.

### Instructions
- This is the Electronic Answer Document (EAD). Answer all questions by entering your answers into this document on screen. You must save this document at regular intervals.
- Before the examination begins, type the information needed in the boxes at the top of this page.
- Before the examination begins, type the information needed in the boxes in the footers (page 2 onwards) of this EAD.
- Enter your answers to all questions into the Electronic Answer Document.
- Answer both questions.
- For programming questions, copy and paste the text of your code. Only take screenshots of the console window for required tests. You should crop and enlarge screenshots of the console window so that they are easy to read.  

### Information
- The marks for questions are shown in brackets.
- The maximum mark for this paper is **26**.  

### Advice
- Before the start of the examination you may find it helpful to create two blank C# projects ready for Section B.

Answer **all** questions.

### Section B

<table>
  <tr>
   <td colspan="6" ><strong>Question 1</strong>
   </td>
   <td><strong>Mark</strong></td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td colspan="2" ><pre lang="csharp">
using System.Text;
namespace AprAssessment
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            string DNA;
            Console.WriteLine($"DNA: {DNA = "TAGATGGCAGATAAATGA"} - has longest substring of {LongestDNASubstring(DNA)}");
            Console.WriteLine($"DNA: {DNA = "AAAACGAAATATAAGCCATGT"} - has longest substring of {LongestDNASubstring(DNA)}");
            Console.ReadKey();
        }
        static int LongestDNASubstring(string symbols)
        {
            List<int> indexes = new List<int>() { 0 };
            int i;
            StringBuilder DNASubstring = new StringBuilder();
            string ASub = "";
            bool checking = true;
            do
            {
                switch (i = symbols.IndexOf('A', indexes.Last()))
                {
                    default:
                        indexes.Add(i + 1);
                        DNASubstring.Append('A');
                        try
                        {
                            while (symbols[i++ + 1] == 'A')
                            {
                                DNASubstring.Append('A');
                            }
                        }
                        catch { }
                        if (DNASubstring.Length > ASub.Length) ASub = DNASubstring.ToString();
                        DNASubstring.Clear();
                        break;
                    case -1:
                        checking = false;
                        break;
                }
            } while (checking);
            return ASub.Length;
        }
    }
}
</pre>
   </td>
   <td><i>11</i></td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td colspan="2">
   </td>
   <td><i>1</i></td>
  </tr>
</table>

<table>
  <tr>
   <td colspan="6" ><strong>Question 2</strong>
   </td>
   <td><strong>Mark</strong></td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td colspan="2" ><pre lang="csharp">
namespace AprAssessment
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 2; j++)
            {
                string key;
                int hashed;
                bool collision = false;
                List<int> hashes = new List<int>();
                Console.WriteLine("Input 3 keys: ");
                for (int i = 0; i < 3; i++)
                {
                    key = Console.ReadLine();
                    hashed = Hash(key);
                    Console.WriteLine(hashed);
                    if (hashes.Contains(hashed)) { Console.WriteLine("Collision detected!!"); collision = true; }
                    hashes.Add(hashed);
                }
                if (hashes[0] == hashes[1] && hashes[0] == hashes[2]) Console.WriteLine("Serious collision detected!!");
                if (!collision) Console.WriteLine("No collisions.\n\n");
            }
            Console.ReadKey();
        }
        static int Hash(string key)
        {
            int hash = 0;
            string sub;
            List<int> diffs = new List<int>();
            for (int i = 0; i < key.Length - 1; i++)
            {
                sub = key.Substring(i, 2);
                diffs.Add(Math.Abs(sub[0] - sub[1]));
            }
            diffs.ForEach(i => { hash += i; });
            hash = (int)Math.Round((decimal)hash / diffs.Count);
            return hash %= 10;
        }
    }
}
</pre>
   </td>
   <td><i>12</i></td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td colspan="2" >
   </td>
   <td><i>1</i></td>
  </tr>
</table>

## Total marks: 25/26