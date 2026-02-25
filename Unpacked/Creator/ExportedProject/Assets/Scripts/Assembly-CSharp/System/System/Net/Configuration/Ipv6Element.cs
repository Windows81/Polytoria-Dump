namespace System.Net.Configuration;

[Token(Token = "0x200032F")]
public sealed class Ipv6Element : ConfigurationElement
{

	[Token(Token = "0x17000440")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x1718CD0", Offset = "0x1717ED0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x6001427")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1718CA0", Offset = "0x1717EA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001426")]
	public Ipv6Element() { }

	[Address(RVA = "0x1718CD0", Offset = "0x1717ED0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001427")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

