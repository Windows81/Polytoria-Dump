namespace System.Xml.Schema;

[Token(Token = "0x2000162")]
public class XmlSchemaType : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000610")]
	private XmlSchemaDerivationMethod final; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000611")]
	private XmlSchemaDerivationMethod derivedBy; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000612")]
	private XmlSchemaType baseSchemaType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000613")]
	private XmlSchemaDatatype datatype; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000614")]
	private SchemaElementDecl elementDecl; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000615")]
	private XmlQualifiedName qname; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000616")]
	private XmlSchemaContentType contentType; //Field offset: 0x38

	[Token(Token = "0x17000334")]
	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B89")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000335")]
	[XmlIgnore]
	public XmlSchemaDatatype Datatype
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B8A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000339")]
	internal SchemaElementDecl ElementDecl
	{
		[Address(RVA = "0xF5D840", Offset = "0xF5CA40", Length = "0x18")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B92")]
		internal get { } //Length: 24
		[Address(RVA = "0x16DA980", Offset = "0x16D9B80", Length = "0x2F")]
		[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000B93")]
		internal set { } //Length: 47
	}

	[Token(Token = "0x17000336")]
	[XmlIgnore]
	public override bool IsMixed
	{
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B8B")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000333")]
	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[Address(RVA = "0x1428020", Offset = "0x1427220", Length = "0x18")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B88")]
		 get { } //Length: 24
	}

	[Token(Token = "0x17000337")]
	[XmlIgnore]
	public XmlTypeCode TypeCode
	{
		[Address(RVA = "0x16DA840", Offset = "0x16D9A40", Length = "0xB5")]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000B8C")]
		 get { } //Length: 181
	}

	[Token(Token = "0x17000338")]
	[XmlIgnore]
	internal XmlValueConverter ValueConverter
	{
		[Address(RVA = "0x16DA900", Offset = "0x16D9B00", Length = "0x78")]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_TypedValue", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_Value", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = "ValueAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsLong", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsInt", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsDouble", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsDateTime", ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsBoolean", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Datatype_List), Member = "CreateValueConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
		[CalledBy(Type = typeof(XPathNavigator), Member = "ValueAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsLong", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsInt", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsDouble", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsDateTime", ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsBoolean", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XPathNavigator), Member = "get_TypedValue", ReturnType = typeof(object))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000B8D")]
		internal get { } //Length: 120
	}

	[Address(RVA = "0x16DA7B0", Offset = "0x16D99B0", Length = "0x83")]
	[CalledBy(Type = typeof(XmlSchemaSimpleType), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B95")]
	public XmlSchemaType() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B89")]
	public XmlSchemaType get_BaseXmlSchemaType() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8A")]
	public XmlSchemaDatatype get_Datatype() { }

	[Address(RVA = "0xF5D840", Offset = "0xF5CA40", Length = "0x18")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B92")]
	internal SchemaElementDecl get_ElementDecl() { }

	[Address(RVA = "0x1428020", Offset = "0x1427220", Length = "0x18")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B88")]
	public XmlQualifiedName get_QualifiedName() { }

	[Address(RVA = "0x16DA840", Offset = "0x16D9A40", Length = "0xB5")]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B8C")]
	public XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16DA900", Offset = "0x16D9B00", Length = "0x78")]
	[CalledBy(Type = typeof(XPathNavigator), Member = "get_TypedValue", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsBoolean", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsDateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsDouble", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsInt", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "get_ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Datatype_List), Member = "CreateValueConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XPathNavigator), Member = "ValueAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsDateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsDouble", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsInt", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = "ValueAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_TypedValue", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAtomicValue), Member = "get_ValueAsBoolean", ReturnType = typeof(bool))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B8D")]
	internal XmlValueConverter get_ValueConverter() { }

	[Address(RVA = "0x16DA730", Offset = "0x16D9930", Length = "0x47")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Token(Token = "0x6000B87")]
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	[Address(RVA = "0x16DA980", Offset = "0x16D9B80", Length = "0x2F")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B93")]
	internal void set_ElementDecl(SchemaElementDecl value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8B")]
	public override void set_IsMixed(bool value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B8F")]
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B94")]
	internal void SetContentType(XmlSchemaContentType value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B91")]
	internal void SetDatatype(XmlSchemaDatatype value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B90")]
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0x16DA780", Offset = "0x16D9980", Length = "0x2F")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B8E")]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

