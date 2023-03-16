using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CA1416

namespace GfxConverter
{
	internal class SamPalette
	{
		// Intensities
		private static byte[] colourIntensities = { 0x00, 0x24, 0x49, 0x6d, 0x92, 0xb6, 0xdb, 0xff };

		// All 128 possible colours in RGB
		private static Color[] samCoupeRGBs = new Color[128];

		// The actual palette
		private int numEntries = 0;
		private int[] paletteData = new int[16];

		static SamPalette()
		{
			for ( int i = 0; i < 128; ++i )
			{
				// Bits xx,G1, R1, B1, Bri, G0, R0, B0 => R1, R0, Bri/G1, G0, Bri/B1, B0, Bri
				byte red = colourIntensities[((i & 0x02) >> 0) | ((i & 0x20) >> 3) | ((i & 0x08) >> 3)];
				byte green = colourIntensities[((i & 0x04) >> 1) | ((i & 0x20) >> 3) | ((i & 0x08) >> 3)];
				byte blue = colourIntensities[((i & 0x01) << 1) | ((i & 0x10) >> 2) | ((i & 0x08) >> 3)];

				samCoupeRGBs[i] = Color.FromArgb(red, green, blue);
			}
		}

		public static Color GetRGBFromSam(int samColour)
		{
			return samCoupeRGBs[samColour & 0x7f];
		}

		public static int GetSamFromRGB(Color c)
		{
			int sam = 0;
			int distance = 0x7ffffff;

			for ( int i = 0; i < 128; ++i)
			{
				// Get Sam RGB
				Color rgb = samCoupeRGBs[i];

				// Get the distance from this colour
				int dist = ((rgb.R - c.R) * (rgb.R - c.R)) + ((rgb.G - c.G) * (rgb.G - c.G)) + ((rgb.B - c.B) * (rgb.B - c.B));

				if ( dist == 0 )
				{
					return i;
				}
				else if ( dist < distance )
				{
					// Rembmer it
					distance = dist;
					sam = i;
				}
			}

			// Return the closest mathc
			return sam;
		}

		public int GetClosestSamFromRGB(Color c)
		{
			int sam = 0;
			int distance = 0x7ffffff;

			for (int i = 0; i < numEntries; ++i)
			{
				// Get Sam RGB
				Color rgb = samCoupeRGBs[paletteData[i]];

				// Get the distance from this colour
				int dist = ((rgb.R - c.R) * (rgb.R - c.R)) + ((rgb.G - c.G) * (rgb.G - c.G)) + ((rgb.B - c.B) * (rgb.B - c.B));

				if (dist == 0)
				{
					return i;
				}
				else if (dist < distance)
				{
					// Rembmer it
					distance = dist;
					sam = i;
				}
			}

			// Return the closest mathc
			return sam;
		}

		public void Reset()
		{
			numEntries = 0;
		}

		public bool IsRGBPresent(Color rgb)
		{
			int samCol = GetSamFromRGB(rgb);

			for (int i = 0; i < numEntries; ++i)
			{
				if (paletteData[i] == samCol )
				{
					return true;
				}
			}

			return false;
		}

		public int GetNumEntries()
		{
			return numEntries;
		}

		// Get sam entry by index
		public int GetSamEntry(int index)
		{
			if ( index < 0 || index > numEntries )
			{
				return -1;
			}

			return paletteData[index];
		}

		// Get RGB for entry by index
		public Color GetRGBEntry(int index)
		{
			if ( index < 0 || index > numEntries )
			{
				return Color.FromArgb(0, 0, 0, 0);
			}

			return samCoupeRGBs[paletteData[index]];
		}

		public void SetSamEntry(int index, int samColour)
		{
			if ( index < 0 || index > 16 )
			{
				return;
			}

			numEntries = Math.Max(index + 1, numEntries);

			paletteData[index] = samColour;
		}

		public void SetRGBEntry(int index, Color c)
		{
			if (index < 0 || index > 16)
			{
				return;
			}

			numEntries = Math.Max(index + 1, numEntries);

			paletteData[index] = GetSamFromRGB(c);
		}

		public void SetRGBEntry(int index, int r, int g, int b)
		{
			SetRGBEntry(index, Color.FromArgb(r, g, b));
		}

		//Extract 16 colours from image
		public void ExtractFromBitmap(Bitmap bm)
		{
			// First Clear all colours
			numEntries = 0;

			// Do we have a palette
			if ( bm.Palette.Entries.Length > 0 )
			{
				for (int i = 0; i < bm.Palette.Entries.Length && numEntries < 16; ++i)
				{
					if ( bm.Palette.Entries[i].A == 255 && !IsRGBPresent(bm.Palette.Entries[i]) )
					{
						paletteData[numEntries++] = GetSamFromRGB(bm.Palette.Entries[i]);
					}
				}
			}
			else
			{
				for ( int y = 0; y < bm.Height && numEntries < 16; ++y)
				{
					for ( int x = 0; x < bm.Width && numEntries < 16; ++x)
					{
						// Get the colour
						Color c = bm.GetPixel(x, y);

						if (c.A == 255 && !IsRGBPresent(c) )
						{
							paletteData[numEntries++] = GetSamFromRGB(c);
						}
					}
				}
			}
		}

		public byte[] Serialise()
		{
			byte[] data = new byte[numEntries];

			for ( int i = 0; i < numEntries; ++i )
			{
				data[i] = (byte)paletteData[i];
			}

			return data;
		}
	}
}
