namespace System.Net.Http;

[Token(Token = "0x2000014")]
public class HttpMethod : IEquatable<HttpMethod>
{
	[Token(Token = "0x4000056")]
	private static readonly HttpMethod delete_method; //Field offset: 0x0
	[Token(Token = "0x4000057")]
	private static readonly HttpMethod get_method; //Field offset: 0x8
	[Token(Token = "0x4000058")]
	private static readonly HttpMethod head_method; //Field offset: 0x10
	[Token(Token = "0x4000059")]
	private static readonly HttpMethod options_method; //Field offset: 0x18
	[Token(Token = "0x400005A")]
	private static readonly HttpMethod post_method; //Field offset: 0x20
	[Token(Token = "0x400005B")]
	private static readonly HttpMethod put_method; //Field offset: 0x28
	[Token(Token = "0x400005C")]
	private static readonly HttpMethod trace_method; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005D")]
	private readonly string method; //Field offset: 0x10

	[Token(Token = "0x1700000B")]
	public static HttpMethod Get
	{
		[Address(RVA = "0x1611790", Offset = "0x1610990", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600005C")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700000C")]
	public string Method
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1611450", Offset = "0x1610650", Length = "0x291")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HttpMethod), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000063")]
	private static HttpMethod() { }

	[Address(RVA = "0x16116F0", Offset = "0x16108F0", Length = "0x91")]
	[CalledBy(Type = typeof(HttpMethod), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Token), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005B")]
	public HttpMethod(string method) { }

	[Address(RVA = "0x1611390", Offset = "0x1610590", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005F")]
	public override bool Equals(HttpMethod other) { }

	[Address(RVA = "0x16113C0", Offset = "0x16105C0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000060")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1611790", Offset = "0x1610990", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600005C")]
	public static HttpMethod get_Get() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public string get_Method() { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000061")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x16117E0", Offset = "0x16109E0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005E")]
	public static bool op_Equality(HttpMethod left, HttpMethod right) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000062")]
	public virtual string ToString() { }

}

