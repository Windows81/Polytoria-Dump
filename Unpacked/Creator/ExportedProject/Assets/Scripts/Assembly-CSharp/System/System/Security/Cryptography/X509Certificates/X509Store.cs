namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013F")]
public sealed class X509Store : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005BD")]
	private string _name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005BE")]
	private StoreLocation _location; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005BF")]
	private X509Certificate2Collection list; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005C0")]
	private OpenFlags _flags; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005C1")]
	private X509Store store; //Field offset: 0x30

	[Token(Token = "0x17000172")]
	public X509Certificate2Collection Certificates
	{
		[Address(RVA = "0x1792C80", Offset = "0x1791E80", Length = "0x85")]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60007E1")]
		 get { } //Length: 133
	}

	[Token(Token = "0x17000173")]
	private X509Stores Factory
	{
		[Address(RVA = "0x1792D10", Offset = "0x1791F10", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
		[Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
		[Token(Token = "0x60007E2")]
		private get { } //Length: 20
	}

	[Token(Token = "0x17000174")]
	internal X509Store Store
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007E3")]
		internal get { } //Length: 95
	}

	[Address(RVA = "0x1792B20", Offset = "0x1791D20", Length = "0x159")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007E0")]
	public X509Store(StoreName storeName, StoreLocation storeLocation) { }

	[Address(RVA = "0x1792730", Offset = "0x1791930", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E4")]
	public void Close() { }

	[Address(RVA = "0x1792730", Offset = "0x1791930", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E5")]
	public override void Dispose() { }

	[Address(RVA = "0x1792C80", Offset = "0x1791E80", Length = "0x85")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_Roots", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateAuthorities", ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60007E1")]
	public X509Certificate2Collection get_Certificates() { }

	[Address(RVA = "0x1792D10", Offset = "0x1791F10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
	[Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
	[Token(Token = "0x60007E2")]
	private X509Stores get_Factory() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E3")]
	internal X509Store get_Store() { }

	[Address(RVA = "0x1792770", Offset = "0x1791970", Length = "0x3A9")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMRootStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserRootStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_LMCAStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_UserCAStore", ReturnType = typeof(X509Store))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateEnumerator))]
	[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Stores), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(X509Store))]
	[Calls(Type = typeof(X509StoreManager), Member = "get_CurrentUser", ReturnType = typeof(X509Stores))]
	[Calls(Type = typeof(X509StoreManager), Member = "get_LocalMachine", ReturnType = typeof(X509Stores))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60007E6")]
	public void Open(OpenFlags flags) { }

}

