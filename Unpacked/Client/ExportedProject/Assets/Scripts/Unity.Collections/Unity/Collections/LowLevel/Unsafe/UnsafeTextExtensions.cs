namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[Token(Token = "0x2000057")]
internal static class UnsafeTextExtensions
{

	[Address(RVA = "0x1821690", Offset = "0x1820890", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Extension]
	[Token(Token = "0x6000090")]
	public static UnsafeList<Byte>& AsUnsafeListOfBytes(ref UnsafeText text) { }

	[Address(RVA = "0x1821640", Offset = "0x1820840", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Extension]
	[Token(Token = "0x6000091")]
	public static UnsafeList<Byte> AsUnsafeListOfBytesRO(UnsafeText text) { }

}

