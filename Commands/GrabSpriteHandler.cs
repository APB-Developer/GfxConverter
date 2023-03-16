using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GfxConverter
{
	internal class GrabSpriteHandler : CommandHandler
	{
		enum eOptions
		{
			eOPTION_UNKNOWN = 0,
			eOPTION_DATA,
			eOPTION_MASK,
			eOPTION_MASK_DATA,
			eOPTION_DATA_MASK,
		};

		private Dictionary<string, eOptions> optionTypes = new Dictionary<string, eOptions>()
		{
			{"DATA",            eOptions.eOPTION_DATA },
			{"MASK",            eOptions.eOPTION_MASK },
			{"MASK_DATA",       eOptions.eOPTION_MASK_DATA },
			{"DATA_MASK",       eOptions.eOPTION_DATA_MASK },
		};

		private eOptions GetOptionFromString(string option)
		{
			option = option.ToUpper();

			// Is it in the dictionary
			if ( optionTypes.ContainsKey(option))
			{
				return optionTypes[option];
			}

			return eOptions.eOPTION_UNKNOWN;
		}

		public override bool IsValid(ScriptCommand sc)
		{
			if ( sc.GetNumberArguments() != 2 && sc.GetNumberArguments() != 6 )
			{
				return false;
			}

			if ( GetOptionFromString(sc.GetArgumentAsString(1)) == eOptions.eOPTION_UNKNOWN)
			{
				return false;
			}

			if ( sc.GetNumberArguments() == 6 )
			{
				if ( !sc.IsArgumentInteger(2) || !sc.IsArgumentInteger(3) || !sc.IsArgumentInteger(4) || !sc.IsArgumentInteger(5) )
				{
					return false;
				}
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Grabbing Sprite: " + sc.GetArgumentAsString(0));

			int x = 0;
			int y = 0;
			int w = ed.GetWorkingImageWidth();
			int h = ed.GetWorkingImageHeight();

			// Read the sizes
			if ( sc.GetNumberArguments() == 6 )
			{
				x = sc.GetArgumentAsInteger(2);
				y = sc.GetArgumentAsInteger(3);
				w = sc.GetArgumentAsInteger(4);
				h = sc.GetArgumentAsInteger(5);

				if( x < 0 || x > ed.GetWorkingImageWidth() || y < 0 || y > ed.GetWorkingImageHeight() )
				{
					return false;
				}

				if ((x + w) < 0 || (x + w) > ed.GetWorkingImageWidth() || (y + h) < 0 || (y + h) > ed.GetWorkingImageHeight())
				{
					return false;
				}
			}

			// Get the format options
			eOptions options = GetOptionFromString(sc.GetArgumentAsString(1));

			// Create a sprite
			SamSprite sprite = ed.AddSprite(sc.GetArgumentAsString(0), w, h);

			if ( sprite == null )
			{
				return false;
			}

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
					byte data = 0;
					byte mask = 0;

					// See if the first pixel is transparent
					if ( p1.A != 255 || (p1.R == 255 && p1.G == 0 && p1.B == 255))
					{
						mask |= 0xf0;
					}
					else
					{
						data |= (byte)(pal.GetClosestSamFromRGB(p1) << 4);
					}

					// Check pixel 2
					if (p2.A != 255 || (p2.R == 255 && p2.G == 0 && p2.B == 255))
					{
						mask |= 0x0f;
					}
					else
					{
						data |= (byte)pal.GetClosestSamFromRGB(p2);
					}

					// Now output the right data
					switch ( options )
					{
						case eOptions.eOPTION_DATA:
							sprite.AddData(data);
							break;

						case eOptions.eOPTION_MASK:
							sprite.AddData(mask);
							break;

						case eOptions.eOPTION_MASK_DATA:
							sprite.AddData(mask);
							sprite.AddData(data);
							break;

						case eOptions.eOPTION_DATA_MASK:
							sprite.AddData(data);
							sprite.AddData(mask);
							break;

						default:
							break;
					}
				}
			}

			return true;
		}
	}
}
