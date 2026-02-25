namespace System.Xml.Schema;

[Token(Token = "0x20000F0")]
internal class Datatype_boolean : Datatype_anySimpleType
{
	[Token(Token = "0x4000528")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000529")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000232")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600092E")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700022E")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A38F0", Offset = "0x16A2AF0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600092A")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000231")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A3940", Offset = "0x16A2B40", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600092D")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700022F")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x14BF860", Offset = "0x14BEA60", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600092B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000230")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A3990", Offset = "0x16A2B90", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600092C")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A37B0", Offset = "0x16A29B0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000932")]
	private static Datatype_boolean() { }

	[Address(RVA = "0x16A3870", Offset = "0x16A2A70", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000931")]
	public Datatype_boolean() { }

	[Address(RVA = "0x16A3610", Offset = "0x16A2810", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600092F")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A3680", Offset = "0x16A2880", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlBooleanConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[Token(Token = "0x6000929")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600092E")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A38F0", Offset = "0x16A2AF0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600092A")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A3940", Offset = "0x16A2B40", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600092D")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x14BF860", Offset = "0x14BEA60", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600092B")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A3990", Offset = "0x16A2B90", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600092C")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A3690", Offset = "0x16A2890", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000930")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

