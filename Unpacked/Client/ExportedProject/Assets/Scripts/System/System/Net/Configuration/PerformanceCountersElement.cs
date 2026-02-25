namespace System.Net.Configuration;

[Token(Token = "0x2000332")]
public sealed class PerformanceCountersElement : ConfigurationElement
{

	[Token(Token = "0x17000442")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x171B680", Offset = "0x171A880", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x600142C")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x171B650", Offset = "0x171A850", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600142B")]
	public PerformanceCountersElement() { }

	[Address(RVA = "0x171B680", Offset = "0x171A880", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600142C")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

