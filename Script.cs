using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class Script
	{
		private Dictionary<string, CommandHandler> commandHandlers = new Dictionary<string, CommandHandler>();
		private ExportData exportData = new ExportData();

		public void Parse(string filename)
		{
			// Open the stream
			StreamReader scriptFile = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));

			while ( !scriptFile.EndOfStream)
			{
				ScriptCommand sc = new ScriptCommand(scriptFile.ReadLine());

				if ( sc.GetCommand().Length > 0 )
				{
					if ( commandHandlers.ContainsKey(sc.GetCommand()) )
					{
						if (commandHandlers[sc.GetCommand()].IsValid(sc) )
						{
							if ( !commandHandlers[sc.GetCommand()].Run(sc, exportData) )
							{
								Console.WriteLine("Command failed to run: " + sc.GetCommand());
							}
						}
						else
						{
							Console.WriteLine("Command has invalid number of parameters: " + sc.GetCommand());
						}
					}
					else
					{
						Console.WriteLine("Unable to handle command: " + sc.GetCommand());
					}
				}
			}
		}

		public void RegisterHandler(string command, CommandHandler handler)
		{
			commandHandlers.Add(command.ToUpper(), handler);
		}
	}
}
