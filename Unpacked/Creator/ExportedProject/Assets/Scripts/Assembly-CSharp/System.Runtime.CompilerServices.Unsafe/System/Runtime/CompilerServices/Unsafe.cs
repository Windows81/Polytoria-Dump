namespace System.Runtime.CompilerServices;

[Token(Token = "0x2000002")]
public static class Unsafe
{

	[Address(RVA = "0x7C8AC0", Offset = "0x7C7CC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x6000003")]
	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x6000002")]
	public static TTo As(ref TFrom source) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x6000001")]
	public static T AsRef(ref T source) { }

}

