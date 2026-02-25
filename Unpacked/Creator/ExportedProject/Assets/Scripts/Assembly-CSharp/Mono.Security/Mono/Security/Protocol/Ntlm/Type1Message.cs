namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000035")]
public class Type1Message : MessageBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A4")]
	private string _host; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A5")]
	private string _domain; //Field offset: 0x20

	[Token(Token = "0x17000056")]
	public string Domain
	{
		[Address(RVA = "0x12D3DD0", Offset = "0x12D2FD0", Length = "0x79")]
		[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600012B")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000057")]
	public string Host
	{
		[Address(RVA = "0x12D3E50", Offset = "0x12D3050", Length = "0x79")]
		[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600012C")]
		 set { } //Length: 121
	}

	[Address(RVA = "0x12D3D40", Offset = "0x12D2F40", Length = "0x86")]
	[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600012A")]
	public Type1Message() { }

	[Address(RVA = "0x12D3950", Offset = "0x12D2B50", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageBase), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600012D")]
	protected virtual void Decode(Byte[] message) { }

	[Address(RVA = "0x12D3A70", Offset = "0x12D2C70", Length = "0x2C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MessageBase), Member = "PrepareMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600012E")]
	public virtual Byte[] GetBytes() { }

	[Address(RVA = "0x12D3DD0", Offset = "0x12D2FD0", Length = "0x79")]
	[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600012B")]
	public void set_Domain(string value) { }

	[Address(RVA = "0x12D3E50", Offset = "0x12D3050", Length = "0x79")]
	[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600012C")]
	public void set_Host(string value) { }

}

