namespace System.Net.Configuration;

[Token(Token = "0x2000335")]
public sealed class WebProxyScriptElement : ConfigurationElement
{

	[Token(Token = "0x17000445")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x17319D0", Offset = "0x1730BD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x6001432")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x17319A0", Offset = "0x1730BA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001431")]
	public WebProxyScriptElement() { }

	[Address(RVA = "0x17319D0", Offset = "0x1730BD0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001432")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

