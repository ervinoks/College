using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A135
{
	internal class CensoredStrings
	{
		static void Main(string[] args)
		{
			string _, __; // saves me rewriting
			Console.WriteLine($"uncensor({_ = "*h*s *s v*ry *tr*ng*"}, {__ = "Tiiesae"}): {uncensor(_, __)}");
			Console.WriteLine($"uncensor({_ = "A**Z*N*"}, {__ = "MAIG"}): {uncensor(_, __)}");
			Console.WriteLine($"uncensor({_ = "xyz"}, {__ = ""}): {uncensor(_, __)}");
			Console.ReadKey();
		}
		static string uncensor(string text, string censored)
		{
			string output = string.Empty;
			StringReader censR = new StringReader(censored);
			using (StringReader reader = new StringReader(text))
			{
				while (reader.Peek() != -1)
				{
					char nextChar = (char)reader.Read();
					if (nextChar == '*') output += (char)censR.Read();
					else output += nextChar;
				} 
			}
			return output;
		}
	}
}
