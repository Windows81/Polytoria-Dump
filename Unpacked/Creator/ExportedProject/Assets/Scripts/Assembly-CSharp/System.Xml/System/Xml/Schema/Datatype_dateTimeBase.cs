namespace System.Xml.Schema;

[Token(Token = "0x20000F7")]
internal class Datatype_dateTimeBase : Datatype_anySimpleType
{
	[Token(Token = "0x4000533")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000534")]
	private static readonly Type listValueType; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000535")]
	private XsdDateTimeFlags dateTimeFlags; //Field offset: 0x38

	[Token(Token = "0x1700024D")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000967")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000249")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A4900", Offset = "0x16A3B00", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000962")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700024C")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A4950", Offset = "0x16A3B50", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000966")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700024A")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x13024E0", Offset = "0x13016E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000963")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700024B")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A49A0", Offset = "0x16A3BA0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000965")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A47A0", Offset = "0x16A39A0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600096A")]
	private static Datatype_dateTimeBase() { }

	[Address(RVA = "0x16A4870", Offset = "0x16A3A70", Length = "0x89")]
	[CalledBy(Type = typeof(Datatype_date), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_month), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_day), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_monthDay), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_year), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_yearMonth), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_time), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_timeNoTimeZone), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_dateTime), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_dateTimeTimeZone), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_dateTimeNoTimeZone), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_timeTimeZone), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000964")]
	internal Datatype_dateTimeBase(XsdDateTimeFlags dateTimeFlags) { }

	[Address(RVA = "0x16A42E0", Offset = "0x16A34E0", Length = "0x158")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000968")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A4440", Offset = "0x16A3640", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDateTimeConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(XmlValueConverter))]
	[Token(Token = "0x6000961")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x3008F0", Offset = "0x2FFAF0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000967")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x16A4900", Offset = "0x16A3B00", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000962")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A4950", Offset = "0x16A3B50", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000966")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x13024E0", Offset = "0x13016E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000963")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A49A0", Offset = "0x16A3BA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000965")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A4450", Offset = "0x16A3650", Length = "0x34E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(XsdDateTime), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdDateTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(XsdDateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags), typeof(XsdDateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000969")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

