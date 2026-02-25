namespace System.Xml.Schema;

[Token(Token = "0x2000168")]
internal abstract class XmlBaseConverter : XmlValueConverter
{
	[Token(Token = "0x4000660")]
	protected static readonly Type ICollectionType; //Field offset: 0x0
	[Token(Token = "0x4000661")]
	protected static readonly Type IEnumerableType; //Field offset: 0x8
	[Token(Token = "0x4000662")]
	protected static readonly Type IListType; //Field offset: 0x10
	[Token(Token = "0x4000663")]
	protected static readonly Type ObjectArrayType; //Field offset: 0x18
	[Token(Token = "0x4000664")]
	protected static readonly Type StringArrayType; //Field offset: 0x20
	[Token(Token = "0x4000665")]
	protected static readonly Type XmlAtomicValueArrayType; //Field offset: 0x28
	[Token(Token = "0x4000666")]
	protected static readonly Type DecimalType; //Field offset: 0x30
	[Token(Token = "0x4000667")]
	protected static readonly Type Int32Type; //Field offset: 0x38
	[Token(Token = "0x4000668")]
	protected static readonly Type Int64Type; //Field offset: 0x40
	[Token(Token = "0x4000669")]
	protected static readonly Type StringType; //Field offset: 0x48
	[Token(Token = "0x400066A")]
	protected static readonly Type XmlAtomicValueType; //Field offset: 0x50
	[Token(Token = "0x400066B")]
	protected static readonly Type ObjectType; //Field offset: 0x58
	[Token(Token = "0x400066C")]
	protected static readonly Type ByteType; //Field offset: 0x60
	[Token(Token = "0x400066D")]
	protected static readonly Type Int16Type; //Field offset: 0x68
	[Token(Token = "0x400066E")]
	protected static readonly Type SByteType; //Field offset: 0x70
	[Token(Token = "0x400066F")]
	protected static readonly Type UInt16Type; //Field offset: 0x78
	[Token(Token = "0x4000670")]
	protected static readonly Type UInt32Type; //Field offset: 0x80
	[Token(Token = "0x4000671")]
	protected static readonly Type UInt64Type; //Field offset: 0x88
	[Token(Token = "0x4000672")]
	protected static readonly Type XPathItemType; //Field offset: 0x90
	[Token(Token = "0x4000673")]
	protected static readonly Type DoubleType; //Field offset: 0x98
	[Token(Token = "0x4000674")]
	protected static readonly Type SingleType; //Field offset: 0xA0
	[Token(Token = "0x4000675")]
	protected static readonly Type DateTimeType; //Field offset: 0xA8
	[Token(Token = "0x4000676")]
	protected static readonly Type DateTimeOffsetType; //Field offset: 0xB0
	[Token(Token = "0x4000677")]
	protected static readonly Type BooleanType; //Field offset: 0xB8
	[Token(Token = "0x4000678")]
	protected static readonly Type ByteArrayType; //Field offset: 0xC0
	[Token(Token = "0x4000679")]
	protected static readonly Type XmlQualifiedNameType; //Field offset: 0xC8
	[Token(Token = "0x400067A")]
	protected static readonly Type UriType; //Field offset: 0xD0
	[Token(Token = "0x400067B")]
	protected static readonly Type TimeSpanType; //Field offset: 0xD8
	[Token(Token = "0x400067C")]
	protected static readonly Type XPathNavigatorType; //Field offset: 0xE0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065D")]
	private XmlSchemaType schemaType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400065E")]
	private XmlTypeCode typeCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400065F")]
	private Type clrTypeDefault; //Field offset: 0x20

	[Token(Token = "0x1700033D")]
	protected Type DefaultClrType
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C11")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700033A")]
	protected XmlSchemaType SchemaType
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C0E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700033B")]
	protected XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C0F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700033C")]
	protected string XmlTypeName
	{
		[Address(RVA = "0x16C9CD0", Offset = "0x16C8ED0", Length = "0x1FC")]
		[CalledBy(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
		[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlListConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000C10")]
		 get { } //Length: 508
	}

	[Address(RVA = "0x16C91B0", Offset = "0x16C83B0", Length = "0x80F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000C4E")]
	private static XmlBaseConverter() { }

	[Address(RVA = "0x16C99C0", Offset = "0x16C8BC0", Length = "0x5F")]
	[CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BD4")]
	protected XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	[Address(RVA = "0x16C9B10", Offset = "0x16C8D10", Length = "0x14E")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlStringConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlStringConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlBooleanConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlBooleanConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlNumeric2Converter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_TypeCode", ReturnType = typeof(XmlTypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000BD1")]
	protected XmlBaseConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x16C9A20", Offset = "0x16C8C20", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BD2")]
	protected XmlBaseConverter(XmlTypeCode typeCode) { }

	[Address(RVA = "0x16C9C60", Offset = "0x16C8E60", Length = "0x6F")]
	[CalledBy(Type = typeof(XmlAnyListConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlAnyListConverter), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlListConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BD3")]
	protected XmlBaseConverter(XmlBaseConverter converterAtomic) { }

	[Address(RVA = "0x16C3B00", Offset = "0x16C2D00", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C2C")]
	protected static string AnyUriToString(Uri value) { }

	[Address(RVA = "0x16C3B20", Offset = "0x16C2D20", Length = "0x49")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C2D")]
	protected static string Base64BinaryToString(Byte[] value) { }

	[Address(RVA = "0x16C3B70", Offset = "0x16C2D70", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C15")]
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x16C3C20", Offset = "0x16C2E20", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C08")]
	public virtual object ChangeType(decimal value, Type destinationType) { }

	[Address(RVA = "0x16C3DD0", Offset = "0x16C2FD0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C09")]
	public virtual object ChangeType(double value, Type destinationType) { }

	[Address(RVA = "0x16C3CB0", Offset = "0x16C2EB0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C0A")]
	public virtual object ChangeType(int value, Type destinationType) { }

	[Address(RVA = "0x16C3D70", Offset = "0x16C2F70", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C0B")]
	public virtual object ChangeType(long value, Type destinationType) { }

	[Address(RVA = "0x16C3C00", Offset = "0x16C2E00", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C0C")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x16C3BD0", Offset = "0x16C2DD0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C0D")]
	public virtual object ChangeType(object value, Type destinationType) { }

	[Address(RVA = "0x16C3E30", Offset = "0x16C3030", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C07")]
	public virtual object ChangeType(DateTime value, Type destinationType) { }

	[Address(RVA = "0x16C3D10", Offset = "0x16C2F10", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C06")]
	public virtual object ChangeType(bool value, Type destinationType) { }

	[Address(RVA = "0x16C3EB0", Offset = "0x16C30B0", Length = "0x2FB")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlAnyConverter), Member = "ToNavigator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNavigator)}, ReturnType = typeof(XPathNavigator))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlBaseConverter), Member = "get_XmlTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000C13")]
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	[Address(RVA = "0x16C41B0", Offset = "0x16C33B0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C37")]
	protected static string DateOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C4230", Offset = "0x16C3430", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C42")]
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	[Address(RVA = "0x16C4280", Offset = "0x16C3480", Length = "0x7F")]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C38")]
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C4300", Offset = "0x16C3500", Length = "0x75")]
	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C2F")]
	protected static string DateTimeToString(DateTime value) { }

	[Address(RVA = "0x16C4380", Offset = "0x16C3580", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C2E")]
	protected static string DateToString(DateTime value) { }

	[Address(RVA = "0x16C4400", Offset = "0x16C3600", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C30")]
	protected static string DayTimeDurationToString(TimeSpan value) { }

	[Address(RVA = "0x16C4470", Offset = "0x16C3670", Length = "0x1EB")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000C43")]
	internal static int DecimalToInt32(decimal value) { }

	[Address(RVA = "0x16C4660", Offset = "0x16C3860", Length = "0x1F5")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000C44")]
	protected static long DecimalToInt64(decimal value) { }

	[Address(RVA = "0x16C4860", Offset = "0x16C3A60", Length = "0x1E1")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000C45")]
	protected static ulong DecimalToUInt64(decimal value) { }

	[Address(RVA = "0x16C4A50", Offset = "0x16C3C50", Length = "0x5C")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C31")]
	protected static string DurationToString(TimeSpan value) { }

	[Address(RVA = "0x16C4AB0", Offset = "0x16C3CB0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C39")]
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C4B30", Offset = "0x16C3D30", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C32")]
	protected static string GDayToString(DateTime value) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C11")]
	protected Type get_DefaultClrType() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C0E")]
	protected XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C0F")]
	protected XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16C9CD0", Offset = "0x16C8ED0", Length = "0x1FC")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlListConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C10")]
	protected string get_XmlTypeName() { }

	[Address(RVA = "0x16C4BB0", Offset = "0x16C3DB0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C3B")]
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C4C30", Offset = "0x16C3E30", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C34")]
	protected static string GMonthDayToString(DateTime value) { }

	[Address(RVA = "0x16C4CB0", Offset = "0x16C3EB0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C3A")]
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C4D30", Offset = "0x16C3F30", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C33")]
	protected static string GMonthToString(DateTime value) { }

	[Address(RVA = "0x16C4DB0", Offset = "0x16C3FB0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C3D")]
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C4E30", Offset = "0x16C4030", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C36")]
	protected static string GYearMonthToString(DateTime value) { }

	[Address(RVA = "0x16C4EB0", Offset = "0x16C40B0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C3C")]
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C4F30", Offset = "0x16C4130", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C35")]
	protected static string GYearToString(DateTime value) { }

	[Address(RVA = "0x16C4FB0", Offset = "0x16C41B0", Length = "0xF1")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C46")]
	protected static byte Int32ToByte(int value) { }

	[Address(RVA = "0x16C50B0", Offset = "0x16C42B0", Length = "0xF6")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C47")]
	protected static short Int32ToInt16(int value) { }

	[Address(RVA = "0x16C51B0", Offset = "0x16C43B0", Length = "0xF6")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C48")]
	protected static sbyte Int32ToSByte(int value) { }

	[Address(RVA = "0x16C52B0", Offset = "0x16C44B0", Length = "0xF1")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C49")]
	protected static ushort Int32ToUInt16(int value) { }

	[Address(RVA = "0x16C53B0", Offset = "0x16C45B0", Length = "0xFC")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C4A")]
	protected static int Int64ToInt32(long value) { }

	[Address(RVA = "0x16C54B0", Offset = "0x16C46B0", Length = "0xF4")]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlNumeric10Converter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C4B")]
	protected static uint Int64ToUInt32(long value) { }

	[Address(RVA = "0x16C55B0", Offset = "0x16C47B0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C12")]
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	[Address(RVA = "0x16C5770", Offset = "0x16C4970", Length = "0x1D6")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C3E")]
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x16C5650", Offset = "0x16C4850", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000C14")]
	protected static string QNameToString(XmlQualifiedName name) { }

	[Address(RVA = "0x16C5950", Offset = "0x16C4B50", Length = "0x77")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000C16")]
	protected static Byte[] StringToBase64Binary(string value) { }

	[Address(RVA = "0x16C5B70", Offset = "0x16C4D70", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C17")]
	protected static DateTime StringToDate(string value) { }

	[Address(RVA = "0x16C59D0", Offset = "0x16C4BD0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C20")]
	protected static DateTimeOffset StringToDateOffset(string value) { }

	[Address(RVA = "0x16C5AF0", Offset = "0x16C4CF0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C18")]
	protected static DateTime StringToDateTime(string value) { }

	[Address(RVA = "0x16C5A60", Offset = "0x16C4C60", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C21")]
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	[Address(RVA = "0x16C5BF0", Offset = "0x16C4DF0", Length = "0x62")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000C19")]
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	[Address(RVA = "0x16C5C60", Offset = "0x16C4E60", Length = "0x5C")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000C1A")]
	protected static TimeSpan StringToDuration(string value) { }

	[Address(RVA = "0x16C5D50", Offset = "0x16C4F50", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C1B")]
	protected static DateTime StringToGDay(string value) { }

	[Address(RVA = "0x16C5CC0", Offset = "0x16C4EC0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C22")]
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	[Address(RVA = "0x16C5F70", Offset = "0x16C5170", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C1C")]
	protected static DateTime StringToGMonth(string value) { }

	[Address(RVA = "0x16C5E60", Offset = "0x16C5060", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C1D")]
	protected static DateTime StringToGMonthDay(string value) { }

	[Address(RVA = "0x16C5DD0", Offset = "0x16C4FD0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C24")]
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	[Address(RVA = "0x16C5EE0", Offset = "0x16C50E0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C23")]
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	[Address(RVA = "0x16C6190", Offset = "0x16C5390", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C1E")]
	protected static DateTime StringToGYear(string value) { }

	[Address(RVA = "0x16C6080", Offset = "0x16C5280", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C1F")]
	protected static DateTime StringToGYearMonth(string value) { }

	[Address(RVA = "0x16C5FF0", Offset = "0x16C51F0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C26")]
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	[Address(RVA = "0x16C6100", Offset = "0x16C5300", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C25")]
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	[Address(RVA = "0x16C6210", Offset = "0x16C5410", Length = "0xCA")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "FromBinHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C27")]
	protected static Byte[] StringToHexBinary(string value) { }

	[Address(RVA = "0x16C62E0", Offset = "0x16C54E0", Length = "0x2DC")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(ValidateNames), Member = "ParseQNameThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000C28")]
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x16C6650", Offset = "0x16C5850", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C29")]
	protected static DateTime StringToTime(string value) { }

	[Address(RVA = "0x16C65C0", Offset = "0x16C57C0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C2A")]
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	[Address(RVA = "0x16C66D0", Offset = "0x16C58D0", Length = "0x62")]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000C2B")]
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	[Address(RVA = "0x16C6740", Offset = "0x16C5940", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C40")]
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C67C0", Offset = "0x16C59C0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C3F")]
	protected static string TimeToString(DateTime value) { }

	[Address(RVA = "0x16C6BA0", Offset = "0x16C5DA0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDA")]
	public virtual bool ToBoolean(object value) { }

	[Address(RVA = "0x16C6C60", Offset = "0x16C5E60", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BD8")]
	public virtual bool ToBoolean(long value) { }

	[Address(RVA = "0x16C6840", Offset = "0x16C5A40", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BD7")]
	public virtual bool ToBoolean(int value) { }

	[Address(RVA = "0x16C69E0", Offset = "0x16C5BE0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BD6")]
	public virtual bool ToBoolean(double value) { }

	[Address(RVA = "0x16C6AC0", Offset = "0x16C5CC0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BD5")]
	public virtual bool ToBoolean(DateTime value) { }

	[Address(RVA = "0x16C6920", Offset = "0x16C5B20", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BD9")]
	public virtual bool ToBoolean(string value) { }

	[Address(RVA = "0x16C71D0", Offset = "0x16C63D0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE1")]
	public virtual DateTime ToDateTime(object value) { }

	[Address(RVA = "0x16C7530", Offset = "0x16C6730", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDC")]
	public virtual DateTime ToDateTime(DateTimeOffset value) { }

	[Address(RVA = "0x16C72A0", Offset = "0x16C64A0", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDE")]
	public virtual DateTime ToDateTime(int value) { }

	[Address(RVA = "0x16C7000", Offset = "0x16C6200", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDD")]
	public virtual DateTime ToDateTime(double value) { }

	[Address(RVA = "0x16C7380", Offset = "0x16C6580", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDB")]
	public virtual DateTime ToDateTime(bool value) { }

	[Address(RVA = "0x16C7460", Offset = "0x16C6660", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE0")]
	public virtual DateTime ToDateTime(string value) { }

	[Address(RVA = "0x16C70F0", Offset = "0x16C62F0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDF")]
	public virtual DateTime ToDateTime(long value) { }

	[Address(RVA = "0x16C6E20", Offset = "0x16C6020", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE2")]
	public virtual DateTimeOffset ToDateTimeOffset(DateTime value) { }

	[Address(RVA = "0x16C6D40", Offset = "0x16C5F40", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE3")]
	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	[Address(RVA = "0x16C6F20", Offset = "0x16C6120", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE4")]
	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	[Address(RVA = "0x16C7700", Offset = "0x16C6900", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE5")]
	public virtual decimal ToDecimal(string value) { }

	[Address(RVA = "0x16C7620", Offset = "0x16C6820", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE6")]
	public virtual decimal ToDecimal(object value) { }

	[Address(RVA = "0x16C7C00", Offset = "0x16C6E00", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEA")]
	public virtual double ToDouble(long value) { }

	[Address(RVA = "0x16C77E0", Offset = "0x16C69E0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEC")]
	public virtual double ToDouble(object value) { }

	[Address(RVA = "0x16C7B20", Offset = "0x16C6D20", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE9")]
	public virtual double ToDouble(int value) { }

	[Address(RVA = "0x16C78A0", Offset = "0x16C6AA0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE8")]
	public virtual double ToDouble(DateTime value) { }

	[Address(RVA = "0x16C7980", Offset = "0x16C6B80", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE7")]
	public virtual double ToDouble(bool value) { }

	[Address(RVA = "0x16C7A60", Offset = "0x16C6C60", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEB")]
	public virtual double ToDouble(string value) { }

	[Address(RVA = "0x16C80F0", Offset = "0x16C72F0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BED")]
	public virtual int ToInt32(bool value) { }

	[Address(RVA = "0x16C8010", Offset = "0x16C7210", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEF")]
	public virtual int ToInt32(double value) { }

	[Address(RVA = "0x16C7DA0", Offset = "0x16C6FA0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEE")]
	public virtual int ToInt32(DateTime value) { }

	[Address(RVA = "0x16C7E80", Offset = "0x16C7080", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF2")]
	public virtual int ToInt32(object value) { }

	[Address(RVA = "0x16C7CE0", Offset = "0x16C6EE0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF1")]
	public virtual int ToInt32(string value) { }

	[Address(RVA = "0x16C7F40", Offset = "0x16C7140", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF0")]
	public virtual int ToInt32(long value) { }

	[Address(RVA = "0x16C8290", Offset = "0x16C7490", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF4")]
	public virtual long ToInt64(DateTime value) { }

	[Address(RVA = "0x16C85D0", Offset = "0x16C77D0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF3")]
	public virtual long ToInt64(bool value) { }

	[Address(RVA = "0x16C8430", Offset = "0x16C7630", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF5")]
	public virtual long ToInt64(double value) { }

	[Address(RVA = "0x16C81C0", Offset = "0x16C73C0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF6")]
	public virtual long ToInt64(int value) { }

	[Address(RVA = "0x16C8370", Offset = "0x16C7570", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF7")]
	public virtual long ToInt64(string value) { }

	[Address(RVA = "0x16C8510", Offset = "0x16C7710", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF8")]
	public virtual long ToInt64(object value) { }

	[Address(RVA = "0x16C8760", Offset = "0x16C7960", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BF9")]
	public virtual float ToSingle(double value) { }

	[Address(RVA = "0x16C86A0", Offset = "0x16C78A0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BFA")]
	public virtual float ToSingle(string value) { }

	[Address(RVA = "0x16C8840", Offset = "0x16C7A40", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BFB")]
	public virtual float ToSingle(object value) { }

	[Address(RVA = "0x16C8900", Offset = "0x16C7B00", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C01")]
	public virtual string ToString(int value) { }

	[Address(RVA = "0x16C8E90", Offset = "0x16C8090", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C02")]
	public virtual string ToString(long value) { }

	[Address(RVA = "0x16C8DC0", Offset = "0x16C7FC0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C03")]
	public virtual string ToString(float value) { }

	[Address(RVA = "0x16C8A90", Offset = "0x16C7C90", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C04")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x16C89C0", Offset = "0x16C7BC0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BFE")]
	public virtual string ToString(DateTimeOffset value) { }

	[Address(RVA = "0x16C8C20", Offset = "0x16C7E20", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BFD")]
	public virtual string ToString(DateTime value) { }

	[Address(RVA = "0x16C8F70", Offset = "0x16C8170", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BFC")]
	public virtual string ToString(bool value) { }

	[Address(RVA = "0x16C8F50", Offset = "0x16C8150", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C05")]
	public virtual string ToString(object value) { }

	[Address(RVA = "0x16C8B50", Offset = "0x16C7D50", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BFF")]
	public virtual string ToString(decimal value) { }

	[Address(RVA = "0x16C8CF0", Offset = "0x16C7EF0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C00")]
	public virtual string ToString(double value) { }

	[Address(RVA = "0x16C90C0", Offset = "0x16C82C0", Length = "0x75")]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000C4C")]
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	[Address(RVA = "0x16C9030", Offset = "0x16C8230", Length = "0x90")]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000C4D")]
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	[Address(RVA = "0x16C9140", Offset = "0x16C8340", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(DurationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000C41")]
	protected static string YearMonthDurationToString(TimeSpan value) { }

}

