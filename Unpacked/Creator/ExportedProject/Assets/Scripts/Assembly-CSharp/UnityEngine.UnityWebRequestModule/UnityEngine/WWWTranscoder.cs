namespace UnityEngine;

[Token(Token = "0x2000004")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestWWWModule"})]
internal class WWWTranscoder
{
	[Token(Token = "0x4000010")]
	private static Byte[] ucHexChars; //Field offset: 0x0
	[Token(Token = "0x4000011")]
	private static Byte[] lcHexChars; //Field offset: 0x8
	[Token(Token = "0x4000012")]
	private static byte urlEscapeChar; //Field offset: 0x10
	[Token(Token = "0x4000013")]
	private static Byte[] urlSpace; //Field offset: 0x18
	[Token(Token = "0x4000014")]
	private static Byte[] dataSpace; //Field offset: 0x20
	[Token(Token = "0x4000015")]
	private static Byte[] urlForbidden; //Field offset: 0x28
	[Token(Token = "0x4000016")]
	private static byte qpEscapeChar; //Field offset: 0x30
	[Token(Token = "0x4000017")]
	private static Byte[] qpSpace; //Field offset: 0x38
	[Token(Token = "0x4000018")]
	private static Byte[] qpForbidden; //Field offset: 0x40

	[Address(RVA = "0x1CFE950", Offset = "0x1CFDB50", Length = "0x31D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600001C")]
	private static WWWTranscoder() { }

	[Address(RVA = "0x1CFDC40", Offset = "0x1CFCE40", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000011")]
	private static void Byte2Hex(byte b, Byte[] hexChars, out byte byte0, out byte byte1) { }

	[Address(RVA = "0x1CFDC80", Offset = "0x1CFCE80", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000016")]
	private static bool ByteArrayContains(Byte[] array, byte b) { }

	[Address(RVA = "0x1CFDCD0", Offset = "0x1CFCED0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000018")]
	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	[Address(RVA = "0x1CFDD70", Offset = "0x1CFCF70", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000013")]
	public static Byte[] DataEncode(Byte[] toEncode) { }

	[Address(RVA = "0x1CFDDF0", Offset = "0x1CFCFF0", Length = "0x344")]
	[CalledBy(Type = typeof(WebRequestUtils), Member = "URLDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(WWWTranscoder), Member = "URLDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000019")]
	public static Byte[] Decode(Byte[] input, byte escapeChar, Byte[] space) { }

	[Address(RVA = "0x1CFE140", Offset = "0x1CFD340", Length = "0x418")]
	[CalledBy(Type = typeof(WWWForm), Member = "get_data", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(WWWTranscoder), Member = "URLEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(WWWTranscoder), Member = "DataEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(WWWTranscoder), Member = "QPEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "EscapeURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "EscapeURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000015")]
	public static Byte[] Encode(Byte[] input, byte escapeChar, Byte[] space, Byte[] forbidden, bool uppercase) { }

	[Address(RVA = "0x1CFE560", Offset = "0x1CFD760", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000010")]
	private static byte Hex2Byte(Byte[] b, int offset) { }

	[Address(RVA = "0x1CFE5F0", Offset = "0x1CFD7F0", Length = "0x105")]
	[CalledBy(Type = typeof(WWWForm), Member = "get_data", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000014")]
	public static string QPEncode(string toEncode, Encoding e) { }

	[Address(RVA = "0x1CFE730", Offset = "0x1CFD930", Length = "0x12A")]
	[CalledBy(Type = typeof(WWWForm), Member = "get_data", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001A")]
	public static bool SevenBitClean(string s, Encoding e) { }

	[Address(RVA = "0x1CFE700", Offset = "0x1CFD900", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600001B")]
	public static bool SevenBitClean(Byte* input, int inputLength) { }

	[Address(RVA = "0x1CFE860", Offset = "0x1CFDA60", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WWWTranscoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000017")]
	public static Byte[] URLDecode(Byte[] toEncode) { }

	[Address(RVA = "0x1CFE8D0", Offset = "0x1CFDAD0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000012")]
	public static Byte[] URLEncode(Byte[] toEncode) { }

}

