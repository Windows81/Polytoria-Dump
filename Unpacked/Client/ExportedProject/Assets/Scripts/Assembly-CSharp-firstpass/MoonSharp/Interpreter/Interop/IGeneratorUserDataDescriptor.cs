namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000D0")]
public interface IGeneratorUserDataDescriptor : IUserDataDescriptor
{

	[Token(Token = "0x60008A0")]
	public IUserDataDescriptor Generate(Type type) { }

}

