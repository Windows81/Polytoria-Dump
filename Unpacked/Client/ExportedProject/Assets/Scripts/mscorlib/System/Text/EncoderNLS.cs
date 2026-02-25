namespace System.Text;

[Token(Token = "0x20002A1")]
internal class EncoderNLS : Encoder
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B97")]
	internal char _charLeftOver; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B98")]
	private Encoding _encoding; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B99")]
	private bool _mustFlush; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000B9A")]
	internal bool _throwOnOverflow; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B9B")]
	internal int _charsUsed; //Field offset: 0x34

	[Token(Token = "0x17000221")]
	public Encoding Encoding
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001546")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000223")]
	internal override bool HasState
	{
		[Address(RVA = "0x1529430", Offset = "0x1528630", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001548")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x17000222")]
	public bool MustFlush
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001547")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15293C0", Offset = "0x15285C0", Length = "0x67")]
	[CalledBy(Type = typeof(EncodingNLS), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CalledBy(Type = "System.Text.UTF7Encoding+Encoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF7Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CalledBy(Type = "System.Text.UTF8Encoding+UTF8Encoder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UTF8Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600153E")]
	internal EncoderNLS(Encoding encoding) { }

	[Address(RVA = "0xE284F0", Offset = "0xE276F0", Length = "0x5")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001549")]
	internal void ClearMustFlush() { }

	[Address(RVA = "0x1528860", Offset = "0x1527A60", Length = "0x3B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001544")]
	public virtual void Convert(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[Address(RVA = "0x1528680", Offset = "0x1527880", Length = "0x1DB")]
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
	[Token(Token = "0x6001545")]
	public virtual void Convert(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001546")]
	public Encoding get_Encoding() { }

	[Address(RVA = "0x1529430", Offset = "0x1528630", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001548")]
	internal override bool get_HasState() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001547")]
	public bool get_MustFlush() { }

	[Address(RVA = "0x1528C20", Offset = "0x1527E20", Length = "0x1E8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18019EC20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001540")]
	public virtual int GetByteCount(Char[] chars, int index, int count, bool flush) { }

	[Address(RVA = "0x1528E10", Offset = "0x1528010", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001541")]
	public virtual int GetByteCount(Char* chars, int count, bool flush) { }

	[Address(RVA = "0x1528F30", Offset = "0x1528130", Length = "0x306")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018F460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001542")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

	[Address(RVA = "0x1529240", Offset = "0x1528440", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001543")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

	[Address(RVA = "0x1529390", Offset = "0x1528590", Length = "0x25")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600153F")]
	public virtual void Reset() { }

}

