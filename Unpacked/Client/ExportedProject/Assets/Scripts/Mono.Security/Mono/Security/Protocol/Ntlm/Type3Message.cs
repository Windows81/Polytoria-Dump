namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000037")]
public class Type3Message : MessageBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A9")]
	private NtlmAuthLevel _level; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AA")]
	private Byte[] _challenge; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000AB")]
	private string _host; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000AC")]
	private string _domain; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000AD")]
	private string _username; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000AE")]
	private string _password; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000AF")]
	private Type2Message _type2; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000B0")]
	private Byte[] _lm; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000B1")]
	private Byte[] _nt; //Field offset: 0x58

	[Token(Token = "0x1700005B")]
	public string Domain
	{
		[Address(RVA = "0x12D5230", Offset = "0x12D4430", Length = "0x79")]
		[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000138")]
		 set { } //Length: 121
	}

	[Token(Token = "0x1700005C")]
	public string Password
	{
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000139")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700005D")]
	public string Username
	{
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600013A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x12D4FA0", Offset = "0x12D41A0", Length = "0x289")]
	[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Environment), Member = "get_UserName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000136")]
	public Type3Message(Type2Message type2) { }

	[Address(RVA = "0x12D43C0", Offset = "0x12D35C0", Length = "0x2C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MessageBase), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600013B")]
	protected virtual void Decode(Byte[] message) { }

	[Address(RVA = "0x12D4350", Offset = "0x12D3550", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013C")]
	private string DecodeString(Byte[] buffer, int offset, int len) { }

	[Address(RVA = "0x12D4690", Offset = "0x12D3890", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013D")]
	private Byte[] EncodeString(string text) { }

	[Address(RVA = "0x12D4720", Offset = "0x12D3920", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000137")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x12D47E0", Offset = "0x12D39E0", Length = "0x7B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MessageBase), Member = "PrepareMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ChallengeResponse), Member = "get_NT", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ChallengeResponse), Member = "get_LM", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ChallengeResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600013E")]
	public virtual Byte[] GetBytes() { }

	[Address(RVA = "0x12D5230", Offset = "0x12D4430", Length = "0x79")]
	[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000138")]
	public void set_Domain(string value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000139")]
	public void set_Password(string value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600013A")]
	public void set_Username(string value) { }

}

