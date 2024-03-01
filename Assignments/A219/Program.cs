using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace A219
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string ciphertext = "jehjb teh tedri gaoor jorrdior", alphabet = "abcdefghijkl";
			Console.WriteLine($"{ciphertext} | {alphabet} => {Mirror(ciphertext, alphabet)}");
			Console.WriteLine($"{ciphertext = "rtarm efaapc"} | {alphabet = "abcdefghijklmnopqrst"} => {Mirror(ciphertext, alphabet)}");
			Console.ReadKey();
		}
		static string Mirror(string ciphertext, string alphabet)
		{
			string plaintext = "";
			for (int i = 0; i < ciphertext.Length; i++)
			{
				int index = alphabet.IndexOf(ciphertext[i]);
				ciphertext += index == -1 ? ciphertext[i] : alphabet[alphabet.Length - 1 - index]; 
			}
			return plaintext;
		}
	}
}
