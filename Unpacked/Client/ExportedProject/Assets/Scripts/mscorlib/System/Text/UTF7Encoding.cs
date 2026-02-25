namespace System.Text;

[Token(Token = "0x20002AC")]
public class UTF7Encoding : Encoding
{
	[Token(Token = "0x20002AD")]
	private sealed class Decoder : DecoderNLS
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BBD")]
		internal int bits; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000BBE")]
		internal int bitCount; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BBF")]
		internal bool firstByte; //Field offset: 0x38

		[Token(Token = "0x1700022E")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x130B140", Offset = "0x130A340", Length = "0x8")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60015FE")]
			internal get { } //Length: 8
		}

		[Address(RVA = "0x130B130", Offset = "0x130A330", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60015FC")]
		public Decoder(UTF7Encoding encoding) { }

		[Address(RVA = "0x130B140", Offset = "0x130A340", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60015FE")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x130B0F0", Offset = "0x130A2F0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60015FD")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x20002AF")]
	private sealed class DecoderUTF7Fallback : DecoderFallback
	{

		[Token(Token = "0x17000230")]
		public virtual int MaxCharCount
		{
			[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001604")]
			 get { } //Length: 6
		}

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001602")]
		public DecoderUTF7Fallback() { }

		[Address(RVA = "0x130B040", Offset = "0x130A240", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001603")]
		public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

		[Address(RVA = "0x130B090", Offset = "0x130A290", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001605")]
		public virtual bool Equals(object value) { }

		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001604")]
		public virtual int get_MaxCharCount() { }

		[Address(RVA = "0x130B0E0", Offset = "0x130A2E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001606")]
		public virtual int GetHashCode() { }

	}

	[Token(Token = "0x20002B0")]
	private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BC2")]
		private char cFallback; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000BC3")]
		private int iCount; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BC4")]
		private int iSize; //Field offset: 0x28

		[Token(Token = "0x17000231")]
		public virtual int Remaining
		{
			[Address(RVA = "0x130B030", Offset = "0x130A230", Length = "0xD")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600160A")]
			 get { } //Length: 13
		}

		[Address(RVA = "0x130B020", Offset = "0x130A220", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001607")]
		public DecoderUTF7FallbackBuffer(DecoderUTF7Fallback fallback) { }

		[Address(RVA = "0x130AF20", Offset = "0x130A120", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001608")]
		public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

		[Address(RVA = "0x130B030", Offset = "0x130A230", Length = "0xD")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600160A")]
		public virtual int get_Remaining() { }

		[Address(RVA = "0x130AF70", Offset = "0x130A170", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001609")]
		public virtual char GetNextChar() { }

		[Address(RVA = "0x130AF90", Offset = "0x130A190", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600160C")]
		internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

		[Address(RVA = "0x130B010", Offset = "0x130A210", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600160B")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x20002AE")]
	private sealed class Encoder : EncoderNLS
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BC0")]
		internal int bits; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000BC1")]
		internal int bitCount; //Field offset: 0x3C

		[Token(Token = "0x1700022F")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x130B9B0", Offset = "0x130ABB0", Length = "0x11")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001601")]
			internal get { } //Length: 17
		}

		[Address(RVA = "0x130B9A0", Offset = "0x130ABA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60015FF")]
		public Encoder(UTF7Encoding encoding) { }

		[Address(RVA = "0x130B9B0", Offset = "0x130ABB0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001601")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x130B970", Offset = "0x130AB70", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001600")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x4000BB8")]
	internal static readonly UTF7Encoding s_default; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BB9")]
	private Byte[] _base64Bytes; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BBA")]
	private SByte[] _base64Values; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BBB")]
	private Boolean[] _directEncode; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BBC")]
	private bool _allowOptionals; //Field offset: 0x50

	[Address(RVA = "0x1318070", Offset = "0x1317270", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF7Encoding), Member = "MakeTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60015FB")]
	private static UTF7Encoding() { }

	[Address(RVA = "0x13180F0", Offset = "0x13172F0", Length = "0x29")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Encoding), Member = "get_UTF7", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF7Encoding), Member = "MakeTables", ReturnType = typeof(void))]
	[Token(Token = "0x60015E2")]
	public UTF7Encoding() { }

	[Address(RVA = "0x1318120", Offset = "0x1317320", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF7Encoding), Member = "MakeTables", ReturnType = typeof(void))]
	[Token(Token = "0x60015E3")]
	public UTF7Encoding(bool allowOptionals) { }

	[Address(RVA = "0x13160D0", Offset = "0x13152D0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60015E6")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1316380", Offset = "0x1315580", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60015E8")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x13162E0", Offset = "0x13154E0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60015E9")]
	public virtual int GetByteCount(string s) { }

	[Address(RVA = "0x13161A0", Offset = "0x13153A0", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x60015EA")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x13162A0", Offset = "0x13154A0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60015F3")]
	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS baseEncoder) { }

	[Address(RVA = "0x1316AD0", Offset = "0x1315CD0", Length = "0x38B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncodingByteBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(EncoderNLS), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "get_MoreData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "GetNextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingByteBuffer), Member = "get_CharsUsed", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60015F4")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	[Address(RVA = "0x1316800", Offset = "0x1315A00", Length = "0x2C5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60015EB")]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1316530", Offset = "0x1315730", Length = "0x2C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60015EC")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1316E60", Offset = "0x1316060", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x60015ED")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1316F90", Offset = "0x1316190", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x60015EF")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x1317240", Offset = "0x1316440", Length = "0x32")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60015F5")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x1317090", Offset = "0x1316290", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60015EE")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x13177A0", Offset = "0x13169A0", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x60015F1")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x1317280", Offset = "0x1316480", Length = "0x246")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncodingCharBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(DecoderNLS), typeof(Char*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "get_MoreData", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "GetNextByte", ReturnType = typeof(byte))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "AdjustBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingCharBuffer), Member = "get_BytesUsed", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015F6")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x13174D0", Offset = "0x13166D0", Length = "0x2C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60015F0")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x13178D0", Offset = "0x1316AD0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x60015F7")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x1317930", Offset = "0x1316B30", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x60015F8")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x1317990", Offset = "0x1316B90", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60015E7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1317A10", Offset = "0x1316C10", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60015F9")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x1317B00", Offset = "0x1316D00", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60015FA")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x1317B90", Offset = "0x1316D90", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60015F2")]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1317D40", Offset = "0x1316F40", Length = "0x27D")]
	[CalledBy(Type = typeof(UTF7Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015E4")]
	private void MakeTables() { }

	[Address(RVA = "0x1317FC0", Offset = "0x13171C0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015E5")]
	internal virtual void SetDefaultFallbacks() { }

}

