namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001B3")]
internal class BerBitStringParser : Asn1BitStringParser, IAsn1Convertible
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000448")]
	private readonly Asn1StreamParser m_parser; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000449")]
	private ConstructedBitStream m_bitStream; //Field offset: 0x18

	[Token(Token = "0x17000189")]
	public override int PadBits
	{
		[Address(RVA = "0x10EDEA0", Offset = "0x10ED0A0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001002")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001000")]
	internal BerBitStringParser(Asn1StreamParser parser) { }

	[Address(RVA = "0x10EDEA0", Offset = "0x10ED0A0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001002")]
	public override int get_PadBits() { }

	[Address(RVA = "0x10EDC60", Offset = "0x10ECE60", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseInputStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001001")]
	public override Stream GetBitStream() { }

	[Address(RVA = "0x10EDCF0", Offset = "0x10ECEF0", Length = "0xE2")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "ReadObject", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(BerBitStringParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseInputStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Streams), Member = "ReadAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DLBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001004")]
	internal static BerBitString Parse(Asn1StreamParser sp) { }

	[Address(RVA = "0x10EDDE0", Offset = "0x10ECFE0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BerBitStringParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerBitString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1ParsingException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001003")]
	public override Asn1Object ToAsn1Object() { }

}

