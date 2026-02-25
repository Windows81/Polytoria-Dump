namespace System.Text;

[Token(Token = "0x2000294")]
public abstract class DecoderFallback
{
	[Token(Token = "0x4000B75")]
	private static DecoderFallback s_replacementFallback; //Field offset: 0x0
	[Token(Token = "0x4000B76")]
	private static DecoderFallback s_exceptionFallback; //Field offset: 0x8

	[Token(Token = "0x1700020D")]
	public static DecoderFallback ExceptionFallback
	{
		[Address(RVA = "0x1525790", Offset = "0x1524990", Length = "0x9F")]
		[CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60014DB")]
		 get { } //Length: 159
	}

	[Token(Token = "0x1700020E")]
	public abstract int MaxCharCount
	{
		[Token(Token = "0x60014DD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700020C")]
	public static DecoderFallback ReplacementFallback
	{
		[Address(RVA = "0x1525830", Offset = "0x1524A30", Length = "0x99")]
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Token(Token = "0x60014DA")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014DE")]
	protected DecoderFallback() { }

	[Token(Token = "0x60014DC")]
	public abstract DecoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x1525790", Offset = "0x1524990", Length = "0x9F")]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60014DB")]
	public static DecoderFallback get_ExceptionFallback() { }

	[Token(Token = "0x60014DD")]
	public abstract int get_MaxCharCount() { }

	[Address(RVA = "0x1525830", Offset = "0x1524A30", Length = "0x99")]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Token(Token = "0x60014DA")]
	public static DecoderFallback get_ReplacementFallback() { }

}

