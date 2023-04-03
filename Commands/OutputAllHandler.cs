using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class OutputAllHandler : CommandHandler
	{
		public override bool IsValid(ScriptCommand sc)
		{
			if (sc.GetNumberArguments() != 1)
			{
				return false;
			}

			return true;
		}

		public bool WriteHeader(ASMWriter writer, ExportData ed)
		{
			// Write out all the sprite header information
			string[] spriteNames = ed.GetSpriteNames();

			foreach(string name in spriteNames)
			{
				// Get the sprite
				SamSprite? sprite = ed.GetSprite(name);

				if ( sprite != null )
				{
					// Write some basic information
					writer.WriteDefine("SPR_" + name + "_Width", sprite.GetWidth());
					writer.WriteDefine("SPR_" + name + "_Height", sprite.GetHeight());
					writer.WriteDefine("SPR_" + name + "_DataSize", sprite.GetDataSize());
					writer.WriteBlankLine();
				}
			}

			writer.WriteBlankLine();

			// Now write out the palette information
			string[] paletteNames = ed.GetPaletteNames();

			foreach (string name in paletteNames)
			{
				// Get the palette
				SamPalette? palette = ed.GetPalette(name);

				if (palette != null)
				{
					// Write some basic information
					writer.WriteDefine("PAL_" + name + "_Length", palette.GetNumEntries());
					writer.WriteBlankLine();
				}
			}

			writer.WriteBlankLine();

			// Now write out the tileset information
			string[] tilesetNames = ed.GetTilesetNames();

			foreach (string name in tilesetNames)
			{
				// Get the tileset
				Tileset? tileset = ed.GetTileset(name);

				if (tileset != null)
				{
					// Write some basic information
					writer.WriteDefine("TILESET_" + name + "_TileWidth", tileset.GetWidth());
					writer.WriteDefine("TILESET_" + name + "_TileHeight", tileset.GetHeight());
					writer.WriteDefine("TILESET_" + name + "_NumTiles", tileset.GetNumTiles());
					writer.WriteBlankLine();
				}
			}

			writer.WriteBlankLine();

			// Now write out the tilemap information
			string[] tilemapNames = ed.GetTilemapNames();

			foreach (string name in tilemapNames)
			{
				// Get the tilemap
				Tilemap? tilemap = ed.GetTilemap(name);

				if (tilemap != null)
				{
					// Write some basic information
					writer.WriteDefine("TILEMAP_" + name + "_Width", tilemap.GetWidth());
					writer.WriteDefine("TILEMAP_" + name + "_Height", tilemap.GetHeight());
					writer.WriteBlankLine();
				}
			}

			writer.WriteBlankLine();

			return true;
		}

		public bool WriteData(ASMWriter writer, ExportData ed)
		{
			// Write out all the sprite header information
			string[] spriteNames = ed.GetSpriteNames();

			foreach (string name in spriteNames)
			{
				// Get the sprite
				SamSprite? sprite = ed.GetSprite(name);

				if (sprite != null)
				{
					// Write some basic information
					writer.WriteData("SPR_" + name, sprite.Serialise());
					writer.WriteBlankLine();
				}
			}

			writer.WriteBlankLine();
			
			// Now write out the palette information
			string[] paletteNames = ed.GetPaletteNames();

			foreach (string name in paletteNames)
			{
				// Get the palette
				SamPalette? palette = ed.GetPalette(name);

				if (palette != null)
				{
					// Write some basic information
					writer.WriteData("PAL_" + name, palette.Serialise());
					writer.WriteBlankLine();
				}
			}
			
			writer.WriteBlankLine();

			// Now write out the tilesets information
			string[] tilesetNames = ed.GetTilesetNames();

			foreach (string name in tilesetNames)
			{
				// Get the tileset
				Tileset? tileset = ed.GetTileset(name);

				if (tileset != null)
				{
					writer.WriteLabel("TILESET_" + name);

					// Write out all the tiles
					for (int i = 0; i < tileset.GetNumTiles(); ++i)
					{
						SamTile tile = tileset.GetTile(i);

						writer.WriteData("", tile.Serialise());
					}

					writer.WriteBlankLine();
				}
			}

			writer.WriteBlankLine();

			// Now write out the tileamps information
			string[] tilemapNames = ed.GetTilemapNames();

			foreach (string name in tilemapNames)
			{
				// Get the tilemap
				Tilemap? tilemap = ed.GetTilemap(name);

				if (tilemap != null)
				{
					writer.WriteLabel("TILEMAP_" + name);

					// Write out the tilemap
					writer.WriteData("", tilemap.Serialise());

					writer.WriteBlankLine();
				}
			}

			writer.WriteBlankLine();

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Outputing all data: " + sc.GetArgumentAsString(0));

			// Create asm writer
			ASMWriter writer = new ASMWriter();

			if ( !writer.Open(sc.GetArgumentAsString(0)))
			{
				writer.Close();
				return false;
			}

			// First write some header information
			if ( !WriteHeader(writer, ed))
			{
				writer.Close();
				return false;
			}

			if ( !WriteData(writer, ed))
			{
				writer.Close();
				return false;
			}

			writer.Close();

			return true;
		}
	}
}
