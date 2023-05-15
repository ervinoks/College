using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace A128
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input cipher text: ");
            Console.WriteLine($"Deciphered text: {Decipher(CipherText: Console.ReadLine())}");
            Console.ReadKey();
        }
        static string DecipheredText;
        static List<int> skipIndex = new List<int>();
        static string Decipher(string CipherText)
        {
            using (StringReader reader = new StringReader(CipherText))
            {
                char[] Buffer = new char[128];
                int ascii;
                foreach (var item in CipherText.Select((value, i) => (value, i)))
                {
                    if (item.value == ' ') 
                    { reader.Read(); continue; }
                    else if (item.i == CipherText.Count() - 2) { break; }
                    else if (skipIndex.Contains(item.i)) { continue; }
                    else if (reader.Peek() == '3')
                    {
                        reader.ReadBlock(Buffer,item.i, 2);
                        ascii = int.Parse(string.Join(string.Empty, Buffer.Skip(item.i).Take(2)));
                        skipIndex.Add(item.i + 1);
                        DecipheredText += (char)ascii;
                    }
                    else
                    {
                        if (reader.Peek() == '1')
                        { 
                            reader.ReadBlock(Buffer, item.i, 3);
                            ascii = int.Parse(string.Join(string.Empty, Buffer.Skip(item.i).Take(3)));
                            skipIndex.AddRange(new int[] { item.i, item.i + 1, item.i + 2 });
                        }
                        else
                        {
                            reader.ReadBlock(Buffer, item.i, 2);
                            ascii = int.Parse(string.Join(string.Empty, Buffer.Skip(item.i).Take(2)));
                            skipIndex.AddRange(new int[] { item.i, item.i + 1 });
                        }
                        DecipheredText += (char)ascii;
                    }
                }
            }
            return DecipheredText;
        }
    }
}
