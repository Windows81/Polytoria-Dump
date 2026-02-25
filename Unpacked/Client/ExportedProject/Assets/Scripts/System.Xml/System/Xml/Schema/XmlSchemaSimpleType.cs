namespace System.Xml.Schema;

[Token(Token = "0x200015D")]
public class XmlSchemaSimpleType : XmlSchemaType
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400060A")]
	private XmlSchemaSimpleTypeContent content; //Field offset: 0x40

	[Token(Token = "0x1700032F")]
	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	public XmlSchemaSimpleTypeContent Content
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7E")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x16DA720", Offset = "0x16D9920", Length = "0x7")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaType), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000B7D")]
	public XmlSchemaSimpleType() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7E")]
	public XmlSchemaSimpleTypeContent get_Content() { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7F")]
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

}

