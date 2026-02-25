namespace System;

[Token(Token = "0x20001A4")]
internal static class ConsoleDriver
{
	[Token(Token = "0x40006F5")]
	internal static IConsoleDriver driver; //Field offset: 0x0
	[Token(Token = "0x40006F6")]
	private static bool is_console; //Field offset: 0x8
	[Token(Token = "0x40006F7")]
	private static bool called_isatty; //Field offset: 0x9

	[Token(Token = "0x1700015D")]
	public static ConsoleColor ForegroundColor
	{
		[Address(RVA = "0x14F08F0", Offset = "0x14EFAF0", Length = "0x145")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F20")]
		 set { } //Length: 325
	}

	[Token(Token = "0x1700015E")]
	public static bool IsConsole
	{
		[Address(RVA = "0x14F0790", Offset = "0x14EF990", Length = "0x15A")]
		[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B550")]
		[Calls(Type = typeof(MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
		[Token(Token = "0x6000F23")]
		 get { } //Length: 346
	}

	[Address(RVA = "0x14F06B0", Offset = "0x14EF8B0", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ConsoleDriver), Member = "CreateTermInfoDriver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IConsoleDriver))]
	[Calls(Type = typeof(ConsoleDriver), Member = "CreateNullConsoleDriver", ReturnType = typeof(IConsoleDriver))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConsoleDriver), Member = "CreateWindowsConsoleDriver", ReturnType = typeof(IConsoleDriver))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F1C")]
	private static ConsoleDriver() { }

	[Address(RVA = "0x14F0400", Offset = "0x14EF600", Length = "0x30")]
	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6000F1D")]
	private static IConsoleDriver CreateNullConsoleDriver() { }

	[Address(RVA = "0x14F0430", Offset = "0x14EF630", Length = "0x54")]
	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F1F")]
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	[Address(RVA = "0x14F0490", Offset = "0x14EF690", Length = "0x44")]
	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WindowsConsoleDriver), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000F1E")]
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	[Address(RVA = "0x14F0790", Offset = "0x14EF990", Length = "0x15A")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B550")]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6000F23")]
	public static bool get_IsConsole() { }

	[Address(RVA = "0x14F04E0", Offset = "0x14EF6E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B460")]
	[Token(Token = "0x6000F25")]
	internal static int InternalKeyAvailable(int ms_timeout) { }

	[Address(RVA = "0x14F04F0", Offset = "0x14EF6F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B550")]
	[Token(Token = "0x6000F24")]
	private static bool Isatty(IntPtr handle) { }

	[Address(RVA = "0x14F0500", Offset = "0x14EF700", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F21")]
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	[Address(RVA = "0x14F0610", Offset = "0x14EF810", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F22")]
	public static void ResetColor() { }

	[Address(RVA = "0x14F08F0", Offset = "0x14EFAF0", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F20")]
	public static void set_ForegroundColor(ConsoleColor value) { }

	[Address(RVA = "0x14F0690", Offset = "0x14EF890", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B5F0")]
	[Token(Token = "0x6000F27")]
	internal static bool SetEcho(bool wantEcho) { }

	[Address(RVA = "0x14F06A0", Offset = "0x14EF8A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B6B0")]
	[Token(Token = "0x6000F26")]
	internal static bool TtySetup(string keypadXmit, string teardown, out Byte[] control_characters, out Int32* address) { }

}

