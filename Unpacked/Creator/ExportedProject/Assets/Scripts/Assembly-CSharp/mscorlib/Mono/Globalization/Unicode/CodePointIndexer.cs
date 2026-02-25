namespace Mono.Globalization.Unicode;

[Token(Token = "0x200004E")]
internal class CodePointIndexer
{
	[Token(Token = "0x200004F")]
	public struct TableRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000156")]
		public readonly int Start; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000157")]
		public readonly int End; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000158")]
		public readonly int Count; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000159")]
		public readonly int IndexStart; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015A")]
		public readonly int IndexEnd; //Field offset: 0x10

		[Address(RVA = "0x12E7F90", Offset = "0x12E7190", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000BA")]
		public TableRange(int start, int end, int indexStart) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000152")]
	private readonly TableRange[] ranges; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000153")]
	public readonly int TotalCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000154")]
	private int defaultIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000155")]
	private int defaultCP; //Field offset: 0x20

	[Address(RVA = "0x12D77A0", Offset = "0x12D69A0", Length = "0x1B3")]
	[CalledBy(Type = typeof(MSCompatUnicodeTableUtil), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NormalizationTableUtil), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000B8")]
	public CodePointIndexer(Int32[] starts, Int32[] ends, int defaultIndex, int defaultCP) { }

	[Address(RVA = "0x12D7720", Offset = "0x12D6920", Length = "0x76")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NormalizationTableUtil), Member = "PropIdx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NormalizationTableUtil), Member = "MapIdx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType"}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Normalization), Member = "GetCombiningClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Normalization), Member = "GetPrimaryCompositeFromMapIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "GetPrimaryCompositeHelperIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B9")]
	public int ToIndex(int cp) { }

}

