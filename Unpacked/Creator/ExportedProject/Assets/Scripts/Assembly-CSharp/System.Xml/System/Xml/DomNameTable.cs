namespace System.Xml;

[Token(Token = "0x200006B")]
internal class DomNameTable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002DF")]
	private XmlName[] entries; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E0")]
	private int count; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002E1")]
	private int mask; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E2")]
	private XmlDocument ownerDocument; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E3")]
	private XmlNameTable nameTable; //Field offset: 0x28

	[Address(RVA = "0x166B450", Offset = "0x166A650", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004AC")]
	public DomNameTable(XmlDocument document) { }

	[Address(RVA = "0x166ACA0", Offset = "0x1669EA0", Length = "0x4A8")]
	[CalledBy(Type = typeof(XmlDocument), Member = "AddXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlElement))]
	[CalledBy(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(XmlName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlNameEx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60004AE")]
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x166B150", Offset = "0x166A350", Length = "0x188")]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetIDInfoByElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004AD")]
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x166B2E0", Offset = "0x166A4E0", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004AF")]
	private void Grow() { }

}

