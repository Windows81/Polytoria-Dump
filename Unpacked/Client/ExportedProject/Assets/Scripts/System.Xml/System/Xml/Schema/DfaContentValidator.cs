namespace System.Xml.Schema;

[Token(Token = "0x20000E0")]
internal sealed class DfaContentValidator : ContentValidator
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000493")]
	private Int32[][] transitionTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000494")]
	private SymbolsDictionary symbols; //Field offset: 0x20

	[Address(RVA = "0x16AA9B0", Offset = "0x16A9BB0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008E0")]
	internal DfaContentValidator(Int32[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

}

