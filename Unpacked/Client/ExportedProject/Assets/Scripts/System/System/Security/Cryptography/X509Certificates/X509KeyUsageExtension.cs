namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013E")]
public sealed class X509KeyUsageExtension : X509Extension
{
	[Token(Token = "0x40005B8")]
	internal const string oid = "2.5.29.15"; //Field offset: 0x0
	[Token(Token = "0x40005B9")]
	internal const string friendlyName = "Key Usage"; //Field offset: 0x0
	[Token(Token = "0x40005BA")]
	internal const X509KeyUsageFlags all = 33023; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005BB")]
	private X509KeyUsageFlags _keyUsages; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40005BC")]
	private AsnDecodeStatus _status; //Field offset: 0x2C

	[Token(Token = "0x17000171")]
	public X509KeyUsageFlags KeyUsages
	{
		[Address(RVA = "0x17926C0", Offset = "0x17918C0", Length = "0x6A")]
		[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidForDigitalSignatureUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509KeyUsageExtension)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60007DA")]
		 get { } //Length: 106
	}

	[Address(RVA = "0x1792600", Offset = "0x1791800", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007D7")]
	public X509KeyUsageExtension() { }

	[Address(RVA = "0x17923F0", Offset = "0x17915F0", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509KeyUsageExtension), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(AsnDecodeStatus))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007D8")]
	public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical) { }

	[Address(RVA = "0x1792500", Offset = "0x1791700", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509KeyUsageExtension), Member = "Encode", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60007D9")]
	public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical) { }

	[Address(RVA = "0x17919E0", Offset = "0x1790BE0", Length = "0x22E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509KeyUsageExtension), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(AsnDecodeStatus))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60007DB")]
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x1791C10", Offset = "0x1790E10", Length = "0x15C")]
	[CalledBy(Type = typeof(AsnEncodedData), Member = "KeyUsageExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsnEncodedData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509KeyUsageExtension), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsnEncodedData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007DD")]
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	[Address(RVA = "0x1791D70", Offset = "0x1790F70", Length = "0x16C")]
	[CalledBy(Type = typeof(X509KeyUsageExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509KeyUsageFlags), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DE")]
	internal Byte[] Encode() { }

	[Address(RVA = "0x17926C0", Offset = "0x17918C0", Length = "0x6A")]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidForDigitalSignatureUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509KeyUsageExtension)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007DA")]
	public X509KeyUsageFlags get_KeyUsages() { }

	[Address(RVA = "0x1791EE0", Offset = "0x17910E0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007DC")]
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	[Address(RVA = "0x1791EF0", Offset = "0x17910F0", Length = "0x4FD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Extension), Member = "FormatUnkownData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DF")]
	internal virtual string ToString(bool multiLine) { }

}

