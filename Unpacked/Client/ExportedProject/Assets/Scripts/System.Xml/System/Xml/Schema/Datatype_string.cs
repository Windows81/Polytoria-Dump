namespace System.Xml.Schema;

[Token(Token = "0x20000EF")]
internal class Datatype_string : Datatype_anySimpleType
{

	[Token(Token = "0x1700022A")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000923")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700022B")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A8510", Offset = "0x16A7710", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000924")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700022D")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000926")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700022C")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x7C8160", Offset = "0x7C7360", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000925")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A8490", Offset = "0x16A7690", Length = "0x7A")]
	[CalledBy(Type = typeof(Datatype_Name), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_ENUMERATION), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_ENTITY), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_IDREF), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_ID), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_NCName), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_NMTOKEN), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_tokenV1Compat), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_token), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_normalizedStringV1Compat), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_normalizedString), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_language), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000928")]
	public Datatype_string() { }

	[Address(RVA = "0x16A8370", Offset = "0x16A7570", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlStringConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[Token(Token = "0x6000922")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000923")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A8510", Offset = "0x16A7710", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000924")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000926")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x7C8160", Offset = "0x7C7360", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000925")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A8380", Offset = "0x16A7580", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000927")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

