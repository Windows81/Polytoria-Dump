namespace System.Xml.Schema;

[Token(Token = "0x200011B")]
internal class Datatype_nonNegativeInteger : Datatype_integer
{
	[Token(Token = "0x400054E")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	[Token(Token = "0x17000296")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x16A7B80", Offset = "0x16A6D80", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009F8")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000297")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x3CE030", Offset = "0x3CD230", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009F9")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x16A7A80", Offset = "0x16A6C80", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009FB")]
	private static Datatype_nonNegativeInteger() { }

	[Address(RVA = "0x16A7380", Offset = "0x16A6580", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Datatype_decimal), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009FA")]
	public Datatype_nonNegativeInteger() { }

	[Address(RVA = "0x16A7B80", Offset = "0x16A6D80", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009F8")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x3CE030", Offset = "0x3CD230", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009F9")]
	public virtual XmlTypeCode get_TypeCode() { }

}

