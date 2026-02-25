namespace System.Net.Configuration;

[Token(Token = "0x2000333")]
public sealed class ServicePointManagerElement : ConfigurationElement
{

	[Token(Token = "0x17000443")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x171C8E0", Offset = "0x171BAE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x600142E")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x171C8B0", Offset = "0x171BAB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600142D")]
	public ServicePointManagerElement() { }

	[Address(RVA = "0x171C8E0", Offset = "0x171BAE0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600142E")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

