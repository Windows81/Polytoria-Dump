namespace System.Text;

[Token(Token = "0x200028E")]
public abstract class Decoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B69")]
	internal DecoderFallback _fallback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B6A")]
	internal DecoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	[Token(Token = "0x17000204")]
	public DecoderFallback Fallback
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014B3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000205")]
	public DecoderFallbackBuffer FallbackBuffer
	{
		[Address(RVA = "0x15279C0", Offset = "0x1526BC0", Length = "0x77")]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EncodingCharBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EncodingCharBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(DecoderNLS), typeof(Char*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF32Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF32Encoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(DecoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(DecoderFallback))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60014B4")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000206")]
	internal bool InternalHasFallbackBuffer
	{
		[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
		[CallerCount(Count = 14)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60014B5")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B2")]
	protected Decoder() { }

	[Address(RVA = "0x1526CE0", Offset = "0x1525EE0", Length = "0x3DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014BE")]
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x15270C0", Offset = "0x15262C0", Length = "0x25F")]
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
	[Token(Token = "0x60014BF")]
	public override void Convert(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B3")]
	public DecoderFallback get_Fallback() { }

	[Address(RVA = "0x15279C0", Offset = "0x1526BC0", Length = "0x77")]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(DecoderNLS), typeof(Char*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(DecoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(DecoderFallback))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60014B4")]
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60014B5")]
	internal bool get_InternalHasFallbackBuffer() { }

	[Token(Token = "0x60014B7")]
	public abstract int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x15274B0", Offset = "0x15266B0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014B8")]
	public override int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[Address(RVA = "0x1527320", Offset = "0x1526520", Length = "0x185")]
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
	[Token(Token = "0x60014B9")]
	public override int GetCharCount(Byte* bytes, int count, bool flush) { }

	[Token(Token = "0x60014BA")]
	public abstract int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x15274D0", Offset = "0x15266D0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014BB")]
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

	[Address(RVA = "0x15274F0", Offset = "0x15266F0", Length = "0x256")]
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
	[Token(Token = "0x60014BC")]
	public override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

	[Address(RVA = "0x1527750", Offset = "0x1526950", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014BD")]
	public override int GetChars(ReadOnlySpan<Byte> bytes, Span<Char> chars, bool flush) { }

	[Address(RVA = "0x1527890", Offset = "0x1526A90", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60014B6")]
	public override void Reset() { }

}

