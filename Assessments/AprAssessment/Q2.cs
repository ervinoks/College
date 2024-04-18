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
