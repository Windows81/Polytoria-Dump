namespace System.Xml.Schema;

[Token(Token = "0x200015C")]
public class XmlSchemaSet
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005FF")]
	private XmlNameTable nameTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000600")]
	private SortedList schemas; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000601")]
	private ValidationEventHandler internalEventHandler; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000602")]
	private ValidationEventHandler eventHandler; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000603")]
	private Hashtable schemaLocations; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000604")]
	private Hashtable chameleonSchemas; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000605")]
	private Hashtable targetNamespaces; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000606")]
	private bool compileAll; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000607")]
	private SchemaInfo cachedCompiledInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000608")]
	private XmlReaderSettings readerSettings; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000609")]
	private XmlSchemaCompilationSettings compilationSettings; //Field offset: 0x60

	[Address(RVA = "0x16D9F80", Offset = "0x16D9180", Length = "0x5A")]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "get_Schemas", ReturnType = typeof(XmlSchemaSet))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000B7A")]
	public XmlSchemaSet() { }

	[Address(RVA = "0x16D9FE0", Offset = "0x16D91E0", Length = "0x56F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000B7B")]
	public XmlSchemaSet(XmlNameTable nameTable) { }

	[Address(RVA = "0x16D9F30", Offset = "0x16D9130", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B7C")]
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

}

