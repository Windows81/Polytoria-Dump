namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001F4")]
internal class TaggedDerEncoding : DerEncoding
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004AB")]
	private readonly DerEncoding m_contentsElement; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004AC")]
	private readonly int m_contentsLength; //Field offset: 0x20

	[Address(RVA = "0x1116900", Offset = "0x1115B00", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600119C")]
	internal TaggedDerEncoding(int tagClass, int tagNo, DerEncoding contentsElement) { }

	[Address(RVA = "0x1116750", Offset = "0x1115950", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600119D")]
	protected private virtual int CompareLengthAndContents(DerEncoding other) { }

	[Address(RVA = "0x1116890", Offset = "0x1115A90", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600119E")]
	public virtual void Encode(Asn1OutputStream asn1Out) { }

	[Address(RVA = "0x1116640", Offset = "0x1115840", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetLengthOfEncodingDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x600119F")]
	public virtual int GetLength() { }

}

