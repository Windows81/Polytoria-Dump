namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000140")]
public sealed class X509SubjectKeyIdentifierExtension : X509Extension
{
	[Token(Token = "0x40005C2")]
	internal const string oid = "2.5.29.14"; //Field offset: 0x0
	[Token(Token = "0x40005C3")]
	internal const string friendlyName = "Subject Key Identifier"; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005C4")]
	private Byte[] _subjectKeyIdentifier; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005C5")]
	private string _ski; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005C6")]
	private AsnDecodeStatus _status; //Field offset: 0x38

	[Token(Token = "0x17000175")]
	public string SubjectKeyIdentifier
	{
		[Address(RVA = "0x1794100", Offset = "0x1793300", Length = "0x89")]
		[CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CryptoConvert), Member = "ToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60007ED")]
		 get { } //Length: 137
	}

	[Address(RVA = "0x1794040", Offset = "0x1793240", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007E7")]
	public X509SubjectKeyIdentifierExtension() { }

	[Address(RVA = "0x1793A20", Offset = "0x1792C20", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(AsnDecodeStatus))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007E8")]
	public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	[Address(RVA = "0x1793B30", Offset = "0x1792D30", Length = "0x210")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Encode", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60007E9")]
	public X509SubjectKeyIdentifierExtension(Byte[] subjectKeyIdentifier, bool critical) { }

	[Address(RVA = "0x1793D50", Offset = "0x1792F50", Length = "0x2E5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Encode", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007EA")]
	public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical) { }

	[Address(RVA = "0x1793A00", Offset = "0x1792C00", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PublicKey), typeof(X509SubjectKeyIdentifierHashAlgorithm), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007EB")]
	public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical) { }

	[Address(RVA = "0x17935B0", Offset = "0x17927B0", Length = "0x440")]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PublicKey), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Encode", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007EC")]
	public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	[Address(RVA = "0x1792D30", Offset = "0x1791F30", Length = "0x22E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(AsnDecodeStatus))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60007EE")]
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x1792F60", Offset = "0x1792160", Length = "0x13A")]
	[CalledBy(Type = typeof(AsnEncodedData), Member = "SubjectKeyIdentifierExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsnEncodedData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsnEncodedData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F2")]
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	[Address(RVA = "0x17930A0", Offset = "0x17922A0", Length = "0x77")]
	[CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PublicKey), typeof(X509SubjectKeyIdentifierHashAlgorithm), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007F3")]
	internal Byte[] Encode() { }

	[Address(RVA = "0x17931D0", Offset = "0x17923D0", Length = "0x185")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F1")]
	internal static Byte[] FromHex(string hex) { }

	[Address(RVA = "0x1793120", Offset = "0x1792320", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007EF")]
	internal static byte FromHexChar(char c) { }

	[Address(RVA = "0x1793150", Offset = "0x1792350", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007F0")]
	internal static byte FromHexChars(char c1, char c2) { }

	[Address(RVA = "0x1794100", Offset = "0x1793300", Length = "0x89")]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CryptoConvert), Member = "ToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007ED")]
	public string get_SubjectKeyIdentifier() { }

	[Address(RVA = "0x1793360", Offset = "0x1792560", Length = "0x246")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Extension), Member = "FormatUnkownData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007F4")]
	internal virtual string ToString(bool multiLine) { }

}

