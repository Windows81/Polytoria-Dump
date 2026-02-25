namespace System.Xml.Schema;

[Token(Token = "0x200011D")]
internal class Datatype_unsignedInt : Datatype_unsignedLong
{
	[Token(Token = "0x4000552")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000553")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000554")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x1700029C")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A9000", Offset = "0x16A8200", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A04")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700029F")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A9050", Offset = "0x16A8250", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A08")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700029D")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x16A90A0", Offset = "0x16A82A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000A05")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700029E")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A90B0", Offset = "0x16A82B0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A07")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A8E30", Offset = "0x16A8030", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A0B")]
	private static Datatype_unsignedInt() { }

	[Address(RVA = "0x16A8FB0", Offset = "0x16A81B0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000A0A")]
	public Datatype_unsignedInt() { }

	[Address(RVA = "0x16A8C60", Offset = "0x16A7E60", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(uint), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000A06")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A9000", Offset = "0x16A8200", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A04")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A9050", Offset = "0x16A8250", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A08")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x16A90A0", Offset = "0x16A82A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A05")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A90B0", Offset = "0x16A82B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A07")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A8CC0", Offset = "0x16A7EC0", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A09")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

