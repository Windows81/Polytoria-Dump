namespace System.Security.Cryptography;

[Token(Token = "0x2000110")]
internal class DerSequenceReader
{
	[CompilerGenerated]
	[Token(Token = "0x2000112")]
	private sealed class <>c
	{
		[Token(Token = "0x40004DA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004DB")]
		public static Func<Encoding> <>9__45_0; //Field offset: 0x8
		[Token(Token = "0x40004DC")]
		public static Func<Encoding> <>9__45_1; //Field offset: 0x10
		[Token(Token = "0x40004DD")]
		public static Func<DateTimeFormatInfo> <>9__51_0; //Field offset: 0x18

		[Address(RVA = "0x17818F0", Offset = "0x1780AF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000692")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000693")]
		public <>c() { }

		[Address(RVA = "0x1781790", Offset = "0x1780990", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000694")]
		internal Encoding <ReadT61String>b__45_0() { }

		[Address(RVA = "0x17817E0", Offset = "0x17809E0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
		[Token(Token = "0x6000695")]
		internal Encoding <ReadT61String>b__45_1() { }

		[Address(RVA = "0x1781820", Offset = "0x1780A20", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "Clone", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000696")]
		internal DateTimeFormatInfo <ReadTime>b__51_0() { }

	}

	[Token(Token = "0x2000111")]
	public enum DerTag
	{
		Boolean = 1,
		Integer = 2,
		BitString = 3,
		OctetString = 4,
		Null = 5,
		ObjectIdentifier = 6,
		UTF8String = 12,
		Sequence = 16,
		Set = 17,
		PrintableString = 19,
		T61String = 20,
		IA5String = 22,
		UTCTime = 23,
		GeneralizedTime = 24,
		BMPString = 30,
	}

	[Token(Token = "0x40004C3")]
	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; //Field offset: 0x0
	[Token(Token = "0x40004C4")]
	private static Encoding s_utf8EncodingWithExceptionFallback; //Field offset: 0x8
	[Token(Token = "0x40004C5")]
	private static Encoding s_latin1Encoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004C6")]
	private readonly Byte[] _data; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004C7")]
	private readonly int _end; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004C8")]
	private int _position; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C9")]
	private int <ContentLength>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000106")]
	private int ContentLength
	{
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000672")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000107")]
	internal bool HasData
	{
		[Address(RVA = "0x177E940", Offset = "0x177DB40", Length = "0xA")]
		[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000676")]
		internal get { } //Length: 10
	}

	[Address(RVA = "0x177E8D0", Offset = "0x177DAD0", Length = "0x30")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000673")]
	internal DerSequenceReader(Byte[] data) { }

	[Address(RVA = "0x177E910", Offset = "0x177DB10", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000674")]
	internal DerSequenceReader(Byte[] data, int offset, int length) { }

	[Address(RVA = "0x177E760", Offset = "0x177D960", Length = "0x16D")]
	[CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DerSequenceReader), Member = "CheckTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000675")]
	private DerSequenceReader(DerTag tagToEat, Byte[] data, int offset, int length) { }

	[Address(RVA = "0x177CD50", Offset = "0x177BF50", Length = "0x12D")]
	[CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600068F")]
	private static void CheckTag(DerTag expected, Byte[] data, int position) { }

	[Address(RVA = "0x177CE80", Offset = "0x177C080", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000690")]
	private int EatLength() { }

	[Address(RVA = "0x177CEC0", Offset = "0x177C0C0", Length = "0x7A")]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIntegerBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "CheckTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600068E")]
	private void EatTag(DerTag expected) { }

	[Address(RVA = "0x177E940", Offset = "0x177DB40", Length = "0xA")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000676")]
	internal bool get_HasData() { }

	[Address(RVA = "0x177CF40", Offset = "0x177C140", Length = "0xD3")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateData), Member = "FindAltNameMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(GeneralNameType), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000677")]
	internal byte PeekTag() { }

	[Address(RVA = "0x177D100", Offset = "0x177C300", Length = "0x186")]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067D")]
	internal Byte[] ReadBitString() { }

	[Address(RVA = "0x177D020", Offset = "0x177C220", Length = "0xD9")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600068A")]
	internal string ReadBMPString() { }

	[Address(RVA = "0x177D290", Offset = "0x177C490", Length = "0xC2")]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067A")]
	internal bool ReadBoolean() { }

	[Address(RVA = "0x177D360", Offset = "0x177C560", Length = "0xD8")]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadSequence", ReturnType = typeof(DerSequenceReader))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadSet", ReturnType = typeof(DerSequenceReader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "CheckTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000681")]
	private DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	[Address(RVA = "0x177D440", Offset = "0x177C640", Length = "0xA3")]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadInteger", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIntegerBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOctetString", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600068D")]
	private Byte[] ReadContentAsBytes() { }

	[Address(RVA = "0x177D4F0", Offset = "0x177C6F0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000689")]
	internal DateTime ReadGeneralizedTime() { }

	[Address(RVA = "0x177D530", Offset = "0x177C730", Length = "0xD9")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000685")]
	internal string ReadIA5String() { }

	[Address(RVA = "0x177D640", Offset = "0x177C840", Length = "0xA4")]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Token(Token = "0x600067B")]
	internal int ReadInteger() { }

	[Address(RVA = "0x177D610", Offset = "0x177C810", Length = "0x22")]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x600067C")]
	internal Byte[] ReadIntegerBytes() { }

	[Address(RVA = "0x177D6F0", Offset = "0x177C8F0", Length = "0xAE")]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000679")]
	internal Byte[] ReadNextEncodedValue() { }

	[Address(RVA = "0x177D7A0", Offset = "0x177C9A0", Length = "0x22")]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x600067E")]
	internal Byte[] ReadOctetString() { }

	[Address(RVA = "0x177D7D0", Offset = "0x177C9D0", Length = "0x34C")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(int)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067F")]
	internal string ReadOidAsString() { }

	[Address(RVA = "0x177DB20", Offset = "0x177CD20", Length = "0xD9")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000684")]
	internal string ReadPrintableString() { }

	[Address(RVA = "0x177DC00", Offset = "0x177CE00", Length = "0xA")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	[Token(Token = "0x6000682")]
	internal DerSequenceReader ReadSequence() { }

	[Address(RVA = "0x177DC10", Offset = "0x177CE10", Length = "0xA")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	[Token(Token = "0x6000683")]
	internal DerSequenceReader ReadSet() { }

	[Address(RVA = "0x177DC20", Offset = "0x177CE20", Length = "0x312")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000686")]
	internal string ReadT61String() { }

	[Address(RVA = "0x177DF40", Offset = "0x177D140", Length = "0x258")]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadX509Date", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtcTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadGeneralizedTime", ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600068C")]
	private DateTime ReadTime(DerTag timeTag, string formatString) { }

	[Address(RVA = "0x177E1A0", Offset = "0x177D3A0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000688")]
	internal DateTime ReadUtcTime() { }

	[Address(RVA = "0x177E1E0", Offset = "0x177D3E0", Length = "0xD9")]
	[CalledBy(Type = "Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000680")]
	internal string ReadUtf8String() { }

	[Address(RVA = "0x177E2C0", Offset = "0x177D4C0", Length = "0xCA")]
	[CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000687")]
	internal DateTime ReadX509Date() { }

	[Address(RVA = "0x177E390", Offset = "0x177D590", Length = "0x30A")]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadIA5String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "EatLength", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadContentAsBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBMPString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadT61String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadPrintableString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadCollectionWithTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(DerSequenceReader))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadOidAsString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBitString", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadBoolean", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadNextEncodedValue", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "SkipValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSequenceReader), Member = "ReadUtf8String", ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6000691")]
	private static int ScanContentLength(Byte[] data, int offset, int end, out int bytesConsumed) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000672")]
	private void set_ContentLength(int value) { }

	[Address(RVA = "0x177E6A0", Offset = "0x177D8A0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DerSequenceReader), Member = "PeekTag", ReturnType = typeof(byte))]
	[Calls(Type = typeof(DerSequenceReader), Member = "EatTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerTag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequenceReader), Member = "ScanContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000678")]
	internal void SkipValue() { }

	[Address(RVA = "0x177E6F0", Offset = "0x177D8F0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x600068B")]
	private static string TrimTrailingNulls(string value) { }

}

