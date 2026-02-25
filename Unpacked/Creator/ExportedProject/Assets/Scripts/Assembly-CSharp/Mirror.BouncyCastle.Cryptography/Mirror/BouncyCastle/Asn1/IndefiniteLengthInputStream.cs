namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001ED")]
internal class IndefiniteLengthInputStream : LimitedInputStream
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400049B")]
	private int _lookAhead; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400049C")]
	private bool _eofOn00; //Field offset: 0x3C

	[Address(RVA = "0x110EF70", Offset = "0x110E170", Length = "0x61")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "ReadObject", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "ImplParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Convertible))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseInputStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(IndefiniteLengthInputStream), Member = "RequireByte", ReturnType = typeof(int))]
	[Calls(Type = typeof(IndefiniteLengthInputStream), Member = "CheckEndOfContents", ReturnType = typeof(void))]
	[Token(Token = "0x6001181")]
	internal IndefiniteLengthInputStream(Stream inStream, int limit) { }

	[Address(RVA = "0x110EC40", Offset = "0x110DE40", Length = "0x118")]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = "SetEofOn00", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LimitedInputStream), Member = "SetParentEofDetect", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(IndefiniteLengthInputStream), Member = "RequireByte", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001183")]
	private void CheckEndOfContents() { }

	[Address(RVA = "0x110EDB0", Offset = "0x110DFB0", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IndefiniteLengthInputStream), Member = "RequireByte", ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseInputStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001184")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x110ED60", Offset = "0x110DF60", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IndefiniteLengthInputStream), Member = "CheckEndOfContents", ReturnType = typeof(void))]
	[Calls(Type = typeof(IndefiniteLengthInputStream), Member = "RequireByte", ReturnType = typeof(int))]
	[Token(Token = "0x6001185")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x110EED0", Offset = "0x110E0D0", Length = "0x70")]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = "CheckEndOfContents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(IndefiniteLengthInputStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001186")]
	private int RequireByte() { }

	[Address(RVA = "0x110EF50", Offset = "0x110E150", Length = "0x15")]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "ImplParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Convertible))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "Set00Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IndefiniteLengthInputStream), Member = "CheckEndOfContents", ReturnType = typeof(void))]
	[Token(Token = "0x6001182")]
	internal void SetEofOn00(bool eofOn00) { }

}

