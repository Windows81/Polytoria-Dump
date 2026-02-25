namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200012A")]
public sealed class X509Certificate2Enumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000587")]
	private IEnumerator enumerator; //Field offset: 0x10

	[Token(Token = "0x17000128")]
	public X509Certificate2 Current
	{
		[Address(RVA = "0x1784C70", Offset = "0x1783E70", Length = "0x95")]
		[CalledBy(Type = typeof(X509ChainImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(X509Certificate2))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000703")]
		 get { } //Length: 149
	}

	[Token(Token = "0x17000129")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x1784BB0", Offset = "0x1783DB0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000705")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x1784C00", Offset = "0x1783E00", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000702")]
	internal X509Certificate2Enumerator(X509Certificate2Collection collection) { }

	[Address(RVA = "0x1784C70", Offset = "0x1783E70", Length = "0x95")]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000703")]
	public X509Certificate2 get_Current() { }

	[Address(RVA = "0x1784AC0", Offset = "0x1783CC0", Length = "0x46")]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000704")]
	public bool MoveNext() { }

	[Address(RVA = "0x1784BB0", Offset = "0x1783DB0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000705")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x1784B10", Offset = "0x1783D10", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000706")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x1784B60", Offset = "0x1783D60", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000707")]
	private override void System.Collections.IEnumerator.Reset() { }

}

