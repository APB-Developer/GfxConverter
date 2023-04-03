using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GfxConverter
{
	internal class GrabTileHandler : CommandHandler
	{
		public override bool IsValid(ScriptCommand sc)
		{
			if ( sc.GetNumberArguments() != 5 )
			{
				return false;
			}

			// Check x,y are integers
			if ( !sc.IsArgumentInteger(1) || !sc.IsArgumentInteger(2) )
			{
				return false;
			}

			// Check width, height
			if (!sc.IsArgumentInteger(3) || !sc.IsArgumentInteger(4))
			{
				return false;
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Grabbing Tile to Tileset: " + sc.GetArgumentAsString(0));

			int x = sc.GetArgumentAsInteger(1);
			int y = sc.GetArgumentAsInteger(2);
			int w = sc.GetArgumentAsInteger(3);
			int h = sc.GetArgumentAsInteger(4);

			// Find the tileset
			Tileset tileset = ed.AddTileset(sc.GetArgumentAsString(0), w, h);

			// Create a new tile
			SamTile tile = new SamTile(w, h);

			// Get the working palette
			SamPalette pal = ed.GetWorkingPalette();

			// Run through all the pixels
			for (int yp = y; yp < (y + h); ++yp)
			{
				for (int xp = x; xp < (x + w); xp += 2)
				{
					// Read the pixel colours
					Color p1 = ed.GetPixelRGB(xp, yp);
					Color p2 = ed.GetPixelRGB(xp + 1, yp);

					// Store the data
					byte data = (byte)(pal.GetClosestSamFromRGB(p1) << 4);
					data |= (byte)pal.GetClosestSamFromRGB(p2);

					// Add the data
					tile.AddData(data);
				}
			}

			// Add this tile to the tileset
			if ( tileset.AddTile(tile) == -1 )
			{
				return false;
			}

			return true;
		}
	}
}
