namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001F1")]
internal class PrimitiveDerEncodingSuffixed : DerEncoding
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004A2")]
	private readonly Byte[] m_contentsOctets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004A3")]
	private readonly byte m_contentsSuffix; //Field offset: 0x20

	[Address(RVA = "0x11110D0", Offset = "0x11102D0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001191")]
	internal PrimitiveDerEncodingSuffixed(int tagClass, int tagNo, Byte[] contentsOctets, byte contentsSuffix) { }

	[Address(RVA = "0x1110DB0", Offset = "0x110FFB0", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PrimitiveDerEncodingSuffixed), Member = "CompareSuffixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001192")]
	protected private virtual int CompareLengthAndContents(DerEncoding other) { }

	[Address(RVA = "0x1110F20", Offset = "0x1110120", Length = "0xD0")]
	[CalledBy(Type = typeof(PrimitiveDerEncodingSuffixed), Member = "CompareLengthAndContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerEncoding)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001195")]
	private static int CompareSuffixed(Byte[] octetsA, byte suffixA, Byte[] octetsB, byte suffixB) { }

	[Address(RVA = "0x1111000", Offset = "0x1110200", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001193")]
	public virtual void Encode(Asn1OutputStream asn1Out) { }

	[Address(RVA = "0x11110A0", Offset = "0x11102A0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetLengthOfEncodingDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001194")]
	public virtual int GetLength() { }

}

