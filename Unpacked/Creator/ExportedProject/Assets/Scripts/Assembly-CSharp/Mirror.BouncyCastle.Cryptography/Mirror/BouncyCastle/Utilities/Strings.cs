namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x200000D")]
public static class Strings
{

	[Address(RVA = "0x10C3DC0", Offset = "0x10C2FC0", Length = "0x39")]
	[CalledBy(Type = typeof(DerGeneralString), Member = "GetString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerIA5String), Member = "GetString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerNumericString), Member = "GetString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerPrintableString), Member = "GetString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerVisibleString), Member = "GetString", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	public static string FromAsciiByteArray(Byte[] bytes) { }

	[Address(RVA = "0x10C3E00", Offset = "0x10C3000", Length = "0xFB")]
	[CalledBy(Type = typeof(DerGraphicString), Member = "GetString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerT61String), Member = "GetString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DerVideotexString), Member = "GetString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000043")]
	public static string FromByteArray(Byte[] bs) { }

	[Address(RVA = "0x10C3F00", Offset = "0x10C3100", Length = "0x39")]
	[CalledBy(Type = typeof(DerUtf8String), Member = "GetString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	public static string FromUtf8ByteArray(Byte[] bytes) { }

}

