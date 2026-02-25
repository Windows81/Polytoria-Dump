namespace System.Xml.Schema;

[Token(Token = "0x200014F")]
public abstract class XmlSchemaDatatype
{

	[Token(Token = "0x17000321")]
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Token(Token = "0x6000B4C")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000320")]
	internal abstract FacetsChecker FacetsChecker
	{
		[Token(Token = "0x6000B4B")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x1700031F")]
	internal abstract RestrictionFacets Restriction
	{
		[Token(Token = "0x6000B48")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x1700031B")]
	public abstract XmlTokenizedType TokenizedType
	{
		[Token(Token = "0x6000B43")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700031D")]
	public override XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B46")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000322")]
	internal string TypeCodeString
	{
		[Address(RVA = "0x16D8BD0", Offset = "0x16D7DD0", Length = "0x14D")]
		[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlSchemaDatatype), Member = "TypeCodeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000B4E")]
		internal get { } //Length: 333
	}

	[Token(Token = "0x1700031E")]
	internal abstract XmlValueConverter ValueConverter
	{
		[Token(Token = "0x6000B47")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x1700031A")]
	public abstract Type ValueType
	{
		[Token(Token = "0x6000B42")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700031C")]
	public override XmlSchemaDatatypeVariety Variety
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B45")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B51")]
	protected XmlSchemaDatatype() { }

	[Token(Token = "0x6000B49")]
	internal abstract int Compare(object value1, object value2) { }

	[Address(RVA = "0x16D85F0", Offset = "0x16D77F0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
	[Token(Token = "0x6000B50")]
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	[Token(Token = "0x6000B4C")]
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Token(Token = "0x6000B4B")]
	internal abstract FacetsChecker get_FacetsChecker() { }

	[Token(Token = "0x6000B48")]
	internal abstract RestrictionFacets get_Restriction() { }

	[Token(Token = "0x6000B43")]
	public abstract XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B46")]
	public override XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16D8BD0", Offset = "0x16D7DD0", Length = "0x14D")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "GetTypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Numeric10FacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "TypeCodeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000B4E")]
	internal string get_TypeCodeString() { }

	[Token(Token = "0x6000B47")]
	internal abstract XmlValueConverter get_ValueConverter() { }

	[Token(Token = "0x6000B42")]
	public abstract Type get_ValueType() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B45")]
	public override XmlSchemaDatatypeVariety get_Variety() { }

	[Token(Token = "0x6000B4D")]
	internal abstract bool IsEqual(object o1, object o2) { }

	[Token(Token = "0x6000B44")]
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[Token(Token = "0x6000B4A")]
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	[Address(RVA = "0x16D8640", Offset = "0x16D7840", Length = "0x24C")]
	[CalledBy(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000B4F")]
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

}

