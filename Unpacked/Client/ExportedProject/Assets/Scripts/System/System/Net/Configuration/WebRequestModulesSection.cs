namespace System.Net.Configuration;

[Token(Token = "0x2000336")]
public sealed class WebRequestModulesSection : ConfigurationSection
{

	[Token(Token = "0x17000446")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x1731A60", Offset = "0x1730C60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x6001434")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1731A30", Offset = "0x1730C30", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001433")]
	public WebRequestModulesSection() { }

	[Address(RVA = "0x1731A60", Offset = "0x1730C60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001434")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

