namespace Internal.Cryptography.Pal;

[Token(Token = "0x20000B0")]
internal struct CertificateData
{
	[CompilerGenerated]
	[Token(Token = "0x20000B2")]
	private sealed class <ReadReverseRdns>d__21 : IEnumerable<KeyValuePair`2<String, String>>, IEnumerable, IEnumerator<KeyValuePair`2<String, String>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000225")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000226")]
		private KeyValuePair<String, String> <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000227")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000228")]
		private X500DistinguishedName name; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000229")]
		public X500DistinguishedName <>3__name; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400022A")]
		private Stack<DerSequenceReader> <rdnReaders>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400022B")]
		private DerSequenceReader <rdnReader>5__3; //Field offset: 0x48

		[Token(Token = "0x1700008C")]
		private override KeyValuePair<String, String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600035F")]
			private get { } //Length: 11
		}

		[Token(Token = "0x1700008D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x17469A0", Offset = "0x1745BA0", Length = "0x45")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[Token(Token = "0x6000361")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x5D7FB0", Offset = "0x5D71B0", Length = "0x2E")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600035C")]
		public <ReadReverseRdns>d__21(int <>1__state) { }

		[Address(RVA = "0x1746620", Offset = "0x1745820", Length = "0x299")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadSet", ReturnType = typeof(DerSequenceReader))]
		[Calls(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
		[Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600035E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x17468C0", Offset = "0x1745AC0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000362")]
		private override IEnumerator<KeyValuePair`2<String, String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600035F")]
		private override KeyValuePair<String, String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

		[Address(RVA = "0x17468C0", Offset = "0x1745AC0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000363")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x17469A0", Offset = "0x1745BA0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[Token(Token = "0x6000361")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1746960", Offset = "0x1745B60", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000360")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600035D")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20000B1")]
	public struct AlgorithmIdentifier
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000223")]
		internal string AlgorithmId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000224")]
		internal Byte[] Parameters; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000213")]
	internal Byte[] RawData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000214")]
	internal Byte[] SubjectPublicKeyInfo; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000215")]
	internal int Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000216")]
	internal Byte[] SerialNumber; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000217")]
	internal AlgorithmIdentifier TbsSignature; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000218")]
	internal X500DistinguishedName Issuer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000219")]
	internal DateTime NotBefore; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400021A")]
	internal DateTime NotAfter; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400021B")]
	internal X500DistinguishedName Subject; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400021C")]
	internal AlgorithmIdentifier PublicKeyAlgorithm; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400021D")]
	internal Byte[] PublicKey; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400021E")]
	internal Byte[] IssuerUniqueId; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400021F")]
	internal Byte[] SubjectUniqueId; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000220")]
	internal List<X509Extension> Extensions; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000221")]
	internal AlgorithmIdentifier SignatureAlgorithm; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000222")]
	internal Byte[] SignatureValue; //Field offset: 0x90

	[Address(RVA = "0x1733300", Offset = "0x1732500", Length = "0x912")]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(X509Extension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(X500DistinguishedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadIntegerBytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000357")]
	internal CertificateData(Byte[] rawData) { }

	[Address(RVA = "0x1732820", Offset = "0x1731A20", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "get_HasData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600035A")]
	private static string FindAltNameMatch(Byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	[Address(RVA = "0x17329D0", Offset = "0x1731BD0", Length = "0x1A0")]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CertificateData), Member = "GetSimpleNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName)}, ReturnType = typeof(string))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000358")]
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[Address(RVA = "0x1732F00", Offset = "0x1732100", Length = "0x370")]
	[CalledBy(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CertificateData), Member = "ReadReverseRdns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String, System.String>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000359")]
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	[Address(RVA = "0x1733280", Offset = "0x1732480", Length = "0x71")]
	[CalledBy(Type = typeof(CertificateData), Member = "GetSimpleNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X500DistinguishedName)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<ReadReverseRdns>d__21))]
	[Token(Token = "0x600035B")]
	private static IEnumerable<KeyValuePair`2<String, String>> ReadReverseRdns(X500DistinguishedName name) { }

}

