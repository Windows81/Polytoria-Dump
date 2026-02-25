namespace MoonSharp.Interpreter;

[Flags]
[Token(Token = "0x2000071")]
public enum CoreModules
{
	None = 0,
	Basic = 64,
	GlobalConsts = 1,
	TableIterators = 2,
	Metatables = 4,
	String = 8,
	LoadMethods = 16,
	Table = 32,
	ErrorHandling = 128,
	Math = 256,
	Coroutine = 512,
	Bit32 = 1024,
	OS_Time = 2048,
	OS_System = 4096,
	IO = 8192,
	Debug = 16384,
	Dynamic = 32768,
	Json = 65536,
	Preset_HardSandbox = 1387,
	Preset_SoftSandbox = 102383,
	Preset_Default = 114687,
	Preset_Complete = 131071,
}

