namespace System.Text;

[Token(Token = "0x20002A6")]
internal class Latin1Encoding : EncodingNLS, ISerializable
{
	[Token(Token = "0x4000BA2")]
	internal static readonly Latin1Encoding s_default; //Field offset: 0x0
	[Token(Token = "0x4000BA3")]
	private static readonly Char[] arrayCharBestFit; //Field offset: 0x8

	[Address(RVA = "0x130DC90", Offset = "0x130CE90", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001579")]
	private static Latin1Encoding() { }

	[Address(RVA = "0x130DDC0", Offset = "0x130CFC0", Length = "0xD")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Encoding), Member = "get_Latin1", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600156F")]
	public Latin1Encoding() { }

	[Address(RVA = "0x130DD70", Offset = "0x130CF70", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "DeserializeEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001570")]
	internal Latin1Encoding(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x130D1E0", Offset = "0x130C3E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001578")]
	internal virtual Char[] GetBestFitUnicodeToBytesData() { }

	[Address(RVA = "0x130D230", Offset = "0x130C430", Length = "0x233")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001572")]
	internal virtual int GetByteCount(Char* chars, int charCount, EncoderNLS encoder) { }

	[Address(RVA = "0x130D470", Offset = "0x130C670", Length = "0x424")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001573")]
	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	[Address(RVA = "0x130D8A0", Offset = "0x130CAA0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001574")]
	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS decoder) { }

	[Address(RVA = "0x130D8B0", Offset = "0x130CAB0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001575")]
	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS decoder) { }

	[Address(RVA = "0x130D930", Offset = "0x130CB30", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001576")]
	public virtual int GetMaxByteCount(int charCount) { }

	[Address(RVA = "0x130DA70", Offset = "0x130CC70", Length = "0x13E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001577")]
	public virtual int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x130DBB0", Offset = "0x130CDB0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "SerializeEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001571")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

