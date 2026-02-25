namespace MoonSharp.Interpreter;

[Flags]
[Token(Token = "0x2000056")]
public enum TypeValidationFlags
{
	None = 0,
	AllowNil = 1,
	AutoConvert = 2,
	Default = 2,
}

