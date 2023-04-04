using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class ClearPaletteHandler : CommandHandler
	{
		public override bool IsValid(ScriptCommand sc)
		{
			if (sc.GetNumberArguments() != 0)
			{
				return false;
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Clearing Palette");

			// Get Working palette
			SamPalette workingPalette = ed.GetWorkingPalette();

			// Copy all the entries
			workingPalette.Reset();

			return true;
		}
	}
}
