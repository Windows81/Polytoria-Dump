namespace U8Xml.Internal;

[Token(Token = "0x200001E")]
internal static class BitOperationHelper
{

	[Token(Token = "0x17000023")]
	private static ReadOnlySpan<Byte> Log2DeBruijn
	{
		[Address(RVA = "0x1806E00", Offset = "0x1806000", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60000A6")]
		private get { } //Length: 76
	}

	[Address(RVA = "0x1806E00", Offset = "0x1806000", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000A6")]
	private static ReadOnlySpan<Byte> get_Log2DeBruijn() { }

	[Address(RVA = "0x1806D30", Offset = "0x1805F30", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000A5")]
	public static int Log2(uint value) { }

	[Address(RVA = "0x1806C60", Offset = "0x1805E60", Length = "0xC5")]
	[CalledBy(Type = typeof(CustomList`1), Member = "GetLineNumAndIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000A7")]
	private static int Log2SoftwareFallback(uint value) { }

	[Address(RVA = "0x10BD150", Offset = "0x10BC350", Length = "0x19")]
	[CallerCount(Count = 115)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A4")]
	public static uint RotateLeft(uint value, int offset) { }

}

