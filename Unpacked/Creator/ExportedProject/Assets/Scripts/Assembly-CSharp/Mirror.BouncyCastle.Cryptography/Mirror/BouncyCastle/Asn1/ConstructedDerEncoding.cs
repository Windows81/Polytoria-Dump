namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001BD")]
internal class ConstructedDerEncoding : DerEncoding
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000459")]
	private readonly DerEncoding[] m_contentsElements; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045A")]
	private readonly int m_contentsLength; //Field offset: 0x20

	[Address(RVA = "0x10F0510", Offset = "0x10EF710", Length = "0x40")]
	[CalledBy(Type = typeof(DerSequence), Member = "GetEncodingDer", ReturnType = typeof(DerEncoding))]
	[CalledBy(Type = typeof(DerSequence), Member = "GetEncodingDerImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(DerEncoding))]
	[CalledBy(Type = typeof(DerSet), Member = "GetEncodingDer", ReturnType = typeof(DerEncoding))]
	[CalledBy(Type = typeof(DerSet), Member = "GetEncodingDerImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(DerEncoding))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetLengthOfContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsn1Encoding[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001034")]
	internal ConstructedDerEncoding(int tagClass, int tagNo, DerEncoding[] contentsElements) { }

	[Address(RVA = "0x10F0310", Offset = "0x10EF510", Length = "0x1F1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DerEncoding), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerEncoding)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001035")]
	protected private virtual int CompareLengthAndContents(DerEncoding other) { }

	[Address(RVA = "0x10F01F0", Offset = "0x10EF3F0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "WriteDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1OutputStream), Member = "EncodeContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001036")]
	public virtual void Encode(Asn1OutputStream asn1Out) { }

	[Address(RVA = "0x10F0250", Offset = "0x10EF450", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001037")]
	public virtual int GetLength() { }

}

