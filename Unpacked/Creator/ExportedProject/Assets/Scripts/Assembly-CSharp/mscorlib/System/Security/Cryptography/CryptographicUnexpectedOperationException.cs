namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002E4")]
public class CryptographicUnexpectedOperationException : CryptographicException
{

	[Address(RVA = "0x1322650", Offset = "0x1321850", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60017A9")]
	public CryptographicUnexpectedOperationException() { }

	[Address(RVA = "0x13226C0", Offset = "0x13218C0", Length = "0x36")]
	[CalledBy(Type = typeof(HashAlgorithm), Member = "get_Hash", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DSASignatureDeformatter), Member = "SetHashAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSASignatureDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(RSAPKCS1SignatureDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60017AA")]
	public CryptographicUnexpectedOperationException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017AB")]
	protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context) { }

}

