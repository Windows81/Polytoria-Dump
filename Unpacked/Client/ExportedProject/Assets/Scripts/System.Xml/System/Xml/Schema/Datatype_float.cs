namespace System.Xml.Schema;

[Token(Token = "0x20000F1")]
internal class Datatype_float : Datatype_anySimpleType
{
	[Token(Token = "0x400052A")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400052B")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000237")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000938")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000233")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A67B0", Offset = "0x16A59B0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000934")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000236")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A6800", Offset = "0x16A5A00", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000937")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000234")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x150E790", Offset = "0x150D990", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000935")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000235")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A6850", Offset = "0x16A5A50", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000936")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A6670", Offset = "0x16A5870", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600093C")]
	private static Datatype_float() { }

	[Address(RVA = "0x16A6730", Offset = "0x16A5930", Length = "0x7A")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_floatXdr), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600093B")]
	public Datatype_float() { }

	[Address(RVA = "0x16A6490", Offset = "0x16A5690", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000939")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A55A0", Offset = "0x16A47A0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNumeric2Converter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000933")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000938")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A67B0", Offset = "0x16A59B0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000934")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A6800", Offset = "0x16A5A00", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000937")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x150E790", Offset = "0x150D990", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000935")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A6850", Offset = "0x16A5A50", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000936")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A64F0", Offset = "0x16A56F0", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600093A")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

