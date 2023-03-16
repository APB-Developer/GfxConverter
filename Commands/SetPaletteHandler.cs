using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class SetPaletteHandler : CommandHandler
	{
		public override bool IsValid(ScriptCommand sc)
		{
			// Set working palette sam colour
			if ( sc.GetNumberArguments() == 2 )
			{
				// Is index correct
				if ( !sc.IsArgumentInteger(0) || sc.GetArgumentAsInteger(0) < 0 || sc.GetArgumentAsInteger(0) > 15 )
				{
					return false;
				}

				if ( !sc.IsArgumentInteger(1) || sc.GetArgumentAsInteger(1) < 0 || sc.GetArgumentAsInteger(1) > 127 )
				{
					return false;
				}
			}
			else if (sc.GetNumberArguments() == 4 )
			{
				// Set working palette RGB colour - Is index correct
				if (!sc.IsArgumentInteger(0) || sc.GetArgumentAsInteger(0) < 0 || sc.GetArgumentAsInteger(0) > 15)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(1) || sc.GetArgumentAsInteger(1) < 0 || sc.GetArgumentAsInteger(1) > 255)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(2) || sc.GetArgumentAsInteger(2) < 0 || sc.GetArgumentAsInteger(2) > 255)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(3) || sc.GetArgumentAsInteger(3) < 0 || sc.GetArgumentAsInteger(3) > 255)
				{
					return false;
				}
			}
			else if (sc.GetNumberArguments() == 3)
			{
				// Named palette - sam coupe colour
				if (!sc.IsArgumentInteger(1) || sc.GetArgumentAsInteger(1) < 0 || sc.GetArgumentAsInteger(1) > 15)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(2) || sc.GetArgumentAsInteger(2) < 0 || sc.GetArgumentAsInteger(2) > 127)
				{
					return false;
				}
			}
			else if (sc.GetNumberArguments() == 5)
			{
				// Set named palette RGB colour
				if (!sc.IsArgumentInteger(1) || sc.GetArgumentAsInteger(1) < 0 || sc.GetArgumentAsInteger(1) > 15)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(2) || sc.GetArgumentAsInteger(2) < 0 || sc.GetArgumentAsInteger(2) > 255)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(3) || sc.GetArgumentAsInteger(3) < 0 || sc.GetArgumentAsInteger(3) > 255)
				{
					return false;
				}

				if (!sc.IsArgumentInteger(4) || sc.GetArgumentAsInteger(4) < 0 || sc.GetArgumentAsInteger(4) > 255)
				{
					return false;
				}
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			int r = 0, g = 0, b = 0, samColour = -1, index = 1;
			string paletteName = "";
			SamPalette? samPalette = null;

			Console.Write("Setting Palette: ");

			// Get the details
			switch ( sc.GetNumberArguments() )
			{
				case 2:
					index = sc.GetArgumentAsInteger(0);
					samColour = sc.GetArgumentAsInteger(1);
					break;

				case 3:
					paletteName = sc.GetArgumentAsString(0);
					index = sc.GetArgumentAsInteger(1);
					samColour = sc.GetArgumentAsInteger(2);
					break;

				case 4:
					index = sc.GetArgumentAsInteger(0);
					r = sc.GetArgumentAsInteger(1);
					g = sc.GetArgumentAsInteger(2);
					b = sc.GetArgumentAsInteger(3);
					break;

				case 5:
					paletteName = sc.GetArgumentAsString(0);
					index = sc.GetArgumentAsInteger(1);
					r = sc.GetArgumentAsInteger(2);
					g = sc.GetArgumentAsInteger(3);
					b = sc.GetArgumentAsInteger(4);
					break;

				default:
					Console.WriteLine("Unable to set palette - incorrect arguments");
					return false;
			}

			// Get the right palette
			if ( paletteName.Length > 0 )
			{
				Console.Write("Name=" + paletteName + " : ");

				// Get existing or create new palete
				samPalette = ed.AddPalette(paletteName);

				if ( samPalette == null )
				{
					Console.WriteLine("Unable to find or create palette: " + paletteName);
					return false;
				}
			}
			else
			{
				samPalette = ed.GetWorkingPalette();


				if (samPalette == null)
				{
					Console.WriteLine("No Working Palette: ");
					return false;
				}
			}

			// Are we setting a sam colour or RGB colour
			if ( samColour < 0 )
			{
				Console.WriteLine("Index=" + index + " : RGB=" + r + "," + g + "," + b);

				samPalette.SetRGBEntry(index, r, g, b);
			}
			else
			{
				Console.WriteLine("Index=" + index + " : Sam Colour: " + samColour);

				samPalette.SetSamEntry(index, samColour);
			}

			return true;
		}
	}
}
