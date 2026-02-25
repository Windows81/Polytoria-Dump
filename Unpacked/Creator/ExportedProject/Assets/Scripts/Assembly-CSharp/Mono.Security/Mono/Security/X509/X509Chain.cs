namespace Mono.Security.X509;

[Token(Token = "0x2000014")]
public class X509Chain
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000062")]
	private X509CertificateCollection roots; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000063")]
	private X509CertificateCollection certs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000064")]
	private X509Certificate _root; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000065")]
	private X509CertificateCollection _chain; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000066")]
	private X509ChainStatusFlags _status; //Field offset: 0x30

	[Token(Token = "0x1700003D")]
	public X509CertificateCollection TrustAnchors
	{
		[Address(RVA = "0x12BDA50", Offset = "0x12BCC50", Length = "0x96")]
		[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(X509Chain), Member = "IsTrusted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
		[Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000BC")]
		 get { } //Length: 150
	}

	[Address(RVA = "0x12BD9E0", Offset = "0x12BCBE0", Length = "0x66")]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BB")]
	public X509Chain() { }

	[Address(RVA = "0x12BCE70", Offset = "0x12BC070", Length = "0x3DF")]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(X509Chain), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Certificate), Member = "get_IsSelfSigned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000BE")]
	public bool Build(X509Certificate leaf) { }

	[Address(RVA = "0x12BD250", Offset = "0x12BC450", Length = "0x1D5")]
	[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C1")]
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	[Address(RVA = "0x12BD430", Offset = "0x12BC630", Length = "0x1E9")]
	[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(X509Certificate), Member = "get_IsSelfSigned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60000C2")]
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	[Address(RVA = "0x12BDA50", Offset = "0x12BCC50", Length = "0x96")]
	[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(X509Chain), Member = "IsTrusted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BC")]
	public X509CertificateCollection get_TrustAnchors() { }

	[Address(RVA = "0x12BD620", Offset = "0x12BC820", Length = "0x17D")]
	[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Extension)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000C4")]
	private bool IsParent(X509Certificate child, X509Certificate parent) { }

	[Address(RVA = "0x12BD7A0", Offset = "0x12BC9A0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C3")]
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	[Address(RVA = "0x12BD7E0", Offset = "0x12BC9E0", Length = "0x187")]
	[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000C0")]
	private bool IsValid(X509Certificate cert) { }

	[Address(RVA = "0x12BD970", Offset = "0x12BCB70", Length = "0x1E")]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BD")]
	public void LoadCertificates(X509CertificateCollection collection) { }

	[Address(RVA = "0x12BD990", Offset = "0x12BCB90", Length = "0x4F")]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BF")]
	public void Reset() { }

}

