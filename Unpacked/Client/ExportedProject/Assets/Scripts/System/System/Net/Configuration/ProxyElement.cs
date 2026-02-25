namespace System.Net.Configuration;

[Token(Token = "0x200032D")]
public sealed class ProxyElement : ConfigurationElement
{

	[Token(Token = "0x1700043E")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x171B6E0", Offset = "0x171A8E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x6001423")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x171B6B0", Offset = "0x171A8B0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001422")]
	public ProxyElement() { }

	[Address(RVA = "0x171B6E0", Offset = "0x171A8E0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001423")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

