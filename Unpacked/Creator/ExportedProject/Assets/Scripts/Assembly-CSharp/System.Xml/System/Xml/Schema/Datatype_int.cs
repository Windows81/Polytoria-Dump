namespace System.Xml.Schema;

[Token(Token = "0x2000118")]
internal class Datatype_int : Datatype_long
{
	[Token(Token = "0x4000545")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000546")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000547")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x1700028A")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A7130", Offset = "0x16A6330", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009E0")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700028D")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A7180", Offset = "0x16A6380", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009E4")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700028B")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE160", Offset = "0x3CD360", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700028C")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A71D0", Offset = "0x16A63D0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009E3")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A6F40", Offset = "0x16A6140", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009E7")]
	private static Datatype_int() { }

	[Address(RVA = "0x16A70B0", Offset = "0x16A62B0", Length = "0x7A")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_short), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_byte), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60009E6")]
	public Datatype_int() { }

	[Address(RVA = "0x16A6D70", Offset = "0x16A5F70", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60009E2")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A7130", Offset = "0x16A6330", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009E0")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A7180", Offset = "0x16A6380", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009E4")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x3CE160", Offset = "0x3CD360", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E1")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A71D0", Offset = "0x16A63D0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009E3")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A6DD0", Offset = "0x16A5FD0", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009E5")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

