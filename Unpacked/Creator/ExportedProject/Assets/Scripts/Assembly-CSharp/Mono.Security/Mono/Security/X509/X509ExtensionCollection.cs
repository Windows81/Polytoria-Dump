namespace Mono.Security.X509;

[DefaultMember("Item")]
[Token(Token = "0x2000017")]
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000072")]
	private bool readOnly; //Field offset: 0x18

	[Token(Token = "0x17000041")]
	public X509Extension Item
	{
		[Address(RVA = "0x12BF280", Offset = "0x12BE480", Length = "0x1FD")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Crl)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 509
	}

	[Address(RVA = "0x12BA7A0", Offset = "0x12B99A0", Length = "0x7")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D0")]
	public X509ExtensionCollection() { }

	[Address(RVA = "0x12BF130", Offset = "0x12BE330", Length = "0x144")]
	[CalledBy(Type = typeof(X509CrlEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Crl), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000D1")]
	public X509ExtensionCollection(ASN1 asn1) { }

	[Address(RVA = "0x12BF280", Offset = "0x12BE480", Length = "0x1FD")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Crl)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000D4")]
	public X509Extension get_Item(string oid) { }

	[Address(RVA = "0x12BEFC0", Offset = "0x12BE1C0", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000D2")]
	public int IndexOf(string oid) { }

	[Address(RVA = "0x12BA770", Offset = "0x12B9970", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D3")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

