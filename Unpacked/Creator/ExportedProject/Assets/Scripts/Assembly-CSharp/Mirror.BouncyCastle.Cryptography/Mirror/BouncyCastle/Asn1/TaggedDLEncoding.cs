namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001F5")]
internal class TaggedDLEncoding : IAsn1Encoding
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004AD")]
	private readonly int m_tagClass; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004AE")]
	private readonly int m_tagNo; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004AF")]
	private readonly IAsn1Encoding m_contentsElement; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B0")]
	private readonly int m_contentsLength; //Field offset: 0x20

	[Address(RVA = "0x1116650", Offset = "0x1115850", Length = "0xF1")]
	[CalledBy(Type = typeof(DerTaggedObject), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DerTaggedObject), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DLTaggedObject), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DLTaggedObject), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011A0")]
	internal TaggedDLEncoding(int tagClass, int tagNo, IAsn1Encoding contentsElement) { }

	[Address(RVA = "0x11165C0", Offset = "0x11157C0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60011A1")]
	private override void Mirror.BouncyCastle.Asn1.IAsn1Encoding.Encode(Asn1OutputStream asn1Out) { }

	[Address(RVA = "0x1116640", Offset = "0x1115840", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetLengthOfEncodingDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60011A2")]
	private override int Mirror.BouncyCastle.Asn1.IAsn1Encoding.GetLength() { }

}

