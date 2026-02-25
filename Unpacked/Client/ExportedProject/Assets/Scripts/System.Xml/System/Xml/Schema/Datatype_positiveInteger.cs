namespace System.Xml.Schema;

[Token(Token = "0x2000120")]
internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
{
	[Token(Token = "0x400055B")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	[Token(Token = "0x170002A8")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A7EA0", Offset = "0x16A70A0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000A1C")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x170002A9")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x7C81C0", Offset = "0x7C73C0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A1D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A7D20", Offset = "0x16A6F20", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A1F")]
	private static Datatype_positiveInteger() { }

	[Address(RVA = "0x16A7E20", Offset = "0x16A7020", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000A1E")]
	public Datatype_positiveInteger() { }

	[Address(RVA = "0x16A7EA0", Offset = "0x16A70A0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A1C")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x7C81C0", Offset = "0x7C73C0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A1D")]
	public virtual XmlTypeCode get_TypeCode() { }

}

