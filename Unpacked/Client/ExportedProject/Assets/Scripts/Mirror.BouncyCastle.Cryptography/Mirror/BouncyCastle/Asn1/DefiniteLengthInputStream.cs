namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001C1")]
internal class DefiniteLengthInputStream : LimitedInputStream
{
	[Token(Token = "0x4000465")]
	private static readonly Byte[] EmptyBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000466")]
	private readonly int _originalLength; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000467")]
	private int _remaining; //Field offset: 0x3C

	[Token(Token = "0x1700018D")]
	internal int Remaining
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001043")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x10F1370", Offset = "0x10F0570", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001048")]
	private static DefiniteLengthInputStream() { }

	[Address(RVA = "0x10F13E0", Offset = "0x10F05E0", Length = "0x99")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "ImplParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Convertible))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LimitedInputStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LimitedInputStream), Member = "SetParentEofDetect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001042")]
	internal DefiniteLengthInputStream(Stream inStream, int length, int limit) { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001043")]
	internal int get_Remaining() { }

	[Address(RVA = "0x10F0F90", Offset = "0x10F0190", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LimitedInputStream), Member = "SetParentEofDetect", ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001045")]
	public virtual int Read(Byte[] buf, int off, int len) { }

	[Address(RVA = "0x10F0B40", Offset = "0x10EFD40", Length = "0x246")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "GetBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefiniteLengthInputStream), typeof(Byte[][]), typeof(Byte[]&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "CreatePrimitiveDerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefiniteLengthInputStream), typeof(Byte[][])}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(LimitedInputStream), Member = "SetParentEofDetect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Streams), Member = "ReadFully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001046")]
	internal void ReadAllIntoByteArray(Byte[] buf) { }

	[Address(RVA = "0x10F0D90", Offset = "0x10EFF90", Length = "0x1F6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LimitedInputStream), Member = "SetParentEofDetect", ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001044")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x10F1110", Offset = "0x10F0310", Length = "0x252")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "ReadTaggedObjectDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(DefiniteLengthInputStream)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "GetBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefiniteLengthInputStream), typeof(Byte[][]), typeof(Byte[]&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "CreatePrimitiveDerObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DefiniteLengthInputStream), typeof(Byte[][])}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1StreamParser), Member = "LoadTaggedDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(DerOctetStringParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(DLBitStringParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Streams), Member = "ReadFully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(LimitedInputStream), Member = "SetParentEofDetect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001047")]
	internal Byte[] ToArray() { }

}

