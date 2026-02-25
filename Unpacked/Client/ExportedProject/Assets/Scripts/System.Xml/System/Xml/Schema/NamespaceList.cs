namespace System.Xml.Schema;

[Token(Token = "0x2000136")]
internal class NamespaceList
{
	[Token(Token = "0x2000137")]
	internal enum ListType
	{
		Any = 0,
		Other = 1,
		Set = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000567")]
	private ListType type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000568")]
	private Hashtable set; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000569")]
	private string targetNamespace; //Field offset: 0x20

	[Token(Token = "0x170002BC")]
	public ICollection Enumerate
	{
		[Address(RVA = "0x16BBA40", Offset = "0x16BAC40", Length = "0x79")]
		[CalledBy(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A91")]
		 get { } //Length: 121
	}

	[Token(Token = "0x170002BB")]
	public string Excluded
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A90")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002BA")]
	public ListType Type
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A8D")]
	public NamespaceList() { }

	[Address(RVA = "0x16BB7E0", Offset = "0x16BA9E0", Length = "0x25E")]
	[CalledBy(Type = typeof(XmlSchemaAny), Member = "BuildNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaAnyAttribute), Member = "BuildNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A8E")]
	public NamespaceList(string namespaces, string targetNamespace) { }

	[Address(RVA = "0x16BB320", Offset = "0x16BA520", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A92")]
	public override bool Allows(string ns) { }

	[Address(RVA = "0x16BB3B0", Offset = "0x16BA5B0", Length = "0x2A")]
	[CalledBy(Type = typeof(SymbolsDictionary), Member = "GetNamespaceListSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A93")]
	public bool Allows(XmlQualifiedName qname) { }

	[Address(RVA = "0x16BBA40", Offset = "0x16BAC40", Length = "0x79")]
	[CalledBy(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A91")]
	public ICollection get_Enumerate() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A90")]
	public string get_Excluded() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A8F")]
	public ListType get_Type() { }

	[Address(RVA = "0x16BB3E0", Offset = "0x16BA5E0", Length = "0x3F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805C3EE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000A94")]
	public virtual string ToString() { }

}

