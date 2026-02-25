namespace System.Xml.Schema;

[Token(Token = "0x20000E1")]
internal sealed class NfaContentValidator : ContentValidator
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000495")]
	private BitSet firstpos; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000496")]
	private BitSet[] followpos; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000497")]
	private SymbolsDictionary symbols; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000498")]
	private Positions positions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000499")]
	private int endMarkerPos; //Field offset: 0x38

	[Address(RVA = "0x16AC1E0", Offset = "0x16AB3E0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008E1")]
	internal NfaContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

}

