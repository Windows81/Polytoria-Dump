namespace System.Text;

[Token(Token = "0x20002A0")]
public abstract class EncoderFallbackBuffer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B90")]
	internal Char* charStart; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B91")]
	internal Char* charEnd; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B92")]
	internal EncoderNLS encoder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B93")]
	internal bool setEncoder; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000B94")]
	internal bool bUsedEncoder; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000B95")]
	internal bool bFallingBack; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B96")]
	internal int iRecursionCount; //Field offset: 0x2C

	[Token(Token = "0x17000220")]
	public abstract int Remaining
	{
		[Token(Token = "0x6001536")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600153D")]
	protected EncoderFallbackBuffer() { }

	[Token(Token = "0x6001532")]
	public abstract bool Fallback(char charUnknown, int index) { }

	[Token(Token = "0x6001533")]
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[Token(Token = "0x6001536")]
	public abstract int get_Remaining() { }

	[Token(Token = "0x6001534")]
	public abstract char GetNextChar() { }

	[Address(RVA = "0x1527FC0", Offset = "0x15271C0", Length = "0x193")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(char), Member = "ConvertToUtf32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "ThrowLastCharRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600153B")]
	internal override bool InternalFallback(char ch, ref Char* chars) { }

	[Address(RVA = "0x1528160", Offset = "0x1527360", Length = "0x37")]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "GetNextChar", ReturnType = typeof(char))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600153A")]
	internal char InternalGetNextChar() { }

	[Address(RVA = "0x15281A0", Offset = "0x15273A0", Length = "0x3C")]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetByteCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(EncoderNLS), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001539")]
	internal void InternalInitialize(Char* charStart, Char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	[Address(RVA = "0x15281E0", Offset = "0x15273E0", Length = "0x20")]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001538")]
	internal void InternalReset() { }

	[Token(Token = "0x6001535")]
	public abstract bool MovePrevious() { }

	[Address(RVA = "0x1528200", Offset = "0x1527400", Length = "0x31")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001537")]
	public override void Reset() { }

	[Address(RVA = "0x1528240", Offset = "0x1527440", Length = "0x8A")]
	[CalledBy(Type = typeof(EncoderFallbackBuffer), Member = "InternalFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(Char*&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncoderReplacementFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600153C")]
	internal void ThrowLastCharRecursive(int charRecursive) { }

}

