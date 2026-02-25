namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001BB")]
internal class BerTaggedObjectParser : IAsn1Convertible
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000450")]
	internal readonly int m_tagClass; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000451")]
	internal readonly int m_tagNo; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000452")]
	internal readonly Asn1StreamParser m_parser; //Field offset: 0x18

	[Token(Token = "0x1700018A")]
	public override int TagClass
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600102C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700018B")]
	public override int TagNo
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600102D")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x10EF790", Offset = "0x10EE990", Length = "0x50")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600102B")]
	internal BerTaggedObjectParser(int tagClass, int tagNo, Asn1StreamParser parser) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600102C")]
	public override int get_TagClass() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600102D")]
	public override int get_TagNo() { }

	[Address(RVA = "0x10EF6E0", Offset = "0x10EE8E0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1StreamParser), Member = "LoadTaggedIL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600102E")]
	public override Asn1Object ToAsn1Object() { }

}

