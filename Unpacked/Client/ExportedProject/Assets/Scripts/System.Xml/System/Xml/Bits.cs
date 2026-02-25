namespace System.Xml;

[Token(Token = "0x200000B")]
internal static class Bits
{
	[Token(Token = "0x4000013")]
	private static readonly uint MASK_0101010101010101; //Field offset: 0x0
	[Token(Token = "0x4000014")]
	private static readonly uint MASK_0011001100110011; //Field offset: 0x4
	[Token(Token = "0x4000015")]
	private static readonly uint MASK_0000111100001111; //Field offset: 0x8
	[Token(Token = "0x4000016")]
	private static readonly uint MASK_0000000011111111; //Field offset: 0xC
	[Token(Token = "0x4000017")]
	private static readonly uint MASK_1111111111111111; //Field offset: 0x10

	[Address(RVA = "0x162C790", Offset = "0x162B990", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600001B")]
	private static Bits() { }

	[Address(RVA = "0x162C5F0", Offset = "0x162B7F0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000019")]
	public static int Count(uint num) { }

	[Address(RVA = "0x162C690", Offset = "0x162B890", Length = "0xF8")]
	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600001A")]
	public static int LeastPosition(uint num) { }

}

