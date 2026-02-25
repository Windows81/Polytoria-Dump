namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000138")]
public struct X509ChainStatus
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005B0")]
	private X509ChainStatusFlags status; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005B1")]
	private string info; //Field offset: 0x8

	[Token(Token = "0x17000168")]
	public X509ChainStatusFlags Status
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B2")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B3")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000169")]
	public string StatusInformation
	{
		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B4")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x178F630", Offset = "0x178E830", Length = "0x2B")]
	[CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "AddStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "AddStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60007B1")]
	internal X509ChainStatus(X509ChainStatusFlags flag) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B2")]
	public X509ChainStatusFlags get_Status() { }

	[Address(RVA = "0x178F4B0", Offset = "0x178E6B0", Length = "0x150")]
	[CalledBy(Type = typeof(X509ChainElement), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatus[]), typeof(Int32&), typeof(X509ChainStatusFlags), typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainElement), Member = "UncompressFlags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509ChainStatus), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007B5")]
	internal static string GetInformation(X509ChainStatusFlags flags) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B3")]
	public void set_Status(X509ChainStatusFlags value) { }

	[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B4")]
	public void set_StatusInformation(string value) { }

}

