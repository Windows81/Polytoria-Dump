namespace System.Xml.Schema;

[Token(Token = "0x200011E")]
internal class Datatype_unsignedShort : Datatype_unsignedInt
{
	[Token(Token = "0x4000555")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000556")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000557")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x170002A0")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A99E0", Offset = "0x16A8BE0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A0C")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170002A3")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x16A9A30", Offset = "0x16A8C30", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A10")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170002A1")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x16A9A80", Offset = "0x16A8C80", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000A0D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170002A2")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x16A9A90", Offset = "0x16A8C90", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A0F")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x16A97E0", Offset = "0x16A89E0", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A13")]
	private static Datatype_unsignedShort() { }

	[Address(RVA = "0x16A9960", Offset = "0x16A8B60", Length = "0x7A")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datatype_unsignedByte), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_unsignedLong), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000A12")]
	public Datatype_unsignedShort() { }

	[Address(RVA = "0x16A9610", Offset = "0x16A8810", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ushort), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000A0E")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x16A99E0", Offset = "0x16A8BE0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A0C")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x16A9A30", Offset = "0x16A8C30", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A10")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x16A9A80", Offset = "0x16A8C80", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A0D")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x16A9A90", Offset = "0x16A8C90", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A0F")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x16A9670", Offset = "0x16A8870", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlConvert), Member = "TryToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt16&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A11")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

