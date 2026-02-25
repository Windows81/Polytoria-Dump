namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200031E")]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D60")]
	private RSA rsa; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D61")]
	private string hashName; //Field offset: 0x18

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001912")]
	public RSAPKCS1SignatureDeformatter() { }

	[Address(RVA = "0x134DA20", Offset = "0x134CC20", Length = "0x3B")]
	[CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001913")]
	public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key) { }

	[Address(RVA = "0x134D6B0", Offset = "0x134C8B0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001914")]
	public virtual void SetHashAlgorithm(string strName) { }

	[Address(RVA = "0x134D720", Offset = "0x134C920", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001915")]
	public virtual void SetKey(AsymmetricAlgorithm key) { }

	[Address(RVA = "0x134D830", Offset = "0x134CA30", Length = "0x1E6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA), typeof(string), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001916")]
	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

