namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000DD")]
public interface IProxyFactory : IProxyFactory
{

	[Token(Token = "0x60008DC")]
	public TProxy CreateProxyObject(TTarget target) { }

}

