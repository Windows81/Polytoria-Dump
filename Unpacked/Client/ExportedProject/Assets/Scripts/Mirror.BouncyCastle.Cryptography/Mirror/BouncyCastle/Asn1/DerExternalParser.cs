namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001C9")]
public class DerExternalParser : Asn1Encodable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000479")]
	private readonly Asn1StreamParser m_parser; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001091")]
	internal DerExternalParser(Asn1StreamParser parser) { }

	[Address(RVA = "0x11056A0", Offset = "0x11048A0", Length = "0xB3")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "ReadObject", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1StreamParser), Member = "ReadVector", ReturnType = typeof(Asn1EncodableVector))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BerSequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerExternal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001093")]
	internal static DerExternal Parse(Asn1StreamParser sp) { }

	[Address(RVA = "0x1105760", Offset = "0x1104960", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1StreamParser), Member = "ReadVector", ReturnType = typeof(Asn1EncodableVector))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BerSequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerExternal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001092")]
	public virtual Asn1Object ToAsn1Object() { }

}

