namespace Unity;

[Token(Token = "0x20006AE")]
internal sealed class ThrowStub : ObjectDisposedException
{

	[Address(RVA = "0x147E920", Offset = "0x147DB20", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002FF1")]
	public static void ThrowNotSupportedException() { }

}

