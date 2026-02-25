namespace System.Xml.Schema;

[Token(Token = "0x200011C")]
internal class Datatype_unsignedLong : Datatype_nonNegativeInteger
{
	[Token(Token = "0x400054F")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000550")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000551")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x17000298")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A9520", Offset = "0x16A8720", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009FC")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700029B")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A9570", Offset = "0x16A8770", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A00")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000299")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE050", Offset = "0x3CD250", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009FD")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700029A")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A95C0", Offset = "0x16A87C0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009FF")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A9320", Offset = "0x16A8520", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A03")]
	private static Datatype_unsignedLong() { }

	[Address(RVA = "0x16A94A0", Offset = "0x16A86A0", Length = "0x7A")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_unsignedInt), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_unsignedShort), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000A02")]
	public Datatype_unsignedLong() { }

	[Address(RVA = "0x16A9100", Offset = "0x16A8300", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ulong), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60009FE")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A9520", Offset = "0x16A8720", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009FC")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A9570", Offset = "0x16A8770", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A00")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x3CE050", Offset = "0x3CD250", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009FD")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A95C0", Offset = "0x16A87C0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009FF")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A9160", Offset = "0x16A8360", Length = "0x1BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A01")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

