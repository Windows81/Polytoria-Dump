namespace System.Runtime.CompilerServices;

[Token(Token = "0x20004A4")]
internal static class Unsafe
{

	[Address(RVA = "0x7C8B90", Offset = "0x7C7D90", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020CA")]
	public static T Add(ref T source, int elementOffset) { }

	[Address(RVA = "0x7C8AC0", Offset = "0x7C7CC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020CB")]
	public static T Add(ref T source, IntPtr elementOffset) { }

	[Address(RVA = "0x7C8BE0", Offset = "0x7C7DE0", Length = "0x7")]
	[CallerCount(Count = 63)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020CC")]
	public static Void* Add(Void* source, int elementOffset) { }

	[Address(RVA = "0x7C8AD0", Offset = "0x7C7CD0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020DA")]
	internal static T AddByteOffset(ref T source, ulong byteOffset) { }

	[Address(RVA = "0x7C8AC0", Offset = "0x7C7CC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020CD")]
	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60020CE")]
	public static bool AreSame(ref T left, ref T right) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020CF")]
	public static T As(object o) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D0")]
	public static TTo As(ref TFrom source) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D1")]
	public static Void* AsPointer(ref T value) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D3")]
	public static T AsRef(in T source) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D2")]
	public static T AsRef(Void* source) { }

	[Address(RVA = "0x13CE6E0", Offset = "0x13CD8E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Token(Token = "0x60020D4")]
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[Address(RVA = "0x7C8DF0", Offset = "0x7C7FF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D9")]
	public static bool IsAddressLessThan(ref T left, ref T right) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D5")]
	public static T Read(Void* source) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D6")]
	public static T ReadUnaligned(ref byte source) { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D7")]
	public static int SizeOf() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020D8")]
	public static void WriteUnaligned(ref byte destination, T value) { }

}

