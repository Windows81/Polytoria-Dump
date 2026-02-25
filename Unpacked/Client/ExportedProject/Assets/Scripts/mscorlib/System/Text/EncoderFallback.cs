namespace System.Text;

[Token(Token = "0x200029F")]
public abstract class EncoderFallback
{
	[Token(Token = "0x4000B8E")]
	private static EncoderFallback s_replacementFallback; //Field offset: 0x0
	[Token(Token = "0x4000B8F")]
	private static EncoderFallback s_exceptionFallback; //Field offset: 0x8

	[Token(Token = "0x1700021E")]
	public static EncoderFallback ExceptionFallback
	{
		[Address(RVA = "0x1528540", Offset = "0x1527740", Length = "0x98")]
		[CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600152E")]
		 get { } //Length: 152
	}

	[Token(Token = "0x1700021F")]
	public abstract int MaxCharCount
	{
		[Token(Token = "0x6001530")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700021D")]
	public static EncoderFallback ReplacementFallback
	{
		[Address(RVA = "0x15285E0", Offset = "0x15277E0", Length = "0x92")]
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Token(Token = "0x600152D")]
		 get { } //Length: 146
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001531")]
	protected EncoderFallback() { }

	[Token(Token = "0x600152F")]
	public abstract EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x1528540", Offset = "0x1527740", Length = "0x98")]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600152E")]
	public static EncoderFallback get_ExceptionFallback() { }

	[Token(Token = "0x6001530")]
	public abstract int get_MaxCharCount() { }

	[Address(RVA = "0x15285E0", Offset = "0x15277E0", Length = "0x92")]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Token(Token = "0x600152D")]
	public static EncoderFallback get_ReplacementFallback() { }

}

