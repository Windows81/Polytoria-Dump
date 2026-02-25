namespace System.Text;

[Token(Token = "0x20002A5")]
public abstract class EncodingProvider
{
	[Token(Token = "0x4000BA0")]
	private static object s_InternalSyncObject; //Field offset: 0x0
	[Token(Token = "0x4000BA1")]
	private static EncodingProvider[] s_providers; //Field offset: 0x8

	[Address(RVA = "0x130D160", Offset = "0x130C360", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600156E")]
	private static EncodingProvider() { }

	[Token(Token = "0x6001568")]
	public abstract Encoding GetEncoding(string name) { }

	[Token(Token = "0x6001569")]
	public abstract Encoding GetEncoding(int codepage) { }

	[Address(RVA = "0x130D040", Offset = "0x130C240", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderFallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "set_DecoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderFallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600156A")]
	public override Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	[Address(RVA = "0x130CE40", Offset = "0x130C040", Length = "0xFA")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600156B")]
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	[Address(RVA = "0x130CF40", Offset = "0x130C140", Length = "0xFC")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600156C")]
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	[Address(RVA = "0x130CD20", Offset = "0x130BF20", Length = "0x11A")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600156D")]
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

}

