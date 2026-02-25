namespace MoonSharp.Interpreter.Interop.BasicDescriptors;

[Flags]
[Token(Token = "0x2000138")]
public enum MemberDescriptorAccess
{
	CanRead = 1,
	CanWrite = 2,
	CanExecute = 4,
}

