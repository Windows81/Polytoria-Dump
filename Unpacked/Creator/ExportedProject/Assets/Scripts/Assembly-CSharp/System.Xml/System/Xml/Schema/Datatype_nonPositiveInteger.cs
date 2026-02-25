namespace System.Xml.Schema;

[Token(Token = "0x2000115")]
internal class Datatype_nonPositiveInteger : Datatype_integer
{
	[Token(Token = "0x4000540")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	[Token(Token = "0x17000282")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A7CD0", Offset = "0x16A6ED0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009D0")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000283")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE190", Offset = "0x3CD390", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D1")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A7BD0", Offset = "0x16A6DD0", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009D3")]
	private static Datatype_nonPositiveInteger() { }

	[Address(RVA = "0x16A7380", Offset = "0x16A6580", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D2")]
	public Datatype_nonPositiveInteger() { }

	[Address(RVA = "0x16A7CD0", Offset = "0x16A6ED0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009D0")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x3CE190", Offset = "0x3CD390", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009D1")]
	public virtual XmlTypeCode get_TypeCode() { }

}

