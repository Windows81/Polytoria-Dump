namespace System.Text;

[Token(Token = "0x20002BF")]
internal static class EncodingHelper
{
	[Token(Token = "0x4000C0D")]
	private static Encoding utf8EncodingWithoutMarkers; //Field offset: 0x0
	[Token(Token = "0x4000C0E")]
	private static readonly object lockobj; //Field offset: 0x8
	[Token(Token = "0x4000C0F")]
	private static Assembly i18nAssembly; //Field offset: 0x10
	[Token(Token = "0x4000C10")]
	private static bool i18nDisabled; //Field offset: 0x18

	[Token(Token = "0x17000251")]
	internal static Encoding UTF8Unmarked
	{
		[Address(RVA = "0x1326C80", Offset = "0x1325E80", Length = "0x1F7")]
		[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StreamWriter), Member = "get_UTF8NoBOM", ReturnType = typeof(Encoding))]
		[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StreamWriter), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(File), Member = "WriteAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60016E9")]
		internal get { } //Length: 503
	}

	[Address(RVA = "0x1326C00", Offset = "0x1325E00", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016ED")]
	private static EncodingHelper() { }

	[Address(RVA = "0x1326C80", Offset = "0x1325E80", Length = "0x1F7")]
	[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = "get_UTF8NoBOM", ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "WriteAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60016E9")]
	internal static Encoding get_UTF8Unmarked() { }

	[Address(RVA = "0x1326570", Offset = "0x1325770", Length = "0x74")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Encoding), Member = "CreateDefaultEncoding", ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BE80")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60016EB")]
	internal static Encoding GetDefaultEncoding() { }

	[Address(RVA = "0x1326680", Offset = "0x1325880", Length = "0x5")]
	[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BE80")]
	[Token(Token = "0x60016EA")]
	internal static string InternalCodePage(ref int code_page) { }

	[Address(RVA = "0x1326690", Offset = "0x1325890", Length = "0x567")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187E80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60016EC")]
	internal static object InvokeI18N(string name, Object[] args) { }

}

