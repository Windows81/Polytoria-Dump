namespace Mirror.BouncyCastle.Asn1;

[Obsolete("Check for 'Asn1OctetStringParser' instead")]
[Token(Token = "0x20001B5")]
public class BerOctetStringParser : Asn1OctetStringParser, IAsn1Convertible
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400044B")]
	private readonly Asn1StreamParser m_parser; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600100B")]
	internal BerOctetStringParser(Asn1StreamParser parser) { }

	[Address(RVA = "0x10EE390", Offset = "0x10ED590", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseInputStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600100C")]
	public override Stream GetOctetStream() { }

	[Address(RVA = "0x10EE400", Offset = "0x10ED600", Length = "0xCE")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "ReadObject", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(BerOctetStringParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseInputStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Streams), Member = "ReadAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x600100E")]
	internal static BerOctetString Parse(Asn1StreamParser sp) { }

	[Address(RVA = "0x10EE4D0", Offset = "0x10ED6D0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BerOctetStringParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerOctetString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1ParsingException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600100D")]
	public override Asn1Object ToAsn1Object() { }

}

