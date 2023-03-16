using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

#pragma warning disable CA1416 // Disable platform check

namespace GfxConverter
{
	internal class ExportData
	{
		// The current image loaded that we are working with
		private Bitmap? currentImage = null;

		// Work palette
		private SamPalette samPalette = new SamPalette();

		// Array of named palettes
		private Dictionary<string, SamPalette> palettes = new Dictionary<string, SamPalette>();

		// Array of named sprites
		private Dictionary<string, SamSprite> sprites = new Dictionary<string, SamSprite>();

		// Load a working image
		public bool LoadImage(string filename)
		{
			try
			{
				currentImage = (Bitmap?)Bitmap.FromFile(filename);
			}
			catch (Exception ex)
			{
				Console.WriteLine("LoadImage failed: " + ex.Message);

				currentImage = null;

				return false;
			}

			// Extract palette from the image loaded
			if ( currentImage == null )
			{
				return false;
			}

			samPalette.ExtractFromBitmap(currentImage);

			return true;
		}

		public string[] GetSpriteNames()
		{
			return sprites.Keys.ToArray();
		}

		public string[] GetPaletteNames()
		{
			return palettes.Keys.ToArray();
		}

		public SamPalette GetWorkingPalette()
		{
			return samPalette;
		}

		public int GetWorkingImageWidth()
		{
			if ( currentImage == null )
			{
				return 0;
			}

			return currentImage.Width;
		}

		public int GetWorkingImageHeight()
		{
			if ( currentImage == null )
			{
				return 0;
			}

			return currentImage.Height;
		}

		public bool HasPalette(string name)
		{
			if ( palettes.ContainsKey(name) )
			{
				return true;
			}

			return false;
		}

		public SamPalette? GetPalette(string name)
		{
			if ( palettes.ContainsKey(name) )
			{
				return palettes[name];
			}

			return null;
		}

		public SamPalette AddPalette(string name)
		{
			if (!palettes.ContainsKey(name))
			{
				palettes[name] = new SamPalette();
			}

			return palettes[name];
		}

		public bool HasSprite(string name)
		{
			if (sprites.ContainsKey(name))
			{
				return true;
			}

			return false;
		}

		public SamSprite? GetSprite(string name)
		{
			if (sprites.ContainsKey(name))
			{
				return sprites[name];
			}

			return null;
		}

		public SamSprite AddSprite(string name, int w, int h)
		{
			if (!sprites.ContainsKey(name))
			{
				sprites[name] = new SamSprite(w, h);
			}

			return sprites[name];
		}

		public Color GetPixelRGB(int x, int y)
		{
			if ( currentImage == null )
			{
				return Color.FromArgb(0, 0, 0, 0);
			}

			// Bounds check
			if ( x < 0 || x >= currentImage.Width || y < 0 || y >= currentImage.Height )
			{
				return Color.FromArgb(0, 0, 0, 0);
			}

			// Return the pixel
			return currentImage.GetPixel(x, y);
		}

		public void Reset()
		{
			// Clear the working palette
			samPalette.Reset();

			// Reset the sprites
			sprites.Clear();

			// Clear the dictionary of palettes
			palettes.Clear();

			// Release the current image
			currentImage = null;
		}
	}
}
