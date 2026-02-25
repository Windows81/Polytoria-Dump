namespace System;

[Token(Token = "0x200015B")]
public interface IServiceProvider
{

	[Token(Token = "0x6000BF4")]
	public object GetService(Type serviceType) { }

}

