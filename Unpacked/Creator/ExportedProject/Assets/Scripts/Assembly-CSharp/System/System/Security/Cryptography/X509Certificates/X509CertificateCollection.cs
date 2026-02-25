namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
[Token(Token = "0x200012E")]
public class X509CertificateCollection : CollectionBase
{
	[Token(Token = "0x200012F")]
	internal class X509CertificateEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400058E")]
		private IEnumerator enumerator; //Field offset: 0x10

		[Token(Token = "0x17000147")]
		public X509Certificate Current
		{
			[Address(RVA = "0x1789430", Offset = "0x1788630", Length = "0x95")]
			[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x6000745")]
			 get { } //Length: 149
		}

		[Token(Token = "0x17000148")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1789370", Offset = "0x1788570", Length = "0x49")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000746")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x17893C0", Offset = "0x17885C0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000744")]
		public X509CertificateEnumerator(X509CertificateCollection mappings) { }

		[Address(RVA = "0x1789430", Offset = "0x1788630", Length = "0x95")]
		[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000745")]
		public X509Certificate get_Current() { }

		[Address(RVA = "0x1789280", Offset = "0x1788480", Length = "0x46")]
		[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000749")]
		public bool MoveNext() { }

		[Address(RVA = "0x1789370", Offset = "0x1788570", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000746")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x17892D0", Offset = "0x17884D0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000747")]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[Address(RVA = "0x1789320", Offset = "0x1788520", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000748")]
		private override void System.Collections.IEnumerator.Reset() { }

	}


	[Token(Token = "0x17000146")]
	public X509Certificate Item
	{
		[Address(RVA = "0x17891E0", Offset = "0x17883E0", Length = "0x98")]
		[CalledBy(Type = typeof(ChainValidationHelper), Member = "DefaultSelectionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X509CertificateCollection), typeof(X509Certificate), typeof(String[])}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600073F")]
		 get { } //Length: 152
	}

	[Address(RVA = "0x12BA7A0", Offset = "0x12B99A0", Length = "0x7")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600073D")]
	public X509CertificateCollection() { }

	[Address(RVA = "0x1789080", Offset = "0x1788280", Length = "0x15E")]
	[CalledBy(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600073E")]
	public X509CertificateCollection(X509CertificateCollection value) { }

	[Address(RVA = "0x1788F50", Offset = "0x1788150", Length = "0x81")]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectServerCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000740")]
	public int Add(X509Certificate value) { }

	[Address(RVA = "0x1788DF0", Offset = "0x1787FF0", Length = "0x15E")]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000741")]
	public void AddRange(X509CertificateCollection value) { }

	[Address(RVA = "0x17891E0", Offset = "0x17883E0", Length = "0x98")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "DefaultSelectionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(X509CertificateCollection), typeof(X509Certificate), typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600073F")]
	public X509Certificate get_Item(int index) { }

	[Address(RVA = "0x1788FE0", Offset = "0x17881E0", Length = "0x97")]
	[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000742")]
	public X509CertificateEnumerator GetEnumerator() { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000743")]
	public virtual int GetHashCode() { }

}

