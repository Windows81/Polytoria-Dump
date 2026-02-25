namespace System.Xml.Linq;

[Token(Token = "0x200000E")]
internal struct ElementWriter
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000017")]
	private XmlWriter _writer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000018")]
	private NamespaceResolver _resolver; //Field offset: 0x8

	[Address(RVA = "0x163C720", Offset = "0x163B920", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000051")]
	public ElementWriter(XmlWriter writer) { }

	[Address(RVA = "0x163BCF0", Offset = "0x163AEF0", Length = "0xDD")]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NamespaceResolver), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000053")]
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	[Address(RVA = "0x163BDD0", Offset = "0x163AFD0", Length = "0x21C")]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[Calls(Type = typeof(NamespaceResolver), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XNamespace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000054")]
	private void PushAncestors(XElement e) { }

	[Address(RVA = "0x163BFF0", Offset = "0x163B1F0", Length = "0x19A")]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[Calls(Type = typeof(NamespaceResolver), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XNamespace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000055")]
	private void PushElement(XElement e) { }

	[Address(RVA = "0x163C190", Offset = "0x163B390", Length = "0x1F4")]
	[CalledBy(Type = typeof(XElement), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ElementWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NamespaceResolver), Member = "PopScope", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000052")]
	public void WriteElement(XElement e) { }

	[Address(RVA = "0x163C390", Offset = "0x163B590", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NamespaceResolver), Member = "PopScope", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000056")]
	private void WriteEndElement() { }

	[Address(RVA = "0x163C3D0", Offset = "0x163B5D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NamespaceResolver), Member = "PopScope", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000057")]
	private void WriteFullEndElement() { }

	[Address(RVA = "0x163C410", Offset = "0x163B610", Length = "0x30C")]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ElementWriter), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000058")]
	private void WriteStartElement(XElement e) { }

}

