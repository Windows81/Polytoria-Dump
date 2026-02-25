namespace System;

[Token(Token = "0x20001A1")]
public static class Console
{
	[Token(Token = "0x20001A2")]
	private class WindowsConsole
	{
		[Token(Token = "0x20001A3")]
		private sealed class WindowsCancelHandler : MulticastDelegate
		{

			[Address(RVA = "0xC46430", Offset = "0xC45630", Length = "0xA6")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F1A")]
			public WindowsCancelHandler(object object, IntPtr method) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F1B")]
			public override bool Invoke(int keyCode) { }

		}

		[Token(Token = "0x40006F3")]
		public static bool ctrlHandlerAdded; //Field offset: 0x0
		[Token(Token = "0x40006F4")]
		private static WindowsCancelHandler cancelHandler; //Field offset: 0x8

		[Address(RVA = "0x1507F30", Offset = "0x1507130", Length = "0x74B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
		[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
		[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Dequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueueThreadLocals), typeof(IThreadPoolWorkItem&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D670")]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "set_Waiters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
		[Calls(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = "System.Decimal+DecCalc", Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), "System.Decimal+DecCalc+RoundingMode"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F19")]
		private static WindowsConsole() { }

		[Address(RVA = "0x1507CC0", Offset = "0x1506EC0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Console), Member = "DoConsoleCancelEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F16")]
		private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

		[Address(RVA = "0x1507D10", Offset = "0x1506F10", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F14")]
		private static int GetConsoleCP() { }

		[Address(RVA = "0x1507D80", Offset = "0x1506F80", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F15")]
		private static int GetConsoleOutputCP() { }

		[Address(RVA = "0x1507DF0", Offset = "0x1506FF0", Length = "0x97")]
		[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F17")]
		public static int GetInputCodePage() { }

		[Address(RVA = "0x1507E90", Offset = "0x1507090", Length = "0x97")]
		[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F18")]
		public static int GetOutputCodePage() { }

	}

	[Token(Token = "0x40006EC")]
	internal static TextWriter stdout; //Field offset: 0x0
	[Token(Token = "0x40006ED")]
	private static TextWriter stderr; //Field offset: 0x8
	[Token(Token = "0x40006EE")]
	private static TextReader stdin; //Field offset: 0x10
	[Token(Token = "0x40006EF")]
	internal static bool IsRunningOnAndroid; //Field offset: 0x18
	[Token(Token = "0x40006F0")]
	private static Encoding inputEncoding; //Field offset: 0x20
	[Token(Token = "0x40006F1")]
	private static Encoding outputEncoding; //Field offset: 0x28
	[Token(Token = "0x40006F2")]
	private static ConsoleCancelEventHandler cancel_event; //Field offset: 0x30

	[Token(Token = "0x17000159")]
	public static TextWriter Error
	{
		[Address(RVA = "0x14F1CE0", Offset = "0x14F0EE0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000F00")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700015C")]
	public static ConsoleColor ForegroundColor
	{
		[Address(RVA = "0x14F1DD0", Offset = "0x14F0FD0", Length = "0x175")]
		[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.MultiplexTransport", Member = "ServerStart", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.MultiplexTransport", Member = "set_Port", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mirror.TransportError", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ConsoleColor)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Verbose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkServer", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Warn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F0F")]
		 set { } //Length: 373
	}

	[Token(Token = "0x1700015A")]
	public static Encoding InputEncoding
	{
		[Address(RVA = "0x14F1D30", Offset = "0x14F0F30", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000F0D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700015B")]
	public static Encoding OutputEncoding
	{
		[Address(RVA = "0x14F1D80", Offset = "0x14F0F80", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000F0E")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x14F1A60", Offset = "0x14F0C60", Length = "0x280")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncodingHelper), Member = "InternalCodePage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(WindowsConsole), Member = "GetOutputCodePage", ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(WindowsConsole), Member = "GetInputCodePage", ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EncodingHelper), Member = "get_UTF8Unmarked", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EFE")]
	private static Console() { }

	[Address(RVA = "0x14F0A40", Offset = "0x14EFC40", Length = "0x17C")]
	[CalledBy(Type = typeof(WindowsConsole), Member = "DoWindowsConsoleCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConsoleCancelEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleSpecialKey)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F13")]
	private static void DoConsoleCancelEvent() { }

	[Address(RVA = "0x14F1CE0", Offset = "0x14F0EE0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000F00")]
	public static TextWriter get_Error() { }

	[Address(RVA = "0x14F1D30", Offset = "0x14F0F30", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000F0D")]
	public static Encoding get_InputEncoding() { }

	[Address(RVA = "0x14F1D80", Offset = "0x14F0F80", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000F0E")]
	public static Encoding get_OutputEncoding() { }

	[Address(RVA = "0x14F0E60", Offset = "0x14F0060", Length = "0xEA")]
	[CalledBy(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000F01")]
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	[Address(RVA = "0x14F0C50", Offset = "0x14EFE50", Length = "0x42")]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "IO_GetStandardStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Platforms.StandardFileType"}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Token(Token = "0x6000F02")]
	public static Stream OpenStandardError() { }

	[Address(RVA = "0x14F0BC0", Offset = "0x14EFDC0", Length = "0x85")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Console), Member = "OpenStandardError", ReturnType = typeof(Stream))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleError", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Console), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(int)}, ReturnType = typeof(Stream))]
	[Token(Token = "0x6000F03")]
	public static Stream OpenStandardError(int bufferSize) { }

	[Address(RVA = "0x14F0CA0", Offset = "0x14EFEA0", Length = "0x42")]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "IO_GetStandardStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Platforms.StandardFileType"}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000F04")]
	public static Stream OpenStandardInput() { }

	[Address(RVA = "0x14F0CF0", Offset = "0x14EFEF0", Length = "0x85")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Console), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(int)}, ReturnType = typeof(Stream))]
	[Token(Token = "0x6000F05")]
	public static Stream OpenStandardInput(int bufferSize) { }

	[Address(RVA = "0x14F0D80", Offset = "0x14EFF80", Length = "0x42")]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "IO_GetStandardStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Platforms.StandardFileType"}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000F06")]
	public static Stream OpenStandardOutput() { }

	[Address(RVA = "0x14F0DD0", Offset = "0x14EFFD0", Length = "0x85")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoIO), Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000F07")]
	public static Stream OpenStandardOutput(int bufferSize) { }

	[Address(RVA = "0x14F0F50", Offset = "0x14F0150", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F11")]
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	[Address(RVA = "0x14F1090", Offset = "0x14F0290", Length = "0x169")]
	[CalledBy(Type = typeof(CStreamReader), Member = "Read", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F10")]
	public static ConsoleKeyInfo ReadKey() { }

	[Address(RVA = "0x14F1200", Offset = "0x14F0400", Length = "0xA2")]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkServer", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Verbose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Warn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mirror.TransportError", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport", Member = "set_Port", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport", Member = "ServerStart", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000F12")]
	public static void ResetColor() { }

	[Address(RVA = "0x14F1DD0", Offset = "0x14F0FD0", Length = "0x175")]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Warn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Verbose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mirror.TransportError", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkServer", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport", Member = "set_Port", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport", Member = "ServerStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0F")]
	public static void set_ForegroundColor(ConsoleColor value) { }

	[Address(RVA = "0x14F12B0", Offset = "0x14F04B0", Length = "0xE6")]
	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F08")]
	public static void SetError(TextWriter newError) { }

	[Address(RVA = "0x14F13A0", Offset = "0x14F05A0", Length = "0xE1")]
	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F09")]
	public static void SetOut(TextWriter newOut) { }

	[Address(RVA = "0x14F1490", Offset = "0x14F0690", Length = "0x43C")]
	[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CStreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextReader), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(TextReader))]
	[Calls(Type = typeof(UnexceptionalStreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[Calls(Type = typeof(CStreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "OpenStandardOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnexceptionalStreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[Calls(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000EFF")]
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	[Address(RVA = "0x14F19E0", Offset = "0x14F0BE0", Length = "0x74")]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler", Member = "Print", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0A")]
	public static void Write(object value) { }

	[Address(RVA = "0x14F18D0", Offset = "0x14F0AD0", Length = "0x74")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport", Member = "ServerStart", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport", Member = "set_Port", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mirror.TransportError", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MultiplexTransport+<>c__DisplayClass26_0", Member = "<AddServerCallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Verbose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkServer", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "DefaultPrint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.Log", Member = "Warn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0B")]
	public static void WriteLine(string value) { }

	[Address(RVA = "0x14F1950", Offset = "0x14F0B50", Length = "0x83")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509LookupMono", Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "MoonSharp.Interpreter.Loaders.UnityAssetsScriptLoader", Member = "LoadResourcesWithReflection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F0C")]
	public static void WriteLine(string format, object arg0) { }

}

