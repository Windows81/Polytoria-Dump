namespace System.Xml.Schema;

[Token(Token = "0x2000107")]
internal class Datatype_QName : Datatype_anySimpleType
{
	[Token(Token = "0x400053C")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400053D")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000269")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009A2")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000264")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A27B0", Offset = "0x16A19B0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600099D")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x17000268")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A2810", Offset = "0x16A1A10", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009A1")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000266")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600099F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000265")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE1A0", Offset = "0x3CD3A0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600099E")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000267")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A2860", Offset = "0x16A1A60", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009A0")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A2660", Offset = "0x16A1860", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60009A5")]
	private static Datatype_QName() { }

	[Address(RVA = "0x16A2730", Offset = "0x16A1930", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009A4")]
	public Datatype_QName() { }

	[Address(RVA = "0x16A1C40", Offset = "0x16A0E40", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[DeduplicatedMethod]
	[Token(Token = "0x600099C")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A2")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A27B0", Offset = "0x16A19B0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600099D")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A2810", Offset = "0x16A1A10", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009A1")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600099F")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x3CE1A0", Offset = "0x3CD3A0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600099E")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A2860", Offset = "0x16A1A60", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009A0")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A2480", Offset = "0x16A1680", Length = "0x1DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver), typeof(String&)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009A3")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

