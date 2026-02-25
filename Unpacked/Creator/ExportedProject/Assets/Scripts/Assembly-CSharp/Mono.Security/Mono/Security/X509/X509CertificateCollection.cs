namespace Mono.Security.X509;

[DefaultMember("Item")]
[Token(Token = "0x2000012")]
public class X509CertificateCollection : CollectionBase, IEnumerable
{
	[Token(Token = "0x2000013")]
	internal class X509CertificateEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000061")]
		private IEnumerator enumerator; //Field offset: 0x10

		[Token(Token = "0x1700003B")]
		public X509Certificate Current
		{
			[Address(RVA = "0x12BAA00", Offset = "0x12B9C00", Length = "0x95")]
			[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
			[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(DSAParameters))]
			[CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
			[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
			[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x60000B6")]
			 get { } //Length: 149
		}

		[Token(Token = "0x1700003C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x12BA940", Offset = "0x12B9B40", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x60000B7")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x12BA990", Offset = "0x12B9B90", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000B5")]
		public X509CertificateEnumerator(X509CertificateCollection mappings) { }

		[Address(RVA = "0x12BAA00", Offset = "0x12B9C00", Length = "0x95")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(DSAParameters))]
		[CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60000B6")]
		public X509Certificate get_Current() { }

		[Address(RVA = "0x12BA850", Offset = "0x12B9A50", Length = "0x46")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000BA")]
		public bool MoveNext() { }

		[Address(RVA = "0x12BA940", Offset = "0x12B9B40", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000B7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x12BA8A0", Offset = "0x12B9AA0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000B8")]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[Address(RVA = "0x12BA8F0", Offset = "0x12B9AF0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000B9")]
		private override void System.Collections.IEnumerator.Reset() { }

	}


	[Token(Token = "0x1700003A")]
	public X509Certificate Item
	{
		[Address(RVA = "0x12BA7B0", Offset = "0x12B99B0", Length = "0x98")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000AC")]
		 get { } //Length: 152
	}

	[Address(RVA = "0x12BA7A0", Offset = "0x12B99A0", Length = "0x7")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AB")]
	public X509CertificateCollection() { }

	[Address(RVA = "0x12BA3E0", Offset = "0x12B95E0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AD")]
	public int Add(X509Certificate value) { }

	[Address(RVA = "0x12BA280", Offset = "0x12B9480", Length = "0x15E")]
	[CalledBy(Type = typeof(X509Chain), Member = "get_TrustAnchors", ReturnType = typeof(X509CertificateCollection))]
	[CalledBy(Type = typeof(X509Chain), Member = "LoadCertificates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509StoreManager), Member = "get_TrustedRootCertificates", ReturnType = typeof(X509CertificateCollection))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000AE")]
	public void AddRange(X509CertificateCollection value) { }

	[Address(RVA = "0x12BA470", Offset = "0x12B9670", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B4")]
	private bool Compare(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x12BA4E0", Offset = "0x12B96E0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000AF")]
	public bool Contains(X509Certificate value) { }

	[Address(RVA = "0x12BA7B0", Offset = "0x12B99B0", Length = "0x98")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AC")]
	public X509Certificate get_Item(int index) { }

	[Address(RVA = "0x12BA500", Offset = "0x12B9700", Length = "0x97")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignedData), typeof(Byte[]), typeof(HashAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignerInfo), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000B0")]
	public X509CertificateEnumerator GetEnumerator() { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x12BA5A0", Offset = "0x12B97A0", Length = "0x1CB")]
	[CalledBy(Type = typeof(X509CertificateCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(X509Chain), Member = "IsTrusted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(X509Certificate), Member = "get_Hash", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000B3")]
	public int IndexOf(X509Certificate value) { }

	[Address(RVA = "0x12BA770", Offset = "0x12B9970", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B1")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

