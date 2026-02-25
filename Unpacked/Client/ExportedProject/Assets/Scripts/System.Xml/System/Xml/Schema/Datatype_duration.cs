namespace System.Xml.Schema;

[Token(Token = "0x20000F4")]
internal class Datatype_duration : Datatype_anySimpleType
{
	[Token(Token = "0x4000531")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000532")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000246")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000956")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000242")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A5D50", Offset = "0x16A4F50", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000952")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000245")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A5DA0", Offset = "0x16A4FA0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000955")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000243")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x15A4DA0", Offset = "0x15A3FA0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000953")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000244")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A5DF0", Offset = "0x16A4FF0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000954")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A5C00", Offset = "0x16A4E00", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600095A")]
	private static Datatype_duration() { }

	[Address(RVA = "0x16A5CD0", Offset = "0x16A4ED0", Length = "0x7A")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_yearMonthDuration), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_dayTimeDuration), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000959")]
	public Datatype_duration() { }

	[Address(RVA = "0x16A5960", Offset = "0x16A4B60", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000957")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A1C40", Offset = "0x16A0E40", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000951")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000956")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A5D50", Offset = "0x16A4F50", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000952")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A5DA0", Offset = "0x16A4FA0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000955")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x15A4DA0", Offset = "0x15A3FA0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000953")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A5DF0", Offset = "0x16A4FF0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000954")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A5A00", Offset = "0x16A4C00", Length = "0x1F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000958")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

