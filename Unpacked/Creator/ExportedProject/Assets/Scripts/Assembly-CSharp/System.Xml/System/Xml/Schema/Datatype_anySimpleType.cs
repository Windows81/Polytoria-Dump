namespace System.Xml.Schema;

[Token(Token = "0x20000EC")]
internal class Datatype_anySimpleType : DatatypeImplementation
{
	[Token(Token = "0x4000526")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000527")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000225")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000915")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000220")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A2B80", Offset = "0x16A1D80", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000910")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000223")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A2BD0", Offset = "0x16A1DD0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000913")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000224")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x7C8160", Offset = "0x7C7360", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000914")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000222")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000912")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000221")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A2C20", Offset = "0x16A1E20", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000911")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A2A70", Offset = "0x16A1C70", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000919")]
	private static Datatype_anySimpleType() { }

	[Address(RVA = "0x16A2B30", Offset = "0x16A1D30", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000918")]
	public Datatype_anySimpleType() { }

	[Address(RVA = "0x16A2980", Offset = "0x16A1B80", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000916")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A29F0", Offset = "0x16A1BF0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600090F")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000915")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A2B80", Offset = "0x16A1D80", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000910")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A2BD0", Offset = "0x16A1DD0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000913")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x7C8160", Offset = "0x7C7360", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000914")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000912")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A2C20", Offset = "0x16A1E20", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000911")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A2A40", Offset = "0x16A1C40", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000917")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

