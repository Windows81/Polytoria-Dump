namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000132")]
public class X509ChainElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000591")]
	private X509Certificate2 certificate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000592")]
	private X509ChainStatus[] status; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000593")]
	private string info; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000594")]
	private X509ChainStatusFlags compressed_status_flags; //Field offset: 0x28

	[Token(Token = "0x1700014E")]
	public X509Certificate2 Certificate
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000761")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014F")]
	public X509ChainStatus[] ChainElementStatus
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000762")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000150")]
	internal X509ChainStatusFlags StatusFlags
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000763")]
		internal get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000764")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x178B0A0", Offset = "0x178A2A0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000760")]
	internal X509ChainElement(X509Certificate2 certificate) { }

	[Address(RVA = "0x178A150", Offset = "0x1789350", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000765")]
	private int Count(X509ChainStatusFlags flags) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000761")]
	public X509Certificate2 get_Certificate() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000762")]
	public X509ChainStatus[] get_ChainElementStatus() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000763")]
	internal X509ChainStatusFlags get_StatusFlags() { }

	[Address(RVA = "0x178A180", Offset = "0x1789380", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000766")]
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000764")]
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	[Address(RVA = "0x178A200", Offset = "0x1789400", Length = "0xE96")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "WrapUp", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Token(Token = "0x6000767")]
	internal void UncompressFlags() { }

}

