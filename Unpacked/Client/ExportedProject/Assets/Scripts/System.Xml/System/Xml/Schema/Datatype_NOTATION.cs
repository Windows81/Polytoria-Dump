namespace System.Xml.Schema;

[Token(Token = "0x2000113")]
internal class Datatype_NOTATION : Datatype_anySimpleType
{
	[Token(Token = "0x400053E")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400053F")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000280")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C9")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700027B")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A1F80", Offset = "0x16A1180", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009C4")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x1700027F")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A1FE0", Offset = "0x16A11E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009C8")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700027D")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700027C")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE1C0", Offset = "0x3CD3C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C5")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700027E")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A2030", Offset = "0x16A1230", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009C7")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A1E30", Offset = "0x16A1030", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60009CC")]
	private static Datatype_NOTATION() { }

	[Address(RVA = "0x16A1F00", Offset = "0x16A1100", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009CB")]
	public Datatype_NOTATION() { }

	[Address(RVA = "0x16A1C40", Offset = "0x16A0E40", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C3")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C9")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A1F80", Offset = "0x16A1180", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009C4")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A1FE0", Offset = "0x16A11E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009C8")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C6")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x3CE1C0", Offset = "0x3CD3C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C5")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A2030", Offset = "0x16A1230", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009C7")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A1C50", Offset = "0x16A0E50", Length = "0x1DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver), typeof(String&)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009CA")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

