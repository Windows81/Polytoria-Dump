namespace Mono.Btls;

[Token(Token = "0x20000A9")]
internal class X509ChainImplBtls : X509ChainImpl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F8")]
	private MonoBtlsX509StoreCtx storeCtx; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001F9")]
	private MonoBtlsX509Chain chain; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FA")]
	private MonoBtlsX509Chain untrustedChain; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001FB")]
	private X509ChainElementCollection elements; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001FC")]
	private X509Certificate2Collection untrusted; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001FD")]
	private X509Certificate2[] certificates; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001FE")]
	private X509ChainPolicy policy; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001FF")]
	private List<X509ChainStatus> chainStatusList; //Field offset: 0x48

	[Token(Token = "0x17000089")]
	public virtual X509ChainElementCollection ChainElements
	{
		[Address(RVA = "0x174CEC0", Offset = "0x174C0C0", Length = "0x2B1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Impl)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000338")]
		 get { } //Length: 689
	}

	[Token(Token = "0x1700008A")]
	public virtual X509ChainPolicy ChainPolicy
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000339")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000087")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x174D180", Offset = "0x174C380", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_IsValid", ReturnType = typeof(bool))]
		[Token(Token = "0x6000336")]
		 get { } //Length: 21
	}

	[Token(Token = "0x17000088")]
	internal MonoBtlsX509StoreCtx StoreCtx
	{
		[Address(RVA = "0x174D1A0", Offset = "0x174C3A0", Length = "0x1A")]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[Token(Token = "0x6000337")]
		internal get { } //Length: 26
	}

	[Address(RVA = "0x174CD20", Offset = "0x174BF20", Length = "0x19D")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetManagedChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain)}, ReturnType = typeof(X509Chain))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Handle", ReturnType = typeof(BoringX509ChainHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000334")]
	internal X509ChainImplBtls(MonoBtlsX509Chain chain) { }

	[Address(RVA = "0x174C780", Offset = "0x174B980", Length = "0x59C")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Impl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsX509StoreCtx), Member = "get_Handle", ReturnType = typeof(BoringX509StoreCtxHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000335")]
	internal X509ChainImplBtls(MonoBtlsX509StoreCtx storeCtx) { }

	[Address(RVA = "0x174C430", Offset = "0x174B630", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509ChainStatus), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600033A")]
	public virtual void AddStatus(X509ChainStatusFlags errorCode) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033B")]
	public virtual bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x174C570", Offset = "0x174B770", Length = "0x158")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "GetEnumerator", ReturnType = typeof(X509Certificate2Enumerator))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "get_Current", ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600033D")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x174CEC0", Offset = "0x174C0C0", Length = "0x2B1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Impl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000338")]
	public virtual X509ChainElementCollection get_ChainElements() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000339")]
	public virtual X509ChainPolicy get_ChainPolicy() { }

	[Address(RVA = "0x174D180", Offset = "0x174C380", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Token(Token = "0x6000336")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x174D1A0", Offset = "0x174C3A0", Length = "0x1A")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Token(Token = "0x6000337")]
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	[Address(RVA = "0x174C6D0", Offset = "0x174B8D0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600033C")]
	public virtual void Reset() { }

}

