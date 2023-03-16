using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class ScriptCommand
	{
		private string command = "";
		private List<string> arguments = new List<string>();

		public ScriptCommand(string? line)
		{
			// Dont worry if the line is null
			if ( line != null )
			{
				// Now lets pull the tokens
				command = ParseToken(ref line);

				if ( command.Length > 0 )
				{
					command = command.ToUpper();

					while ( line.Length > 0 )
					{
						string arg = ParseToken(ref line);

						if ( arg.Length > 0 )
						{
							arguments.Add(arg);
						}
					}
				}
			}
		}

		public string GetCommand()
		{
			return command;
		}

		public int GetNumberArguments()
		{
			return arguments.Count;
		}

		public string GetArgumentAsString(int index)
		{
			return arguments[index];
		}

		public int GetArgumentAsInteger(int index)
		{
			int value;

			if ( Int32.TryParse(arguments[index], out value) )
			{
				return value;
			}

			return -1;
		}

		public bool IsArgumentInteger(int index)
		{
			int value;

			return Int32.TryParse(arguments[index], out value);
		}

		private string ParseToken(ref string line)
		{
			string token = "";
			char stringToken = '\0';

			// First trim 
			line = line.Trim();

			while ( line.Length > 0 )
			{
				// Get the first character
				char ch = line[0];
				line = line[1..];

				if ( stringToken == '\0' && (ch == ';' || ch=='\t' || ch==' ' || ch == ',') )
				{
					break;
				}

				// Handle strings
				if ( ch == stringToken )
				{
					stringToken = '\0';
					break;
				}
				else if ( stringToken == '\0' && (ch=='\"' || ch == '\''))
				{
					stringToken = ch;
				}
				else
				{
					token += ch;
				}
			}

			return token;
		}
	}
}
