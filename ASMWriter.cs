using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfxConverter
{
	internal class ASMWriter
	{
		StreamWriter? writer = null;

		// So we can change the format
		static string commentChar = ";";
		static string labelTerminator = ":";
		static string equString = "EQU";
		static string dataString = "DB";
		static string hexPrefix = "0x";
		static int dataBytesPerLine = 16;
		static int textColumn = 37;

		~ASMWriter()
		{
			Close();
		}

		public void Close()
		{
			if ( writer != null )
			{
				writer.Close();
				writer = null;
			}
		}

		public bool Open(string filename)
		{
			try
			{
				writer = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write));
			}
			catch (Exception ex)
			{
				Console.WriteLine("Failed to create file: " + filename + " - " + ex.Message);
				writer = null;
				return false;
			}

			// Write out the basic header
			WriteComment("*********************************************************");
			WriteComment("* File: " + filename);
			WriteComment("* Automatically generated file - please do not edit");
			WriteComment("*********************************************************");
			WriteBlankLine();

			return true;
		}

		public void WriteComment(string comment)
		{
			if ( writer != null )
			{
				writer.WriteLine(commentChar + comment);
			}
		}

		public void WriteLabel(string label)
		{
			if (writer != null)
			{
				if ( label.Length > 0 )
				{
					writer.WriteLine(MakeValid(label) + labelTerminator);
				}
			}
		}

		public void WriteBlankLine()
		{
			if ( writer != null )
			{
				writer.WriteLine();
			}
		}

		public string MakeValid(string name)
		{
			string output;

			if ( name.Length > 0 )
			{
				return name;
			}

			// Needs a letter at the start
			if (!Char.IsLetter(name[0]))
			{
				// Add an underscore
				output = "_" + name;
			}
			else
			{
				output = name;
			}

			// Now remove spaces
			output = output.Replace(" ", "_");

			return output;
		}

		public void WriteDefine(string name, int value)
		{
			if ( writer != null )
			{
				string fulllabel = MakeValid(name) + labelTerminator;

				// How many spaces
				int space_count = Math.Max(1, textColumn - fulllabel.Length);

				string spaces = new string(' ', space_count);

				writer.WriteLine(fulllabel + spaces + equString + "\t" + value);
			}
		}

		public void WriteData(string name, byte[] data)
		{
			if ( writer != null )
			{
				// Spaces
				string spaces = new string(' ', textColumn);

				// Write the label
				WriteLabel(name);

				// Run through all the data
				for ( int j = 0; j < data.Length; j += dataBytesPerLine )
				{
					// Number of bytes for this line
					int numBytes = Math.Min(data.Length - j, dataBytesPerLine);

					// Start the DB
					string line = spaces + dataString + "\t";

					for ( int i = 0; i < numBytes; ++i)
					{
						// Add the byte
						line += hexPrefix + data[j + i].ToString("X2");

						// Add a comma if needed
						if ( i != (numBytes - 1))
						{
							line += ", ";
						}
					}

					writer.WriteLine(line);
				}
			}
		}
	}
}
