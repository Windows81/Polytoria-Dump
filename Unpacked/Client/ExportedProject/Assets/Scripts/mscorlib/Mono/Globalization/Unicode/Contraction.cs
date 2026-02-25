namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000051")]
internal class Contraction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400015F")]
	public int Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000160")]
	public readonly Char[] Source; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000161")]
	public readonly string Replacement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000162")]
	public readonly Byte[] SortKey; //Field offset: 0x28

	[Address(RVA = "0x12D7B00", Offset = "0x12D6D00", Length = "0x6F")]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(TailoringInfo), typeof(Contraction[]&), typeof(Level2Map[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BC")]
	public Contraction(int index, Char[] source, string replacement, Byte[] sortkey) { }

}

