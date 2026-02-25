namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001DA")]
public class DerSetParser : IAsn1Convertible
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048F")]
	private readonly Asn1StreamParser m_parser; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600111B")]
	internal DerSetParser(Asn1StreamParser parser) { }

	[Address(RVA = "0x110B470", Offset = "0x110A670", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1StreamParser), Member = "ReadVector", ReturnType = typeof(Asn1EncodableVector))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600111C")]
	public override Asn1Object ToAsn1Object() { }

}

