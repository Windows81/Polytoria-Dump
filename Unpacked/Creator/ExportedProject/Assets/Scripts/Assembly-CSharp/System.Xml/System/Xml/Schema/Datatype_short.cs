namespace System.Xml.Schema;

[Token(Token = "0x2000119")]
internal class Datatype_short : Datatype_int
{
	[Token(Token = "0x4000548")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000549")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x400054A")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x1700028E")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A8280", Offset = "0x16A7480", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009E8")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000291")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A82D0", Offset = "0x16A74D0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009EC")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700028F")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE180", Offset = "0x3CD380", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E9")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000290")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A8320", Offset = "0x16A7520", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009EB")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A80C0", Offset = "0x16A72C0", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009EF")]
	private static Datatype_short() { }

	[Address(RVA = "0x16A8230", Offset = "0x16A7430", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60009EE")]
	public Datatype_short() { }

	[Address(RVA = "0x16A7EF0", Offset = "0x16A70F0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(short), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60009EA")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A8280", Offset = "0x16A7480", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009E8")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A82D0", Offset = "0x16A74D0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009EC")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x3CE180", Offset = "0x3CD380", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E9")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A8320", Offset = "0x16A7520", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009EB")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A7F50", Offset = "0x16A7150", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int16&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009ED")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

