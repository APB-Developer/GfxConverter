using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class LoadHandler : CommandHandler
	{
		public override bool IsValid(ScriptCommand sc)
		{
			if ( sc.GetNumberArguments() != 1)
			{
				return false;
			}

			return true;
		}

		public override bool Run(ScriptCommand sc, ExportData ed)
		{
			Console.WriteLine("Loading: " + sc.GetArgumentAsString(0));

			if ( !ed.LoadImage(sc.GetArgumentAsString(0)) )
			{
				return false;
			}

			return true;
		}
	}
}
