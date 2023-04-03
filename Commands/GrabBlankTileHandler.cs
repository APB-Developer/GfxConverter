using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GfxConverter
{
	internal class GrabBlankTileHandler : CommandHandler
	{
		public override bool IsValid(ScriptCommand sc)
		{
			if ( sc.GetNumberArguments() != 4 && sc.GetNumberArguments() != 6 )
			{
				return false;
			}

			if ( !sc.IsArgumentInteger(1) || !sc.IsArgumentInteger(2) )
			{
				return false;
			}

			if ( sc.GetNumberArguments() == 4 )
			{
				if ( !sc.IsArgumentInteger(3) || sc.GetArgumentAsInteger(3) < 0 || sc.GetArgumentAsInteger(3) > 15 )
				{
					return false;
				}
			}
			else
			{
				if (!sc.IsArgumentInteger(3) || sc.GetArgumentAsInteger(3) < 0 || sc.GetArgumentAsInteger(3) > 255)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(4) || sc.GetArgumentAsInteger(4) < 0 || sc.GetArgumentAsInteger(4) > 255)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(5) || sc.GetArgumentAsInteger(5) < 0 || sc.GetArgumentAsInteger(5) > 255)
				{
					return false;
				}
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Grabbing Blank Tile to Tileset: " + sc.GetArgumentAsString(0));

			int samColour = 0;

			// Get the size of the tile
			int w = sc.GetArgumentAsInteger(1);
			int h = sc.GetArgumentAsInteger(2);

			// Add a tileset if needed
			Tileset tileset = ed.AddTileset(sc.GetArgumentAsString(0), w, h);

			// Get the working palette colour
			if (sc.GetNumberArguments() == 4)
			{
				samColour = sc.GetArgumentAsInteger(3);
			}
			else
			{
				int r = sc.GetArgumentAsInteger(3);
				int g = sc.GetArgumentAsInteger(4);
				int b = sc.GetArgumentAsInteger(5);

				samColour = ed.GetWorkingPalette().GetClosestSamFromRGB(Color.FromArgb(r, g, b));
			}

			// Create a new tile
			SamTile tile = new SamTile(w, h);

			// We now need to set all the bytes to the same colour
			byte c = (byte)((samColour & 0x0f) | ((samColour << 4) & 0xf0));
			int total = ((w + 1) >> 1) * h;

			for ( int i = 0; i < total; ++i)
			{
				tile.AddData(c);
			}

			// Add this to the tileset
			if ( tileset.AddTile(tile) == -1 )
			{
				return false;
			}

			return true;
		}
	}
}
