namespace System.Xml.Schema;

[Token(Token = "0x2000147")]
public class XmlSchemaAny : XmlSchemaParticle
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005C4")]
	private string ns; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005C5")]
	private XmlSchemaContentProcessing processContents; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005C6")]
	private NamespaceList namespaceList; //Field offset: 0x48

	[Token(Token = "0x17000313")]
	[XmlIgnore]
	internal NamespaceList NamespaceList
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B31")]
		internal get { } //Length: 5
	}

	[DefaultValue(XmlSchemaContentProcessing::None (0))]
	[Token(Token = "0x17000312")]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B30")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x16D7850", Offset = "0x16D6A50", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000B33")]
	public XmlSchemaAny() { }

	[Address(RVA = "0x16D77B0", Offset = "0x16D69B0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B32")]
	internal void BuildNamespaceList(string targetNamespace) { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B31")]
	internal NamespaceList get_NamespaceList() { }

	[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B30")]
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

}

