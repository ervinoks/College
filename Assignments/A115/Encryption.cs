using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A115
{
	internal class Encryption
	{
		private static readonly int[] asciiVowels = { 97, 101, 105, 111, 117 }; //lower-case
		static string LetterChange(string input)
		{	
			string encryptedString = null;
			foreach (char letter in input)
			{	
				int asciiLetter = (int)letter;
				if (asciiLetter == 122) { asciiLetter = 97; }
				else if (!((asciiLetter <= 64) || (91 <= asciiLetter && asciiLetter <= 96) || (123 <= asciiLetter))) { asciiLetter++; }
				if (asciiVowels.Contains(asciiLetter)) { asciiLetter -= 32; }
				encryptedString += (char)asciiLetter;
			}
			return encryptedString;
		}
		static string Decryption(string input)
		{
			for (int i = 0; i <= 4; i++) { asciiVowels[i] -= 32; } //upper-case
			string decryptedString = null;
			foreach (char letter in input)
			{
				int asciiLetter = (int)letter;
				if (asciiVowels.Contains(asciiLetter)) { asciiLetter += 32; }
				if (asciiLetter == 97) { asciiLetter = 122; }
				else if (!((asciiLetter <= 64) || (91 <= asciiLetter && asciiLetter <= 96) || (123 <= asciiLetter))) { asciiLetter--; }
				decryptedString += (char)asciiLetter;
			}
			return decryptedString;
		}
		static void Main(string[] args)
		{
			Console.Write("Input a string to encrypt: ");
			string encryptedString = LetterChange(Console.ReadLine());
			Console.WriteLine($"Encrypted string: {encryptedString}");
			Console.ReadKey(true);
			Console.Write("Input a string to decrypt: ");
			string decryptedString = Decryption(Console.ReadLine());
			Console.WriteLine($"Decrypted string: {decryptedString}");
			Console.ReadKey();
		}
	}
}
