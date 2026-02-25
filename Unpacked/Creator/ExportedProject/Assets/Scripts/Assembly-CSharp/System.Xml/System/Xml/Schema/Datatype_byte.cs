namespace System.Xml.Schema;

[Token(Token = "0x200011A")]
internal class Datatype_byte : Datatype_short
{
	[Token(Token = "0x400054B")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400054C")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x400054D")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x17000292")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A3DA0", Offset = "0x16A2FA0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009F0")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000295")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A3DF0", Offset = "0x16A2FF0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009F4")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000293")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE040", Offset = "0x3CD240", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000294")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A3E40", Offset = "0x16A3040", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009F3")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A3BB0", Offset = "0x16A2DB0", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009F7")]
	private static Datatype_byte() { }

	[Address(RVA = "0x16A3D20", Offset = "0x16A2F20", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_int), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60009F6")]
	public Datatype_byte() { }

	[Address(RVA = "0x16A39E0", Offset = "0x16A2BE0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(sbyte), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60009F2")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A3DA0", Offset = "0x16A2FA0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009F0")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A3DF0", Offset = "0x16A2FF0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009F4")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x3CE040", Offset = "0x3CD240", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F1")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A3E40", Offset = "0x16A3040", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009F3")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A3A40", Offset = "0x16A2C40", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SByte&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009F5")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

