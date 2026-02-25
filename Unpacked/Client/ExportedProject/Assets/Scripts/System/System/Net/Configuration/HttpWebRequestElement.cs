namespace System.Net.Configuration;

[Token(Token = "0x200032E")]
public sealed class HttpWebRequestElement : ConfigurationElement
{

	[Token(Token = "0x1700043F")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x1718B20", Offset = "0x1717D20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x6001425")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1718AF0", Offset = "0x1717CF0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001424")]
	public HttpWebRequestElement() { }

	[Address(RVA = "0x1718B20", Offset = "0x1717D20", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6001425")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

