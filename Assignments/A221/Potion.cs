using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A221
{
	internal class Potion
	{
		public byte[] Colour { get; private set; }
		public int Volume { get; private set; }
		public Potion(int Volume, params byte[] colours)
		{
			if (colours.Length != 3) throw new ArgumentException("Potion must have 3 colour values.");
			Colour = colours;
			this.Volume = Volume;
		}
		public Potion Mix(Potion secondPotion)
		{
			List<byte> mixedColour = new List<byte>();
			for (int i = 0; i < Colour.Length; i++) 
			{
				mixedColour.Add(Convert.ToByte((Colour[i] * Volume + secondPotion.Colour[i] * secondPotion.Volume) / (Volume + secondPotion.Volume)));
			}
			return new Potion(Volume + secondPotion.Volume, mixedColour.ToArray());
		}
	}
}
