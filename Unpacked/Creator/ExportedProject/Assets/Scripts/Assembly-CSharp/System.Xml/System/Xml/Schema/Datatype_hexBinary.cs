namespace System.Xml.Schema;

[Token(Token = "0x2000104")]
internal class Datatype_hexBinary : Datatype_anySimpleType
{
	[Token(Token = "0x4000536")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000537")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000259")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000983")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000255")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A6C80", Offset = "0x16A5E80", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600097F")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000258")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A6CD0", Offset = "0x16A5ED0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000982")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000256")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE240", Offset = "0x3CD440", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000980")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000257")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A6D20", Offset = "0x16A5F20", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000981")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A6B30", Offset = "0x16A5D30", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000987")]
	private static Datatype_hexBinary() { }

	[Address(RVA = "0x16A6C00", Offset = "0x16A5E00", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000986")]
	public Datatype_hexBinary() { }

	[Address(RVA = "0x16A68A0", Offset = "0x16A5AA0", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000984")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A1C40", Offset = "0x16A0E40", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[DeduplicatedMethod]
	[Token(Token = "0x600097E")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000983")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A6C80", Offset = "0x16A5E80", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600097F")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A6CD0", Offset = "0x16A5ED0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000982")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x3CE240", Offset = "0x3CD440", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000980")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A6D20", Offset = "0x16A5F20", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000981")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A69D0", Offset = "0x16A5BD0", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "FromBinHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000985")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

