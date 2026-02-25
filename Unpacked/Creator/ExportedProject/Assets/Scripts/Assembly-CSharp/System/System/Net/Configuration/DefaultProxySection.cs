namespace System.Net.Configuration;

[Token(Token = "0x200032C")]
public sealed class DefaultProxySection : ConfigurationSection
{

	[Token(Token = "0x1700043D")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x1718520", Offset = "0x1717720", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x6001420")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x17184F0", Offset = "0x17176F0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600141F")]
	public DefaultProxySection() { }

	[Address(RVA = "0x1718520", Offset = "0x1717720", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001420")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

	[Address(RVA = "0x17184C0", Offset = "0x17176C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001421")]
	protected virtual void Reset(ConfigurationElement parentElement) { }

}

