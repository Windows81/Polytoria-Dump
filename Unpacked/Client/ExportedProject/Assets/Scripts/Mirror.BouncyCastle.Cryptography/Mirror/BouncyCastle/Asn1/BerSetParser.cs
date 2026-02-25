namespace Mirror.BouncyCastle.Asn1;

[Obsolete("Check for 'Asn1SetParser' instead")]
[Token(Token = "0x20001B9")]
public class BerSetParser : IAsn1Convertible
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400044F")]
	private readonly Asn1StreamParser m_parser; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001024")]
	internal BerSetParser(Asn1StreamParser parser) { }

	[Address(RVA = "0x10EF1C0", Offset = "0x10EE3C0", Length = "0x115")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "ReadObject", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(BerSetParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1StreamParser), Member = "ReadVector", ReturnType = typeof(Asn1EncodableVector))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DLSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001026")]
	internal static BerSet Parse(Asn1StreamParser sp) { }

	[Address(RVA = "0x10EF2E0", Offset = "0x10EE4E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BerSetParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerSet))]
	[Token(Token = "0x6001025")]
	public override Asn1Object ToAsn1Object() { }

}

