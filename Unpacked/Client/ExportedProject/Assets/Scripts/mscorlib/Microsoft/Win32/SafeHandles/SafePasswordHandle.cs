namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000084")]
internal sealed class SafePasswordHandle : SafeHandle
{

	[Token(Token = "0x17000033")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x12FD160", Offset = "0x12FC360", Length = "0x22")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000247")]
		 get { } //Length: 34
	}

	[Address(RVA = "0x12FD0F0", Offset = "0x12FC2F0", Length = "0x6C")]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "Mono.X509PalImpl", Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Impl")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = "Mono.Btls.X509CertificateImplBtls")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Impl")]
	[CalledBy(Type = "Mono.Btls.X509CertificateImplBtls", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(SafePasswordHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6000244")]
	public SafePasswordHandle(string password) { }

	[Address(RVA = "0x12FCF20", Offset = "0x12FC120", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6000242")]
	private IntPtr CreateHandle(string password) { }

	[Address(RVA = "0x12FCF70", Offset = "0x12FC170", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandleCache`1), Member = "IsCachedInvalidHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SafeHandle), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000246")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x12FCFD0", Offset = "0x12FC1D0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000243")]
	private void FreeHandle() { }

	[Address(RVA = "0x12FD160", Offset = "0x12FC360", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000247")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x12FD020", Offset = "0x12FC220", Length = "0x4D")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(SafePasswordHandle), typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(SafePasswordHandle)}, ReturnType = "Mono.Security.X509.X509Certificate")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), typeof(SafePasswordHandle)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "ExportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafePasswordHandle)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000248")]
	internal string Mono_DangerousGetString() { }

	[Address(RVA = "0x12FD070", Offset = "0x12FC270", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000245")]
	protected virtual bool ReleaseHandle() { }

}

