namespace Unity;

[Token(Token = "0x200001C")]
internal sealed class ThrowStub : ObjectDisposedException
{

	[Address(RVA = "0x163CD50", Offset = "0x163BF50", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000097")]
	public static void ThrowNotSupportedException() { }

}

