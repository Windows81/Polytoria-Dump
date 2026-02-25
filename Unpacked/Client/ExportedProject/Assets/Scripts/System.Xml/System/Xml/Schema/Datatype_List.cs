namespace System.Xml.Schema;

[Token(Token = "0x20000EA")]
internal class Datatype_List : Datatype_anySimpleType
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000521")]
	private DatatypeImplementation itemType; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000522")]
	private int minListSize; //Field offset: 0x40

	[Token(Token = "0x1700021E")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A1A20", Offset = "0x16A0C20", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600090A")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700021D")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A1A70", Offset = "0x16A0C70", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000909")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x1700021C")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x16A1AA0", Offset = "0x16A0CA0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000908")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700021F")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x16A1AD0", Offset = "0x16A0CD0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600090B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700021B")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x15A4FA0", Offset = "0x15A41A0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000907")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x16A1970", Offset = "0x16A0B70", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000905")]
	internal Datatype_List(DatatypeImplementation type, int minListSize) { }

	[Address(RVA = "0x16A0DF0", Offset = "0x169FFF0", Length = "0x2C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000906")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A10C0", Offset = "0x16A02C0", Length = "0x3B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(XmlListConverter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValueConverter)}, ReturnType = typeof(XmlValueConverter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000904")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x16A1A20", Offset = "0x16A0C20", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600090A")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A1A70", Offset = "0x16A0C70", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000909")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x16A1AA0", Offset = "0x16A0CA0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000908")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x16A1AD0", Offset = "0x16A0CD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600090B")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x15A4FA0", Offset = "0x15A41A0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000907")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A1480", Offset = "0x16A0680", Length = "0x4EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "SplitString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x600090C")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

