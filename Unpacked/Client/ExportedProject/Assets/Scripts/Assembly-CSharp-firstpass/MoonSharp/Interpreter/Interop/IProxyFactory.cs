namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000DC")]
public interface IProxyFactory
{

	[Token(Token = "0x17000127")]
	public Type ProxyType
	{
		[Token(Token = "0x60008DB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000126")]
	public Type TargetType
	{
		[Token(Token = "0x60008DA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60008D9")]
	public object CreateProxyObject(object o) { }

	[Token(Token = "0x60008DB")]
	public Type get_ProxyType() { }

	[Token(Token = "0x60008DA")]
	public Type get_TargetType() { }

}

