using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class Tilemap
	{
		private int width;
		private int height;
		private int[,]? tiles = null;

		public Tilemap(int w, int h)
		{
			width = w;
			height = h;
			tiles = new int[h, w];
		}

		public int GetWidth()
		{
			return width;
		}

		public int GetHeight()
		{
			return height;
		}

		public bool SetTile(int x, int y, int tileId)
		{
			if ( tiles == null)
			{
				return false;
			}

			if ( x < 0 || x >= width || y < 0 || y >= width )
			{
				return false;
			}

			tiles[y, x] = tileId;

			return true;
		}

		public byte[] Serialise()
		{
			byte[] data = new byte[width * height];
			int i = 0;

			if ( tiles != null )
			{
				for ( int y = 0; y < height; ++y )
				{
					for ( int x = 0; x < width; ++x )
					{
						data[i++] = (byte)(tiles[y, x] & 0xff);
					}
				}
			}

			return data;
		}
	}
}
