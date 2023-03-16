using GfxConverter;

string[] commandLineArgs = Environment.GetCommandLineArgs();

if ( commandLineArgs.Count() != 2 )
{
	Console.WriteLine("Incorrect number of arguments");
	return;
}

// Create a script parser
Script myScript = new Script();

// Register Handlers
myScript.RegisterHandler("LOAD", new LoadHandler());
myScript.RegisterHandler("SET_PALETTE", new SetPaletteHandler());
myScript.RegisterHandler("GRAB_PALETTE", new GrabPaletteHandler());
myScript.RegisterHandler("CLEAR_DATA", new ClearDataHandler());
myScript.RegisterHandler("GRAB_SPRITE", new GrabSpriteHandler());
myScript.RegisterHandler("OUTPUTALL_ASM", new OutputAllHandler());


myScript.Parse(commandLineArgs[1]);