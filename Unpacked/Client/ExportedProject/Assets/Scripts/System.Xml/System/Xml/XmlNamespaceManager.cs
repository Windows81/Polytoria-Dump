namespace System.Xml;

[Token(Token = "0x20000B5")]
public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
{
	[Token(Token = "0x20000B6")]
	private struct NamespaceDeclaration
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041F")]
		public string prefix; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000420")]
		public string uri; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000421")]
		public int scopeId; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000422")]
		public int previousNsIndex; //Field offset: 0x14

		[Address(RVA = "0x16ABD70", Offset = "0x16AAF70", Length = "0x4A")]
		[CalledBy(Type = typeof(XmlNamespaceManager), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000817")]
		public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000417")]
	private NamespaceDeclaration[] nsdecls; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000418")]
	private int lastDecl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000419")]
	private XmlNameTable nameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400041A")]
	private int scopeId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400041B")]
	private Dictionary<String, Int32> hashTable; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400041C")]
	private bool useHashtable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400041D")]
	private string xml; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400041E")]
	private string xmlNs; //Field offset: 0x48

	[Token(Token = "0x170001D1")]
	public override string DefaultNamespace
	{
		[Address(RVA = "0x16B9620", Offset = "0x16B8820", Length = "0x43")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600080F")]
		 get { } //Length: 67
	}

	[Token(Token = "0x170001D0")]
	public override XmlNameTable NameTable
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080C")]
	internal XmlNamespaceManager() { }

	[Address(RVA = "0x16B93B0", Offset = "0x16B85B0", Length = "0x26D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "set_Namespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "GetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlParserContext))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600080D")]
	public XmlNamespaceManager(XmlNameTable nameTable) { }

	[Address(RVA = "0x16B89F0", Offset = "0x16B7BF0", Length = "0x456")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NamespaceDeclaration), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(XmlNamespaceManager), Member = "LookupNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000812")]
	public override void AddNamespace(string prefix, string uri) { }

	[Address(RVA = "0x16B9620", Offset = "0x16B8820", Length = "0x43")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600080F")]
	public override string get_DefaultNamespace() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080E")]
	public override XmlNameTable get_NameTable() { }

	[Address(RVA = "0x16B8E50", Offset = "0x16B8050", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000813")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x16B9190", Offset = "0x16B8390", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNamespaceManager), Member = "LookupNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000814")]
	public override string LookupNamespace(string prefix) { }

	[Address(RVA = "0x16B8FC0", Offset = "0x16B81C0", Length = "0x1C4")]
	[CalledBy(Type = typeof(XmlNamespaceManager), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNamespaceManager), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000815")]
	private int LookupNamespaceDecl(string prefix) { }

	[Address(RVA = "0x16B91E0", Offset = "0x16B83E0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000816")]
	public override string LookupPrefix(string uri) { }

	[Address(RVA = "0x16B92C0", Offset = "0x16B84C0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000811")]
	public override bool PopScope() { }

	[Address(RVA = "0x1006C50", Offset = "0x1005E50", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000810")]
	public override void PushScope() { }

}

