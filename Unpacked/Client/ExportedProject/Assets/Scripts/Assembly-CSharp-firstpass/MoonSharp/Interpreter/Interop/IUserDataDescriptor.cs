namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000D2")]
public interface IUserDataDescriptor
{

	[Token(Token = "0x1700011D")]
	public string Name
	{
		[Token(Token = "0x60008A4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700011E")]
	public Type Type
	{
		[Token(Token = "0x60008A5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60008A8")]
	public string AsString(object obj) { }

	[Token(Token = "0x60008A4")]
	public string get_Name() { }

	[Token(Token = "0x60008A5")]
	public Type get_Type() { }

	[Token(Token = "0x60008A6")]
	public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing) { }

	[Token(Token = "0x60008AA")]
	public bool IsTypeCompatible(Type type, object obj) { }

	[Token(Token = "0x60008A9")]
	public DynValue MetaIndex(Script script, object obj, string metaname) { }

	[Token(Token = "0x60008A7")]
	public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing) { }

}

