using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;

namespace Code
{
	public class Comic
	{
		public string month { get; set; }
		public int num { get; set; }
		public string link { get; set; }
		public string year { get; set; }
		public string news { get; set; }
		public string safe_title { get; set; }
		public string transcript { get; set; }
		public string alt { get; set; }
		public string img { get; set; }
		public string title { get; set; }
		public string day { get; set; }
	}

	class Program
	{
		static HttpClient client = new HttpClient();
		static async Task<string> GetDataFromApi(string endpoint)
		{
			HttpResponseMessage response = await client.GetAsync($"https://api.datamuse.com/{endpoint}");

			if (response.IsSuccessStatusCode)
			{
				string text = await response.Content.ReadAsStringAsync();
				return text;
			}

			return null;
		}
		static async Task Main(string[] args)
		{

			// --- xkcd API ---

			HttpResponseMessage xkcdResponse = await client.GetAsync("https://xkcd.com/info.0.json");

			if (xkcdResponse.IsSuccessStatusCode)
			{
				string text = await xkcdResponse.Content.ReadAsStringAsync();
				Console.WriteLine(text + "\n\n");

				Comic c = JsonSerializer.Deserialize<Comic>(text);

				Console.WriteLine($"Title: {c.title}, Published: {c.day}-{c.month}-{c.year}\n{c.alt}");
				Console.WriteLine();
			}

			// --- END ---

			// --- datamuse API ---

			string result1 = await GetDataFromApi("words?ml=computer");
			Console.WriteLine(result1 + "\n");

			string result2 = await GetDataFromApi("words?rel_jja=magical");
			Console.WriteLine(result2 + "\n");

			string result3 = await GetDataFromApi("words?lc=duck&sp=y*");
			Console.WriteLine(result3 + "\n");

			// --- END ---

			Console.ReadKey();
		}
	}
}

