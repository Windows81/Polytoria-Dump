namespace Mono.Security.Interface;

[Token(Token = "0x200003E")]
public class MonoTlsConnectionInfo
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E0")]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001E1")]
	private TlsProtocols <ProtocolVersion>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E2")]
	private string <PeerDomainName>k__BackingField; //Field offset: 0x18

	[CLSCompliant(False)]
	[Token(Token = "0x17000062")]
	public CipherSuiteCode CipherSuiteCode
	{
		[Address(RVA = "0xB080E0", Offset = "0xB072E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000147")]
		 get { } //Length: 5
		[Address(RVA = "0x12CD6E0", Offset = "0x12CC8E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000148")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000064")]
	public string PeerDomainName
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600014B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000063")]
	public TlsProtocols ProtocolVersion
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000149")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600014A")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014D")]
	public MonoTlsConnectionInfo() { }

	[Address(RVA = "0xB080E0", Offset = "0xB072E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000147")]
	public CipherSuiteCode get_CipherSuiteCode() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000149")]
	public TlsProtocols get_ProtocolVersion() { }

	[Address(RVA = "0x12CD6E0", Offset = "0x12CC8E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000148")]
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600014B")]
	public void set_PeerDomainName(string value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600014A")]
	public void set_ProtocolVersion(TlsProtocols value) { }

	[Address(RVA = "0x12CD640", Offset = "0x12CC840", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600014C")]
	public virtual string ToString() { }

}

