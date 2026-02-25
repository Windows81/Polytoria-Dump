namespace System.Xml.Schema;

[Token(Token = "0x200011F")]
internal class Datatype_unsignedByte : Datatype_unsignedShort
{
	[Token(Token = "0x4000558")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000559")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x400055A")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x170002A4")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A8B70", Offset = "0x16A7D70", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A14")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170002A7")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A8BC0", Offset = "0x16A7DC0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A18")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170002A5")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x15959F0", Offset = "0x1594BF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A15")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170002A6")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A8C10", Offset = "0x16A7E10", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A17")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A89A0", Offset = "0x16A7BA0", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A1B")]
	private static Datatype_unsignedByte() { }

	[Address(RVA = "0x16A8B20", Offset = "0x16A7D20", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_unsignedShort), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000A1A")]
	public Datatype_unsignedByte() { }

	[Address(RVA = "0x16A87D0", Offset = "0x16A79D0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(byte), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000A16")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A8B70", Offset = "0x16A7D70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A14")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A8BC0", Offset = "0x16A7DC0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A18")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x15959F0", Offset = "0x1594BF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A15")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A8C10", Offset = "0x16A7E10", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A17")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A8830", Offset = "0x16A7A30", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A19")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

