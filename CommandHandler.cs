using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class CommandHandler
	{
		public virtual bool IsValid(ScriptCommand sc)
		{
			return false;
		}

		public virtual bool Run(ScriptCommand sc, ExportData ed)
		{
			return false;
		}
	}
}
