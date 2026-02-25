namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000D4")]
public interface IUserDataType
{

	[Token(Token = "0x60008B2")]
	public DynValue Index(Script script, DynValue index, bool isDirectIndexing) { }

	[Token(Token = "0x60008B4")]
	public DynValue MetaIndex(Script script, string metaname) { }

	[Token(Token = "0x60008B3")]
	public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing) { }

}

