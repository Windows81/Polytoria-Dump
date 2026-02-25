namespace System.Text;

[Token(Token = "0x2000299")]
public abstract class Encoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B81")]
	internal EncoderFallback _fallback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B82")]
	internal EncoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	[Token(Token = "0x17000215")]
	public EncoderFallback Fallback
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001506")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000216")]
	public EncoderFallbackBuffer FallbackBuffer
	{
		[Address(RVA = "0x1529F60", Offset = "0x1529160", Length = "0x77")]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EncodingByteBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(EncoderNLS), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(EncoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(EncoderFallback))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001507")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000217")]
	internal bool InternalHasFallbackBuffer
	{
		[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
		[CallerCount(Count = 14)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001508")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001505")]
	protected Encoder() { }

	[Address(RVA = "0x15296A0", Offset = "0x15288A0", Length = "0x3DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600150E")]
	public override void Convert(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[Address(RVA = "0x1529440", Offset = "0x1528640", Length = "0x25F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600150F")]
	public override void Convert(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001506")]
	public EncoderFallback get_Fallback() { }

	[Address(RVA = "0x1529F60", Offset = "0x1529160", Length = "0x77")]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(EncoderNLS), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(EncoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(EncoderFallback))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001507")]
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001508")]
	internal bool get_InternalHasFallbackBuffer() { }

	[Token(Token = "0x600150A")]
	public abstract int GetByteCount(Char[] chars, int index, int count, bool flush) { }

	[Address(RVA = "0x1529A80", Offset = "0x1528C80", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x600150B")]
	public override int GetByteCount(Char* chars, int count, bool flush) { }

	[Token(Token = "0x600150C")]
	public abstract int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

	[Address(RVA = "0x1529C20", Offset = "0x1528E20", Length = "0x257")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x600150D")]
	public override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

	[Address(RVA = "0x1529E80", Offset = "0x1529080", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001509")]
	public override void Reset() { }

}

