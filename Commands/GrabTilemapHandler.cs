using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GfxConverter
{
	internal class GrabTilemapHandler : CommandHandler
	{
		public override bool IsValid(ScriptCommand sc)
		{
			if ( sc.GetNumberArguments() != 4 )
			{
				return false;
			}

			if ( !sc.IsArgumentInteger(2) || !sc.IsArgumentInteger(3) )
			{
				return false;
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Grabbing Tilemap: " + sc.GetArgumentAsString(0) + " from Tilset: " + sc.GetArgumentAsString(1));

			int w = sc.GetArgumentAsInteger(2);
			int h = sc.GetArgumentAsInteger(3);

			// Find the tileset
			Tileset tileset = ed.AddTileset(sc.GetArgumentAsString(1), w, h);

			// Get the working palette
			SamPalette pal = ed.GetWorkingPalette();

			// Get the tilemap dimensions
			int image_w = ed.GetWorkingImageWidth();
			int image_h = ed.GetWorkingImageHeight();
			int map_w = image_w / w;
			int map_h = image_h / h;

			// Get the tilemap
			Tilemap tilemap = ed.AddTilemap(sc.GetArgumentAsString(0), map_w, map_h);

			// Run through all the tiles
			for (int my = 0; my < map_h; ++my)
			{
				for (int mx = 0; mx < map_w; ++mx)
				{
					// Create the tile
					SamTile tile = new SamTile(w, h);

					for (int ty = 0; ty < h; ++ty)
					{
						int yp = (my * h) + ty;

						for (int tx = 0; tx < w; tx += 2)
						{
							int xp = (mx * w) + tx;

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

					int tileId = tileset.AddTile(tile);

					if ( tileId == -1 )
					{
						Console.WriteLine("Error: Unable to add tile to tileset");
						return false;
					}

					// Add to the tile map
					tilemap.SetTile(mx, my, tileId);
				}
			}

			return true;
		}
	}
}
