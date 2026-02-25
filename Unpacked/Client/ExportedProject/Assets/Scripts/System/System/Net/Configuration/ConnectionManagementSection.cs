namespace System.Net.Configuration;

[Token(Token = "0x200032B")]
public sealed class ConnectionManagementSection : ConfigurationSection
{

	[Token(Token = "0x1700043C")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x1718490", Offset = "0x1717690", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x600141E")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1718460", Offset = "0x1717660", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600141D")]
	public ConnectionManagementSection() { }

	[Address(RVA = "0x1718490", Offset = "0x1717690", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600141E")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

