namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013D")]
internal static class X509Helper2
{

	[Address(RVA = "0x17917A0", Offset = "0x17909A0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007D3")]
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	[Address(RVA = "0x1791800", Offset = "0x1790A00", Length = "0x6E")]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "Verify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = "get_Impl", ReturnType = typeof(X509ChainImpl))]
	[CalledBy(Type = typeof(X509Chain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainImpl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CalledBy(Type = typeof(X509Chain), Member = "get_ChainPolicy", ReturnType = typeof(X509ChainPolicy))]
	[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Helper2), Member = "ThrowIfContextInvalid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D6")]
	internal static Exception GetInvalidChainContextException() { }

	[Address(RVA = "0x1791870", Offset = "0x1790A70", Length = "0x11F")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "IsSignedWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "Internal.Cryptography.Helpers", Member = "CloneByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[MonoTODO("Investigate replacement; see comments in source.")]
	[Token(Token = "0x60007D2")]
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	[Address(RVA = "0x1357190", Offset = "0x1356390", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D4")]
	public static bool IsValid(X509ChainImpl impl) { }

	[Address(RVA = "0x1791990", Offset = "0x1790B90", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007D5")]
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

}

