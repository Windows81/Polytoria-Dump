namespace System.Text;

[Token(Token = "0x20002B1")]
public class UTF8Encoding : Encoding
{
	[Token(Token = "0x20002B4")]
	private sealed class UTF8Decoder : DecoderNLS
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BCA")]
		internal int bits; //Field offset: 0x30

		[Token(Token = "0x17000235")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x1318190", Offset = "0x1317390", Length = "0x8")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001636")]
			internal get { } //Length: 8
		}

		[Address(RVA = "0x130B130", Offset = "0x130A330", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001634")]
		public UTF8Decoder(UTF8Encoding encoding) { }

		[Address(RVA = "0x1318190", Offset = "0x1317390", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001636")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x1318160", Offset = "0x1317360", Length = "0x27")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001635")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x20002B3")]
	private sealed class UTF8Encoder : EncoderNLS
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BC9")]
		internal int surrogateChar; //Field offset: 0x38

		[Token(Token = "0x17000234")]
		internal virtual bool HasState
		{
			[Address(RVA = "0x13181D0", Offset = "0x13173D0", Length = "0x8")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001633")]
			internal get { } //Length: 8
		}

		[Address(RVA = "0x130B9A0", Offset = "0x130ABA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001631")]
		public UTF8Encoder(UTF8Encoding encoding) { }

		[Address(RVA = "0x13181D0", Offset = "0x13173D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001633")]
		internal virtual bool get_HasState() { }

		[Address(RVA = "0x13181A0", Offset = "0x13173A0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001632")]
		public virtual void Reset() { }

	}

	[Token(Token = "0x20002B2")]
	public sealed class UTF8EncodingSealed : UTF8Encoding
	{

		[Token(Token = "0x17000233")]
		public virtual ReadOnlySpan<Byte> Preamble
		{
			[Address(RVA = "0x1318250", Offset = "0x1317450", Length = "0xAC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001630")]
			 get { } //Length: 172
		}

		[Address(RVA = "0x13181E0", Offset = "0x13173E0", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x600162F")]
		public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier) { }

		[Address(RVA = "0x1318250", Offset = "0x1317450", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001630")]
		public virtual ReadOnlySpan<Byte> get_Preamble() { }

	}

	[Token(Token = "0x4000BC5")]
	internal static readonly UTF8EncodingSealed s_default; //Field offset: 0x0
	[Token(Token = "0x4000BC6")]
	internal static readonly Byte[] s_preamble; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BC7")]
	internal readonly bool _emitUTF8Identifier; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000BC8")]
	private bool _isThrowException; //Field offset: 0x39

	[Token(Token = "0x17000232")]
	public virtual ReadOnlySpan<Byte> Preamble
	{
		[Address(RVA = "0x131BAF0", Offset = "0x131ACF0", Length = "0x129")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600162B")]
		 get { } //Length: 297
	}

	[Address(RVA = "0x131B910", Offset = "0x131AB10", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Token(Token = "0x600162E")]
	private static UTF8Encoding() { }

	[Address(RVA = "0x131BA30", Offset = "0x131AC30", Length = "0x58")]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = "U8Xml.Internal.UTF8ExceptionFallbackEncoding", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkWriter", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkReaderPooled", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkReaderPooled", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkReaderPool+<>c", Member = "<.cctor>b__6_0", ReturnType = "Mirror.NetworkReaderPooled")]
	[CalledBy(Type = "Mirror.NetworkReader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "SwitchEncodingToUTF8", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "UnityEngine.TextAsset+EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader+<>c", Member = "<ReadT61String>b__45_0", ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(BinaryWriter), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncodingHelper), Member = "get_UTF8Unmarked", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "U8Xml.Internal.UTF8ExceptionFallbackEncoding", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600160F")]
	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	[Address(RVA = "0x131BA90", Offset = "0x131AC90", Length = "0x22")]
	[CalledBy(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509Name", Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600160D")]
	public UTF8Encoding() { }

	[Address(RVA = "0x131BAC0", Offset = "0x131ACC0", Length = "0x2F")]
	[CalledBy(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IoModule", Member = "HandleDefaultStreamSetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments", "MoonSharp.Interpreter.Platforms.StandardFileType"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IoModule", Member = "GetUTF8Encoding", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IoModule", Member = "tmpfile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600160E")]
	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) { }

	[Address(RVA = "0x1318300", Offset = "0x1317500", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600162C")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1318420", Offset = "0x1317620", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8Encoding), Member = "GetBytesUnknown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001623")]
	private bool FallbackInvalidByteSequence(ref Byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref Char* pTarget) { }

	[Address(RVA = "0x13183D0", Offset = "0x13175D0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8Encoding), Member = "GetBytesUnknown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001624")]
	private int FallbackInvalidByteSequence(Byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	[Address(RVA = "0x131BAF0", Offset = "0x131ACF0", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600162B")]
	public virtual ReadOnlySpan<Byte> get_Preamble() { }

	[Address(RVA = "0x1318B60", Offset = "0x1317D60", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001611")]
	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x13184A0", Offset = "0x13176A0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001612")]
	public virtual int GetByteCount(string chars) { }

	[Address(RVA = "0x1318D10", Offset = "0x1317F10", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6001613")]
	public virtual int GetByteCount(Char* chars, int count) { }

	[Address(RVA = "0x1318540", Offset = "0x1317740", Length = "0x619")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600161C")]
	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS baseEncoder) { }

	[Address(RVA = "0x1319900", Offset = "0x1318B00", Length = "0x2C5")]
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
	[Token(Token = "0x6001614")]
	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1319BD0", Offset = "0x1318DD0", Length = "0x2C0")]
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
	[Token(Token = "0x6001615")]
	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x13197D0", Offset = "0x13189D0", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6001616")]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1319070", Offset = "0x1318270", Length = "0x759")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001620")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	[Address(RVA = "0x1318E10", Offset = "0x1318010", Length = "0x25D")]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetCharCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "FallbackInvalidByteSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&), typeof(int), typeof(DecoderFallbackBuffer), typeof(Char*&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "FallbackInvalidByteSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(DecoderFallbackBuffer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001625")]
	private Byte[] GetBytesUnknown(ref Byte* pSrc, int ch) { }

	[Address(RVA = "0x131A370", Offset = "0x1319570", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[Token(Token = "0x6001618")]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x1319EA0", Offset = "0x13190A0", Length = "0x4C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF8Encoding), Member = "GetBytesUnknown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001621")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x131A470", Offset = "0x1319670", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001617")]
	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x131A620", Offset = "0x1319820", Length = "0x2C1")]
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
	[Token(Token = "0x6001619")]
	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x131A8F0", Offset = "0x1319AF0", Length = "0x7EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Char*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF8Encoding), Member = "GetBytesUnknown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*&), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001622")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[Address(RVA = "0x131B0E0", Offset = "0x131A2E0", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801878E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x600161A")]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x131B210", Offset = "0x131A410", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DecoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001626")]
	public virtual Decoder GetDecoder() { }

	[Address(RVA = "0x131B270", Offset = "0x131A470", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncoderNLS), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001627")]
	public virtual Encoder GetEncoder() { }

	[Address(RVA = "0x131B2D0", Offset = "0x131A4D0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600162D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x131B340", Offset = "0x131A540", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001628")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x131B480", Offset = "0x131A680", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001629")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x131B5C0", Offset = "0x131A7C0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Token(Token = "0x600162A")]
	public virtual Byte[] GetPreamble() { }

	[Address(RVA = "0x131B650", Offset = "0x131A850", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600161B")]
	public virtual string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x131B800", Offset = "0x131AA00", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600161F")]
	private static bool InRange(int ch, int start, int end) { }

	[Address(RVA = "0x131B810", Offset = "0x131AA10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600161D")]
	private static int PtrDiff(Char* a, Char* b) { }

	[Address(RVA = "0x10A3E40", Offset = "0x10A3040", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600161E")]
	private static int PtrDiff(Byte* a, Byte* b) { }

	[Address(RVA = "0x131B820", Offset = "0x131AA20", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(EncoderFallback))]
	[Calls(Type = typeof(DecoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(DecoderFallback))]
	[Token(Token = "0x6001610")]
	internal virtual void SetDefaultFallbacks() { }

}

