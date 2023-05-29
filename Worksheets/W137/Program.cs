using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace W137
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<char, int> chars = new Dictionary<char, int>();
			#region WebRequest
			WebRequest request =
				WebRequest.Create("https://gist.githubusercontent.com/MattIPv4/045239bc27b16b2bcf7a3a9a4648c08a/raw/2411e31293a35f3e565f61e7490a806d4720ea7e/bee%2520movie%2520script");
			#endregion
			request.Method = WebRequestMethods.Http.Get;
			request.ContentType = "application/json";
			string beeMovieScript;
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			using (StreamReader sr = new StreamReader(response.GetResponseStream()))
			{
				// chars.Add(sr.Read()) += 1; // unfinished code
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
