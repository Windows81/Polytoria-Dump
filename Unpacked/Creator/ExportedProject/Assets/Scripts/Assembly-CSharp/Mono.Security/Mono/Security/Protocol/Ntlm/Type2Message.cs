namespace Mono.Security.Protocol.Ntlm;

[Token(Token = "0x2000036")]
public class Type2Message : MessageBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A6")]
	private Byte[] _nonce; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A7")]
	private string _targetName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A8")]
	private Byte[] _targetInfo; //Field offset: 0x28

	[Token(Token = "0x17000058")]
	public Byte[] Nonce
	{
		[Address(RVA = "0x12D4250", Offset = "0x12D3450", Length = "0x77")]
		[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000131")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700005A")]
	public Byte[] TargetInfo
	{
		[Address(RVA = "0x12D42D0", Offset = "0x12D34D0", Length = "0x77")]
		[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000133")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000059")]
	public string TargetName
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000132")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x12D41A0", Offset = "0x12D33A0", Length = "0xA3")]
	[CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012F")]
	public Type2Message(Byte[] message) { }

	[Address(RVA = "0x12D3ED0", Offset = "0x12D30D0", Length = "0x189")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MessageBase), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000134")]
	protected virtual void Decode(Byte[] message) { }

	[Address(RVA = "0x12D4060", Offset = "0x12D3260", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000130")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x12D4250", Offset = "0x12D3450", Length = "0x77")]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(NtlmAuthLevel), typeof(string), typeof(string), typeof(string), typeof(Byte[]&), typeof(Byte[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000131")]
	public Byte[] get_Nonce() { }

	[Address(RVA = "0x12D42D0", Offset = "0x12D34D0", Length = "0x77")]
	[CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type2Message), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000133")]
	public Byte[] get_TargetInfo() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000132")]
	public string get_TargetName() { }

	[Address(RVA = "0x12D40D0", Offset = "0x12D32D0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageBase), Member = "PrepareMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000135")]
	public virtual Byte[] GetBytes() { }

}

