namespace System.Security.Cryptography;

[Token(Token = "0x2000115")]
public sealed class OidEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004E2")]
	private readonly OidCollection _oids; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004E3")]
	private int _current; //Field offset: 0x18

	[Token(Token = "0x1700010D")]
	public Oid Current
	{
		[Address(RVA = "0x177F7E0", Offset = "0x177E9E0", Length = "0x58")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A9")]
		 get { } //Length: 88
	}

	[Token(Token = "0x1700010E")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x177F7E0", Offset = "0x177E9E0", Length = "0x58")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006AA")]
		private get { } //Length: 88
	}

	[Address(RVA = "0x140E2F0", Offset = "0x140D4F0", Length = "0x39")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A8")]
	internal OidEnumerator(OidCollection oids) { }

	[Address(RVA = "0x177F7E0", Offset = "0x177E9E0", Length = "0x58")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A9")]
	public Oid get_Current() { }

	[Address(RVA = "0x177F760", Offset = "0x177E960", Length = "0x78")]
	[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidForClientAuthenticationEKU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509EnhancedKeyUsageExtension)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006AB")]
	public override bool MoveNext() { }

	[Address(RVA = "0x14CF520", Offset = "0x14CE720", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AC")]
	public override void Reset() { }

	[Address(RVA = "0x177F7E0", Offset = "0x177E9E0", Length = "0x58")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AA")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

