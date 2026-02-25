namespace System.Xml.Schema;

[Token(Token = "0x200015F")]
public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400060B")]
	private XmlQualifiedName itemTypeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400060C")]
	private XmlSchemaSimpleType itemType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400060D")]
	private XmlSchemaSimpleType baseItemType; //Field offset: 0x20

	[Token(Token = "0x17000331")]
	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B82")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B83")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000330")]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B81")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x16DA550", Offset = "0x16D9750", Length = "0x6B")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B84")]
	public XmlSchemaSimpleTypeList() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B82")]
	public XmlSchemaSimpleType get_BaseItemType() { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B83")]
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B81")]
	public void set_ItemType(XmlSchemaSimpleType value) { }

}

