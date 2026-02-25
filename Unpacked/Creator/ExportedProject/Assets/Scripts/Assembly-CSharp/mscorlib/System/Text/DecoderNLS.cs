namespace System.Text;

[Token(Token = "0x2000296")]
internal class DecoderNLS : Decoder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B79")]
	private Encoding _encoding; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B7A")]
	private bool _mustFlush; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000B7B")]
	internal bool _throwOnOverflow; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B7C")]
	internal int _bytesUsed; //Field offset: 0x2C

	[Token(Token = "0x17000211")]
	internal override bool HasState
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F4")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000210")]
	public bool MustFlush
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1526620", Offset = "0x1525820", Length = "0x67")]
	[CalledBy(Type = typeof(EncodingNLS), Member = "GetDecoder", ReturnType = typeof(Decoder))]
	[CalledBy(Type = "System.Text.UTF32Encoding+UTF32Decoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF32Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
	[CalledBy(Type = "System.Text.UTF7Encoding+Decoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF7Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
	[CalledBy(Type = "System.Text.UTF8Encoding+UTF8Decoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF8Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
	[CalledBy(Type = "System.Text.UnicodeEncoding+Decoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnicodeEncoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014E9")]
	internal DecoderNLS(Encoding encoding) { }

	[Address(RVA = "0x15258D0", Offset = "0x1524AD0", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F5")]
	internal void ClearMustFlush() { }

	[Address(RVA = "0x1525AC0", Offset = "0x1524CC0", Length = "0x3B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014F1")]
	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x15258E0", Offset = "0x1524AE0", Length = "0x1DB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014F2")]
	public virtual void Convert(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F4")]
	internal override bool get_HasState() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F3")]
	public bool get_MustFlush() { }

	[Address(RVA = "0x1325010", Offset = "0x1324210", Length = "0x27")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014EB")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1525FA0", Offset = "0x15251A0", Length = "0x1E8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18019EC20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60014EC")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[Address(RVA = "0x1525E80", Offset = "0x1525080", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014ED")]
	public virtual int GetCharCount(Byte* bytes, int count, bool flush) { }

	[Address(RVA = "0x1325070", Offset = "0x1324270", Length = "0x39")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014EE")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x15262F0", Offset = "0x15254F0", Length = "0x307")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018F460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60014EF")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

	[Address(RVA = "0x1526190", Offset = "0x1525390", Length = "0x150")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60014F0")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

	[Address(RVA = "0x1526600", Offset = "0x1525800", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60014EA")]
	public virtual void Reset() { }

}

