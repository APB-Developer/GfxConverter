using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class GrabPaletteHandler : CommandHandler
	{
		public override bool IsValid(ScriptCommand sc)
		{
			if ( sc.GetNumberArguments() != 1 )
			{
				return false;
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Grabbing Palette to " + sc.GetArgumentAsString(0));

			// Get the palette we need
			SamPalette samPalette = ed.AddPalette(sc.GetArgumentAsString(0));

			// Get Working palette
			SamPalette workingPalette = ed.GetWorkingPalette();

			// Copy all the entries
			samPalette.Reset();

			for ( int i = 0; i < workingPalette.GetNumEntries(); ++i)
			{
				samPalette.SetSamEntry(i, workingPalette.GetSamEntry(i));
			}

			return true;
		}
	}
}
