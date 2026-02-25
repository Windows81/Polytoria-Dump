namespace Mono.Security;

[Token(Token = "0x2000006")]
public sealed class PKCS7
{
	[Token(Token = "0x2000007")]
	internal class ContentInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000004")]
		private string contentType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000005")]
		private ASN1 content; //Field offset: 0x18

		[Token(Token = "0x17000006")]
		public ASN1 ASN1
		{
			[Address(RVA = "0x12AC910", Offset = "0x12ABB10", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ContentInfo), Member = "GetASN1", ReturnType = typeof(ASN1))]
			[Token(Token = "0x6000027")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000007")]
		public ASN1 Content
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000028")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000029")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000008")]
		public string ContentType
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x600002A")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x600002B")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x12AC5D0", Offset = "0x12AB7D0", Length = "0x7D")]
		[CalledBy(Type = typeof(ContentInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EncryptedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(PKCS12), Member = "EncryptedContentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1), typeof(string)}, ReturnType = typeof(ContentInfo))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000023")]
		public ContentInfo() { }

		[Address(RVA = "0x12AC6C0", Offset = "0x12AB8C0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000024")]
		public ContentInfo(string oid) { }

		[Address(RVA = "0x12AC650", Offset = "0x12AB850", Length = "0x6B")]
		[CalledBy(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
		[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "RemoveCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6000025")]
		public ContentInfo(Byte[] data) { }

		[Address(RVA = "0x12AC700", Offset = "0x12AB900", Length = "0x204")]
		[CalledBy(Type = typeof(SignedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000026")]
		public ContentInfo(ASN1 asn1) { }

		[Address(RVA = "0x12AC910", Offset = "0x12ABB10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContentInfo), Member = "GetASN1", ReturnType = typeof(ASN1))]
		[Token(Token = "0x6000027")]
		public ASN1 get_ASN1() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000028")]
		public ASN1 get_Content() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002A")]
		public string get_ContentType() { }

		[Address(RVA = "0x12AC3E0", Offset = "0x12AB5E0", Length = "0x1ED")]
		[CalledBy(Type = typeof(ContentInfo), Member = "get_ASN1", ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600002C")]
		internal ASN1 GetASN1() { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000029")]
		public void set_Content(ASN1 value) { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600002B")]
		public void set_ContentType(string value) { }

	}

	[Token(Token = "0x2000008")]
	internal class EncryptedData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000006")]
		private byte _version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000007")]
		private ContentInfo _content; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000008")]
		private ContentInfo _encryptionAlgorithm; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000009")]
		private Byte[] _encrypted; //Field offset: 0x28

		[Token(Token = "0x1700000A")]
		public Byte[] EncryptedContent
		{
			[Address(RVA = "0x12AD8A0", Offset = "0x12ACAA0", Length = "0x7B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000030")]
			 get { } //Length: 123
		}

		[Token(Token = "0x17000009")]
		public ContentInfo EncryptionAlgorithm
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x600002F")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x12AD460", Offset = "0x12AC660", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600002D")]
		public EncryptedData() { }

		[Address(RVA = "0x12AD480", Offset = "0x12AC680", Length = "0x41E")]
		[CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002E")]
		public EncryptedData(ASN1 asn1) { }

		[Address(RVA = "0x12AD8A0", Offset = "0x12ACAA0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000030")]
		public Byte[] get_EncryptedContent() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		public ContentInfo get_EncryptionAlgorithm() { }

	}

	[Token(Token = "0x2000009")]
	internal class SignedData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000A")]
		private byte version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000B")]
		private string hashAlgorithm; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400000C")]
		private ContentInfo contentInfo; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400000D")]
		private X509CertificateCollection certs; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000E")]
		private ArrayList crls; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400000F")]
		private SignerInfo signerInfo; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000010")]
		private bool mda; //Field offset: 0x40

		[Token(Token = "0x1700000B")]
		public X509CertificateCollection Certificates
		{
			[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000032")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700000C")]
		public ContentInfo ContentInfo
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000033")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700000D")]
		public string HashName
		{
			[Address(RVA = "0x12B6DA0", Offset = "0x12B5FA0", Length = "0x45")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000034")]
			 set { } //Length: 69
		}

		[Token(Token = "0x1700000E")]
		public SignerInfo SignerInfo
		{
			[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000035")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x12B6500", Offset = "0x12B5700", Length = "0x89E")]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(SignerInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ContentInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000031")]
		public SignedData(ASN1 asn1) { }

		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		public X509CertificateCollection get_Certificates() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		public ContentInfo get_ContentInfo() { }

		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		public SignerInfo get_SignerInfo() { }

		[Address(RVA = "0x12B6370", Offset = "0x12B5570", Length = "0x181")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Token(Token = "0x6000036")]
		internal string OidToName(string oid) { }

		[Address(RVA = "0x12B6DA0", Offset = "0x12B5FA0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000034")]
		public void set_HashName(string value) { }

	}

	[Token(Token = "0x200000A")]
	internal class SignerInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000011")]
		private byte version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000012")]
		private string hashAlgorithm; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000013")]
		private ArrayList authenticatedAttributes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000014")]
		private ArrayList unauthenticatedAttributes; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000015")]
		private Byte[] signature; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000016")]
		private string issuer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000017")]
		private Byte[] serial; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000018")]
		private Byte[] ski; //Field offset: 0x48

		[Token(Token = "0x17000011")]
		public ArrayList AuthenticatedAttributes
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003B")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000012")]
		public string HashName
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003C")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x600003D")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700000F")]
		public string IssuerName
		{
			[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000039")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000010")]
		public Byte[] SerialNumber
		{
			[Address(RVA = "0x12B7330", Offset = "0x12B6530", Length = "0x7B")]
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600003A")]
			 get { } //Length: 123
		}

		[Token(Token = "0x17000013")]
		public Byte[] Signature
		{
			[Address(RVA = "0x12B73B0", Offset = "0x12B65B0", Length = "0x7B")]
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600003E")]
			 get { } //Length: 123
		}

		[Token(Token = "0x17000014")]
		public ArrayList UnauthenticatedAttributes
		{
			[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003F")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000015")]
		public byte Version
		{
			[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000040")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x12B6DF0", Offset = "0x12B5FF0", Length = "0x93")]
		[CalledBy(Type = typeof(SignerInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000037")]
		public SignerInfo() { }

		[Address(RVA = "0x12B6E90", Offset = "0x12B6090", Length = "0x49E")]
		[CalledBy(Type = typeof(SignedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(SignerInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000038")]
		public SignerInfo(ASN1 asn1) { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		public ArrayList get_AuthenticatedAttributes() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003C")]
		public string get_HashName() { }

		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		public string get_IssuerName() { }

		[Address(RVA = "0x12B7330", Offset = "0x12B6530", Length = "0x7B")]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600003A")]
		public Byte[] get_SerialNumber() { }

		[Address(RVA = "0x12B73B0", Offset = "0x12B65B0", Length = "0x7B")]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600003E")]
		public Byte[] get_Signature() { }

		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003F")]
		public ArrayList get_UnauthenticatedAttributes() { }

		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000040")]
		public byte get_Version() { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600003D")]
		public void set_HashName(string value) { }

	}


}

