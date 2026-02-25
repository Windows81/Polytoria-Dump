namespace System.Net.Configuration;

[Token(Token = "0x2000334")]
public sealed class SocketElement : ConfigurationElement
{

	[Token(Token = "0x17000444")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x171D3F0", Offset = "0x171C5F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x6001430")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x171D3C0", Offset = "0x171C5C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600142F")]
	public SocketElement() { }

	[Address(RVA = "0x171D3F0", Offset = "0x171C5F0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001430")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

