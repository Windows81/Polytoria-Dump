namespace MoonSharp.Interpreter.Platforms;

[Token(Token = "0x20000B6")]
public interface IPlatformAccessor
{

	[Token(Token = "0x60007DD")]
	public string DefaultInput(string prompt) { }

	[Token(Token = "0x60007DC")]
	public void DefaultPrint(string content) { }

	[Token(Token = "0x60007D8")]
	public CoreModules FilterSupportedCoreModules(CoreModules module) { }

	[Token(Token = "0x60007D9")]
	public string GetEnvironmentVariable(string envvarname) { }

	[Token(Token = "0x60007DB")]
	public string GetPlatformName() { }

	[Token(Token = "0x60007DF")]
	public Stream IO_GetStandardStream(StandardFileType type) { }

	[Token(Token = "0x60007DE")]
	public Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode) { }

	[Token(Token = "0x60007E0")]
	public string IO_OS_GetTempFilename() { }

	[Token(Token = "0x60007DA")]
	public bool IsRunningOnAOT() { }

	[Token(Token = "0x60007E5")]
	public int OS_Execute(string cmdline) { }

	[Token(Token = "0x60007E1")]
	public void OS_ExitFast(int exitCode) { }

	[Token(Token = "0x60007E3")]
	public void OS_FileDelete(string file) { }

	[Token(Token = "0x60007E2")]
	public bool OS_FileExists(string file) { }

	[Token(Token = "0x60007E4")]
	public void OS_FileMove(string src, string dst) { }

}

