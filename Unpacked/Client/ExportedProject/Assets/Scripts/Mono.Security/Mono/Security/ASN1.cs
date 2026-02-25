namespace Mono.Security;

[DefaultMember("Item")]
[Token(Token = "0x2000003")]
public class ASN1
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	private byte m_nTag; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	private Byte[] m_aValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000003")]
	private ArrayList elist; //Field offset: 0x20

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Address(RVA = "0x12A8880", Offset = "0x12A7A80", Length = "0x22")]
		[CallerCount(Count = 13)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000005")]
	public ASN1 Item
	{
		[Address(RVA = "0x12A88B0", Offset = "0x12A7AB0", Length = "0xC3")]
		[CallerCount(Count = 228)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000011")]
		 get { } //Length: 195
	}

	[Token(Token = "0x17000003")]
	public int Length
	{
		[Address(RVA = "0x12A8980", Offset = "0x12A7B80", Length = "0x12")]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000008")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000002")]
	public byte Tag
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000004")]
	public Byte[] Value
	{
		[Address(RVA = "0x12A89A0", Offset = "0x12A7BA0", Length = "0x94")]
		[CallerCount(Count = 92)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000009")]
		 get { } //Length: 148
		[Address(RVA = "0x12A8A40", Offset = "0x12A7C40", Length = "0xB0")]
		[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600000A")]
		 set { } //Length: 176
	}

	[Address(RVA = "0x12A8840", Offset = "0x12A7A40", Length = "0x37")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public ASN1(byte tag) { }

	[Address(RVA = "0x11E1BD0", Offset = "0x11E0DD0", Length = "0x41")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public ASN1(byte tag, Byte[] data) { }

	[Address(RVA = "0x12A86B0", Offset = "0x12A78B0", Length = "0x18B")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public ASN1(Byte[] data) { }

	[Address(RVA = "0x12A77E0", Offset = "0x12A69E0", Length = "0x9D")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public ASN1 Add(ASN1 asn1) { }

	[Address(RVA = "0x12A7880", Offset = "0x12A6A80", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000B")]
	private bool CompareArray(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x12A7900", Offset = "0x12A6B00", Length = "0x7C")]
	[CalledBy(Type = "Mono.X509PalImpl", Member = "GetCertContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509ContentType))]
	[CalledBy(Type = typeof(X501), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(ASN1), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000C")]
	public bool CompareValue(Byte[] value) { }

	[Address(RVA = "0x12A7AA0", Offset = "0x12A6CA0", Length = "0x1DD")]
	[CalledBy(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ASN1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(ASN1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	protected void Decode(Byte[] asn1, ref int anPos, int anLength) { }

	[Address(RVA = "0x12A7980", Offset = "0x12A6B80", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000010")]
	protected void DecodeTLV(Byte[] asn1, ref int pos, out byte tag, out int length, out Byte[] content) { }

	[Address(RVA = "0x12A7C80", Offset = "0x12A6E80", Length = "0xE1")]
	[CalledBy(Type = typeof(X509Certificate), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000012")]
	public ASN1 Element(int index, byte anTag) { }

	[Address(RVA = "0x12A8880", Offset = "0x12A7A80", Length = "0x22")]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public int get_Count() { }

	[Address(RVA = "0x12A88B0", Offset = "0x12A7AB0", Length = "0xC3")]
	[CallerCount(Count = 228)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000011")]
	public ASN1 get_Item(int index) { }

	[Address(RVA = "0x12A8980", Offset = "0x12A7B80", Length = "0x12")]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000008")]
	public int get_Length() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public byte get_Tag() { }

	[Address(RVA = "0x12A89A0", Offset = "0x12A7BA0", Length = "0x94")]
	[CallerCount(Count = 92)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	public Byte[] get_Value() { }

	[Address(RVA = "0x12A7D70", Offset = "0x12A6F70", Length = "0x628")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x600000E")]
	public override Byte[] GetBytes() { }

	[Address(RVA = "0x12A8A40", Offset = "0x12A7C40", Length = "0xB0")]
	[CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
	[CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(ASN1))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	public void set_Value(Byte[] value) { }

	[Address(RVA = "0x12A83A0", Offset = "0x12A75A0", Length = "0x30D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000013")]
	public virtual string ToString() { }

}

