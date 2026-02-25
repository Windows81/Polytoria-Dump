namespace System.Xml.Schema;

[Token(Token = "0x2000148")]
public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005C7")]
	private string ns; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005C8")]
	private XmlSchemaContentProcessing processContents; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005C9")]
	private NamespaceList namespaceList; //Field offset: 0x20

	[DefaultValue(XmlSchemaContentProcessing::None (0))]
	[Token(Token = "0x17000314")]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B34")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B36")]
	public XmlSchemaAnyAttribute() { }

	[Address(RVA = "0x16D7710", Offset = "0x16D6910", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B35")]
	internal void BuildNamespaceList(string targetNamespace) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B34")]
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

}

