using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class Tileset
	{
		private int width;
		private int height;
		private List<SamTile> tiles = new List<SamTile>();

		public Tileset(int w, int h)
		{
			width = w;
			height = h;
		}

		public int GetWidth()
		{
			return width;
		}

		public int GetHeight()
		{
			return height;
		}

		public int GetNumTiles()
		{
			return tiles.Count();
		}

		public SamTile GetTile(int tileIdx)
		{
			return tiles[tileIdx];
		}

		public int AddTile(SamTile new_tile)
		{
			if ( new_tile.GetWidth() != width || new_tile.GetHeight() != height )
			{
				Console.WriteLine("Attempting to adda a tile to a tileset with the wrong dimensions");

				return -1;
			}

			// Grab the data to compare
			byte[] data = new_tile.Serialise();

			for ( int i = 0; i < tiles.Count(); ++i)
			{
				// Are these the same
				if (data.SequenceEqual(tiles[i].Serialise()))
				{
					// They are the same, return the previous version
					return i;
				}
			}

			// Didnt find a match
			tiles.Add(new_tile);

			// Return the tile number
			return tiles.Count() - 1;
		}
	}
}
