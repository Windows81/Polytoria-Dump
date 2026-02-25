namespace System.Text;

[Token(Token = "0x20002B5")]
public class UnicodeEncoding : Encoding
{
	[Token(Token = "0x20002B6")]
	private sealed class Decoder : DecoderNLS
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BD3")]
		internal int lastByte; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000BD4")]
		internal char lastChar; //Field offset: 0x34

		[Token(Token = "0x17000237")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x1324FC0", Offset = "0x13241C0", Length = "0x12")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001655")]
			internal get { } //Length: 18
		}

		[Address(RVA = "0x1324FB0", Offset = "0x13241B0", Length = "0xF")]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetDecoder", ReturnType = typeof(Decoder))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001653")]
		public Decoder(UnicodeEncoding encoding) { }

		[Address(RVA = "0x1324FC0", Offset = "0x13241C0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001655")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x1324F80", Offset = "0x1324180", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001654")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x4000BCB")]
	internal static readonly UnicodeEncoding s_bigEndianDefault; //Field offset: 0x0
	[Token(Token = "0x4000BCC")]
	internal static readonly UnicodeEncoding s_littleEndianDefault; //Field offset: 0x8
	[Token(Token = "0x4000BCD")]
	private static readonly Byte[] s_bigEndianPreamble; //Field offset: 0x10
	[Token(Token = "0x4000BCE")]
	private static readonly Byte[] s_littleEndianPreamble; //Field offset: 0x18
	[Token(Token = "0x4000BD2")]
	private static readonly ulong highLowPatternMask; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BCF")]
	internal bool isThrowException; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000BD0")]
	internal bool bigEndian; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000BD1")]
	internal bool byteOrderMark; //Field offset: 0x3A

	[Token(Token = "0x17000236")]
	public virtual ReadOnlySpan<Byte> Preamble
	{
		[Address(RVA = "0x131FAD0", Offset = "0x131ECD0", Length = "0xAB9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(SharedStatics), Member = "ReleaseSharedStringMaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringMaker&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
		[Calls(Type = typeof(CryptographicOperations), Member = "ZeroMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600164D")]
		 get { } //Length: 2745
	}

	[Address(RVA = "0x131F800", Offset = "0x131EA00", Length = "0x1C3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001652")]
	private static UnicodeEncoding() { }

	[Address(RVA = "0x131F9D0", Offset = "0x131EBD0", Length = "0x72")]
	[CalledBy(Type = "UnityEngine.TextAsset+EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001639")]
	public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[Address(RVA = "0x131FAA0", Offset = "0x131ECA0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001637")]
	public UnicodeEncoding() { }

	[Address(RVA = "0x131FA50", Offset = "0x131EC50", Length = "0x46")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(StringWriter), Member = "get_Encoding", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001638")]
	public UnicodeEncoding(bool bigEndian, bool byteOrderMark) { }

	[Address(RVA = "0x131BC20", Offset = "0x131AE20", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001650")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x131FAD0", Offset = "0x131ECD0", Length = "0xAB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030CE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CryptographicOperations), Member = "ZeroMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SharedStatics), Member = "ReleaseSharedStringMaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringMaker&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600164D")]
	public virtual ReadOnlySpan<Byte> get_Preamble() { }

	[Address(RVA = "0x131BEF0", Offset = "0x131B0F0", Length = "0x73E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001646")]
	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS encoder) { }

	[Address(RVA = "0x131BD40", Offset = "0x131AF40", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600163B")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x131C630", Offset = "0x131B830", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600163C")]
	public virtual int GetByteCount(string s) { }

	[Address(RVA = "0x131C6D0", Offset = "0x131B8D0", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x600163D")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x131C7D0", Offset = "0x131B9D0", Length = "0x2C5")]
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
	[Token(Token = "0x600163E")]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x131D370", Offset = "0x131C570", Length = "0x2C0")]
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
	[Token(Token = "0x600163F")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x131D640", Offset = "0x131C840", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6001640")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x131CAA0", Offset = "0x131BCA0", Length = "0x8CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001647")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	[Address(RVA = "0x131E110", Offset = "0x131D310", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001641")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x131E010", Offset = "0x131D210", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6001642")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x131D770", Offset = "0x131C970", Length = "0x894")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001648")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x131E2C0", Offset = "0x131D4C0", Length = "0x9F5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001649")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x131ECC0", Offset = "0x131DEC0", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6001644")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x131EDF0", Offset = "0x131DFF0", Length = "0x2C1")]
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
	[Token(Token = "0x6001643")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x131F0C0", Offset = "0x131E2C0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Decoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnicodeEncoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x600164B")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x131F120", Offset = "0x131E320", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x600164A")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x131F180", Offset = "0x131E380", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001651")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x131F220", Offset = "0x131E420", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600164E")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x131F360", Offset = "0x131E560", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600164F")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x131F4B0", Offset = "0x131E6B0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600164C")]
	public virtual Byte[] GetPreamble() { }

	[Address(RVA = "0x131F560", Offset = "0x131E760", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001645")]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x131F710", Offset = "0x131E910", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(EncoderFallback))]
	[Calls(Type = typeof(DecoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(DecoderFallback))]
	[Token(Token = "0x600163A")]
	internal virtual void SetDefaultFallbacks() { }

}

