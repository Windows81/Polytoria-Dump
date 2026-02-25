namespace System.Xml.Schema;

[Token(Token = "0x20000E2")]
internal sealed class RangeContentValidator : ContentValidator
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400049A")]
	private BitSet firstpos; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400049B")]
	private BitSet[] followpos; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400049C")]
	private BitSet positionsWithRangeTerminals; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400049D")]
	private SymbolsDictionary symbols; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400049E")]
	private Positions positions; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400049F")]
	private int minMaxNodesCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40004A0")]
	private int endMarkerPos; //Field offset: 0x44

	[Address(RVA = "0x16B0E80", Offset = "0x16B0080", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008E2")]
	internal RangeContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

}

