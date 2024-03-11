using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A221
{
	internal class Potion
	{
		protected int[] Colour { get; set; }
		protected int Volume { get; set; }
		public Potion(int Volume, params int[] colours)
		{
			if (colours.Length != 3) throw new ArgumentException("Potion must have 3 colour values.");
			Colour = colours;
			this.Volume = Volume;
		}
		public int[] getColour => Colour;
		public int getVolume => Volume;
		public Potion Mix(Potion secondPotion)
		{
			List<int> mixedColour = new List<int>();
			for (int i = 0; i < Colour.Length; i++) 
			{
				mixedColour.Add((Colour[i] * Volume + secondPotion.Colour[i] * secondPotion.Volume) / (Volume + secondPotion.Volume));
			}
			return new Potion(Volume + secondPotion.Volume, mixedColour.ToArray());
		}
	}
}
