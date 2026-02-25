namespace System.Net.NetworkInformation;

[Token(Token = "0x20002CB")]
internal static class Win32IPGlobalPropertiesFactoryPal
{

	[Address(RVA = "0x1715DF0", Offset = "0x1714FF0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001208")]
	public static IPGlobalProperties Create() { }

}

