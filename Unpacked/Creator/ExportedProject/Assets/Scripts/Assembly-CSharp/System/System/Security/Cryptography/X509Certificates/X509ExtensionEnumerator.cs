namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013C")]
public sealed class X509ExtensionEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B7")]
	private IEnumerator enumerator; //Field offset: 0x10

	[Token(Token = "0x1700016F")]
	public X509Extension Current
	{
		[Address(RVA = "0x1791360", Offset = "0x1790560", Length = "0x95")]
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60007CE")]
		 get { } //Length: 149
	}

	[Token(Token = "0x17000170")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x17912B0", Offset = "0x17904B0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007CF")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x1791300", Offset = "0x1790500", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007CD")]
	internal X509ExtensionEnumerator(ArrayList list) { }

	[Address(RVA = "0x1791360", Offset = "0x1790560", Length = "0x95")]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60007CE")]
	public X509Extension get_Current() { }

	[Address(RVA = "0x1791210", Offset = "0x1790410", Length = "0x46")]
	[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007D0")]
	public override bool MoveNext() { }

	[Address(RVA = "0x1791260", Offset = "0x1790460", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007D1")]
	public override void Reset() { }

	[Address(RVA = "0x17912B0", Offset = "0x17904B0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007CF")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

