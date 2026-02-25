namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001E9")]
internal class DLTaggedObjectParser : BerTaggedObjectParser
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400049A")]
	private readonly bool m_constructed; //Field offset: 0x20

	[Address(RVA = "0x11029B0", Offset = "0x1101BB0", Length = "0x33")]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "ImplParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Convertible))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600117C")]
	internal DLTaggedObjectParser(int tagClass, int tagNo, bool constructed, Asn1StreamParser parser) { }

	[Address(RVA = "0x1102900", Offset = "0x1101B00", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1StreamParser), Member = "LoadTaggedDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600117D")]
	public virtual Asn1Object ToAsn1Object() { }

}

