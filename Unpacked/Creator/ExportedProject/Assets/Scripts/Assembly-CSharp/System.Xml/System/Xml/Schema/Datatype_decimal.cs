namespace System.Xml.Schema;

[Token(Token = "0x20000F3")]
internal class Datatype_decimal : Datatype_anySimpleType
{
	[Token(Token = "0x400052E")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400052F")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000530")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x17000241")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600094C")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700023D")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A5250", Offset = "0x16A4450", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000948")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000240")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A52A0", Offset = "0x16A44A0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600094B")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700023E")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x1498F70", Offset = "0x1498170", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000949")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700023F")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A52F0", Offset = "0x16A44F0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600094A")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A5030", Offset = "0x16A4230", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000950")]
	private static Datatype_decimal() { }

	[Address(RVA = "0x16A51D0", Offset = "0x16A43D0", Length = "0x7A")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_nonPositiveInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_negativeInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_long), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_nonNegativeInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_positiveInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_fixed), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600094F")]
	public Datatype_decimal() { }

	[Address(RVA = "0x16A4DF0", Offset = "0x16A3FF0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600094D")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A4E90", Offset = "0x16A4090", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNumeric10Converter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[Token(Token = "0x6000947")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600094C")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A5250", Offset = "0x16A4450", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000948")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A52A0", Offset = "0x16A44A0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600094B")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x1498F70", Offset = "0x1498170", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000949")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A52F0", Offset = "0x16A44F0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600094A")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A4EA0", Offset = "0x16A40A0", Length = "0x18D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Decimal&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600094E")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

