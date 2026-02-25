namespace Mono.Btls;

[Token(Token = "0x2000077")]
internal class MonoBtlsException : Exception
{

	[Address(RVA = "0x15F6780", Offset = "0x15F5980", Length = "0x49")]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "Create_internal", ReturnType = typeof(BoringX509StoreHandle))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "Create_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslCtx)}, ReturnType = typeof(BoringSslHandle))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsSslCtx)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoringSslCtxHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "NativeVerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "Create_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(BoringX509LookupHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Store), typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "Create_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoringSslCtxHandle)}, ReturnType = typeof(BoringX509StoreHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoringSslCtxHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "Create_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(BoringX509StoreCtxHandle))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60001DB")]
	public MonoBtlsException() { }

	[Address(RVA = "0x15F6850", Offset = "0x15F5A50", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001DC")]
	public MonoBtlsException(MonoBtlsSslError error) { }

	[Address(RVA = "0x15F6720", Offset = "0x15F5920", Length = "0x59")]
	[CalledBy(Type = typeof(MonoBtlsKey), Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(MonoBtlsKey))]
	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "CopyIssuers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "CreateFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(MonoBtlsX509Name))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001DD")]
	public MonoBtlsException(string message) { }

	[Address(RVA = "0x15F67D0", Offset = "0x15F59D0", Length = "0x77")]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "ThrowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001DE")]
	public MonoBtlsException(string format, Object[] args) { }

}

