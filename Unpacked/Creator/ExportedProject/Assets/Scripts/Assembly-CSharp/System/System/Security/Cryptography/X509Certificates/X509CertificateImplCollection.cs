namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
[Token(Token = "0x2000130")]
internal class X509CertificateImplCollection : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400058F")]
	private List<X509CertificateImpl> list; //Field offset: 0x10

	[Token(Token = "0x17000149")]
	public int Count
	{
		[Address(RVA = "0x1789A70", Offset = "0x1788C70", Length = "0x3C")]
		[CalledBy(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509Certificate), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Verify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600074C")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700014A")]
	public X509CertificateImpl Item
	{
		[Address(RVA = "0x1789AB0", Offset = "0x1788CB0", Length = "0x51")]
		[CalledBy(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509Certificate), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Verify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600074D")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x17897E0", Offset = "0x17889E0", Length = "0x77")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600074A")]
	public X509CertificateImplCollection() { }

	[Address(RVA = "0x1789860", Offset = "0x1788A60", Length = "0x20C")]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2ImplMono)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "Clone", ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CalledBy(Type = typeof(X509CertificateImplCollection), Member = "Clone", ReturnType = typeof(X509CertificateImplCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600074B")]
	private X509CertificateImplCollection(X509CertificateImplCollection other) { }

	[Address(RVA = "0x17894D0", Offset = "0x17886D0", Length = "0xE3")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600074E")]
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	[Address(RVA = "0x17895C0", Offset = "0x17887C0", Length = "0x54")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Clone", ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplCollection)}, ReturnType = typeof(void))]
	[Token(Token = "0x600074F")]
	public X509CertificateImplCollection Clone() { }

	[Address(RVA = "0x1789770", Offset = "0x1788970", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000750")]
	public override void Dispose() { }

	[Address(RVA = "0x1789620", Offset = "0x1788820", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000751")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x12D1B30", Offset = "0x12D0D30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000752")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1789A70", Offset = "0x1788C70", Length = "0x3C")]
	[CalledBy(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509Certificate), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Verify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600074C")]
	public int get_Count() { }

	[Address(RVA = "0x1789AB0", Offset = "0x1788CB0", Length = "0x51")]
	[CalledBy(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509Certificate), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = "Verify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600074D")]
	public X509CertificateImpl get_Item(int index) { }

}

