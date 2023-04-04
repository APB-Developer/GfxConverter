using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class LoadHandler : CommandHandler
	{
		enum eOptions
		{
			eOPTION_UNKNOWN = 0,
			eOPTION_NONE,
			eOPTION_NO_RESET,
			eOPTION_NO_ADDITION,
		};

		private Dictionary<string, eOptions> optionTypes = new Dictionary<string, eOptions>()
		{
			{"NO_RESET",            eOptions.eOPTION_NO_RESET },
			{"NO_ADDITION",			eOptions.eOPTION_NO_ADDITION },
		};

		private eOptions GetOptionFromString(string option)
		{
			option = option.ToUpper();

			// Is it in the dictionary
			if (optionTypes.ContainsKey(option))
			{
				return optionTypes[option];
			}

			return eOptions.eOPTION_NONE;
		}

		public override bool IsValid(ScriptCommand sc)
		{
			if ( sc.GetNumberArguments() != 1 && sc.GetNumberArguments() != 2 )
			{
				return false;
			}

			if ( sc.GetNumberArguments() == 2 )
			{
				if (GetOptionFromString(sc.GetArgumentAsString(1)) == eOptions.eOPTION_UNKNOWN )
				{
					return false;
				}
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Loading: " + sc.GetArgumentAsString(0));

			bool bResetPalette = true;
			bool bAddToPalette = true;

			// Are we passing arguments
			if ( sc.GetNumberArguments() == 2 )
			{
				switch (GetOptionFromString(sc.GetArgumentAsString(1)))
				{
					case eOptions.eOPTION_NONE:
						break;

					case eOptions.eOPTION_NO_RESET:
						bResetPalette = false;
						break;

					case eOptions.eOPTION_NO_ADDITION:
						bResetPalette = false;
						bAddToPalette = false;
						break;

					default:
						return false;
				}
			}

			if ( !ed.LoadImage(sc.GetArgumentAsString(0), bResetPalette, bAddToPalette) )
			{
				return false;
			}

			return true;
		}
	}
}
