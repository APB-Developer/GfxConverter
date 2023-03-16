using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class SamSprite
	{
		private int width = 0;
		private int height = 0;
		private List<byte> data = new List<byte>();

		public SamSprite(int w, int h)
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

		public void AddData(byte b)
		{
			data.Add(b);
		}

		public int GetDataSize()
		{
			return data.Count();
		}

		public byte[] Serialise()
		{
			return data.ToArray();
		}
	}
}
