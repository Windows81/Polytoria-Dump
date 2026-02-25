namespace System;

[ComVisible(True)]
[Token(Token = "0x200019A")]
public static class Environment
{
	[ComVisible(True)]
	[Token(Token = "0x200019B")]
	internal enum SpecialFolder
	{
		MyDocuments = 5,
		Desktop = 0,
		MyComputer = 17,
		Programs = 2,
		Personal = 5,
		Favorites = 6,
		Startup = 7,
		Recent = 8,
		SendTo = 9,
		StartMenu = 11,
		MyMusic = 13,
		DesktopDirectory = 16,
		Templates = 21,
		ApplicationData = 26,
		LocalApplicationData = 28,
		InternetCache = 32,
		Cookies = 33,
		History = 34,
		CommonApplicationData = 35,
		System = 37,
		ProgramFiles = 38,
		MyPictures = 39,
		CommonProgramFiles = 43,
		MyVideos = 14,
		NetworkShortcuts = 19,
		Fonts = 20,
		CommonStartMenu = 22,
		CommonPrograms = 23,
		CommonStartup = 24,
		CommonDesktopDirectory = 25,
		PrinterShortcuts = 27,
		Windows = 36,
		UserProfile = 40,
		SystemX86 = 41,
		ProgramFilesX86 = 42,
		CommonProgramFilesX86 = 44,
		CommonTemplates = 45,
		CommonDocuments = 46,
		CommonAdminTools = 47,
		AdminTools = 48,
		CommonMusic = 53,
		CommonPictures = 54,
		CommonVideos = 55,
		Resources = 56,
		LocalizedResources = 57,
		CommonOemLinks = 58,
		CDBurning = 59,
	}

	[Token(Token = "0x200019C")]
	internal enum SpecialFolderOption
	{
		None = 0,
		DoNotVerify = 16384,
		Create = 32768,
	}

	[Token(Token = "0x4000695")]
	private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789"; //Field offset: 0x0
	[Token(Token = "0x4000696")]
	private static string nl; //Field offset: 0x0
	[Token(Token = "0x4000697")]
	private static OperatingSystem os; //Field offset: 0x8

	[Token(Token = "0x17000147")]
	public static string CommandLine
	{
		[Address(RVA = "0x14F6260", Offset = "0x14F5460", Length = "0x22F")]
		[CalledBy(Type = "Edgegap.RelayCredentialsFromArgs", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A620")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000ECF")]
		 get { } //Length: 559
	}

	[Token(Token = "0x17000148")]
	public static string CurrentDirectory
	{
		[Address(RVA = "0x14F6490", Offset = "0x14F5690", Length = "0x7")]
		[CalledBy(Type = typeof(Directory), Member = "GetCurrentDirectory", ReturnType = typeof(string))]
		[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.IO.FileSystemWatcher", Member = "get_FullPath", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
		[Token(Token = "0x6000ED0")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000149")]
	public static int CurrentManagedThreadId
	{
		[Address(RVA = "0x364370", Offset = "0x363570", Length = "0x23")]
		[CallerCount(Count = 179)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED1")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700014A")]
	public static bool HasShutdownStarted
	{
		[Address(RVA = "0x14F64A0", Offset = "0x14F56A0", Length = "0x5")]
		[CalledBy(Type = typeof(Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BA70")]
		[Token(Token = "0x6000ED2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000154")]
	public static bool Is64BitOperatingSystem
	{
		[Address(RVA = "0x13B9D60", Offset = "0x13B8F60", Length = "0x5")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EEF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000155")]
	public static bool Is64BitProcess
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF0")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000157")]
	internal static bool IsRunningOnWindows
	{
		[Address(RVA = "0x14F64B0", Offset = "0x14F56B0", Length = "0x14")]
		[CalledBy(Type = typeof(Marshal), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Path), Member = "GetInvalidFileNameChars", ReturnType = typeof(Char[]))]
		[CalledBy(Type = typeof(Path), Member = "GetInvalidPathChars", ReturnType = typeof(Char[]))]
		[CalledBy(Type = typeof(Path), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EF2")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x17000158")]
	internal static bool IsUnix
	{
		[Address(RVA = "0x14F64D0", Offset = "0x14F56D0", Length = "0x27")]
		[CalledBy(Type = typeof(WindowsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(WindowsAccountType), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
		[CalledBy(Type = typeof(WindowsIdentity), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EF7")]
		internal get { } //Length: 39
	}

	[Token(Token = "0x1700014B")]
	public static string MachineName
	{
		[Address(RVA = "0x14F6500", Offset = "0x14F5700", Length = "0x5")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BA80")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ED3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014C")]
	public static string NewLine
	{
		[Address(RVA = "0x14F6510", Offset = "0x14F5710", Length = "0x76")]
		[CallerCount(Count = 67)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AB10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000ED5")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700014E")]
	public static OperatingSystem OSVersion
	{
		[Address(RVA = "0x14F6590", Offset = "0x14F5790", Length = "0x29E")]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "get_IsWindows", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Path), Member = "get_IsWindows", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Path), Member = "get_IsCaseSensitive", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Path), Member = "GetRelativePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Path), Member = "get_StringComparison", ReturnType = typeof(StringComparison))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "IsUserProtected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "CanSecure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(KeyPairPersistence), Member = "IsMachineProtected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
		[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AB40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000ED8")]
		 get { } //Length: 670
	}

	[Token(Token = "0x1700014D")]
	internal static PlatformID Platform
	{
		[Address(RVA = "0x14F6830", Offset = "0x14F5A30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
		[CompilerGenerated]
		[Token(Token = "0x6000ED6")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000156")]
	public static int ProcessorCount
	{
		[Address(RVA = "0x14F6840", Offset = "0x14F5A40", Length = "0x5")]
		[CalledBy(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ThreadPoolGlobals), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BB10")]
		[Token(Token = "0x6000EF1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014F")]
	public static string StackTrace
	{
		[Address(RVA = "0x14F6850", Offset = "0x14F5A50", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000EDA")]
		 get { } //Length: 103
	}

	[Token(Token = "0x17000150")]
	public static string SystemDirectory
	{
		[Address(RVA = "0x14F68C0", Offset = "0x14F5AC0", Length = "0x24A")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BDF0")]
		[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AC10")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6000EDB")]
		 get { } //Length: 586
	}

	[Token(Token = "0x17000151")]
	public static int TickCount
	{
		[Address(RVA = "0x14F6B10", Offset = "0x14F5D10", Length = "0x5")]
		[CallerCount(Count = 51)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BB20")]
		[Token(Token = "0x6000EDC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000152")]
	public static string UserDomainName
	{
		[Address(RVA = "0x14F6500", Offset = "0x14F5700", Length = "0x5")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BA80")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EDD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000153")]
	public static string UserName
	{
		[Address(RVA = "0x14F6B20", Offset = "0x14F5D20", Length = "0x5")]
		[CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BB30")]
		[Token(Token = "0x6000EDE")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x14F4EE0", Offset = "0x14F40E0", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000ED9")]
	internal static Version CreateVersionFromString(string info) { }

	[Address(RVA = "0x14F5090", Offset = "0x14F4290", Length = "0x5")]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "OS_ExitFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A550")]
	[Token(Token = "0x6000EDF")]
	public static void Exit(int exitCode) { }

	[Address(RVA = "0x14F50A0", Offset = "0x14F42A0", Length = "0x3EB")]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValueCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A710")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IHashCodeProvider), typeof(IComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CaseInsensitiveComparer), Member = "get_Default", ReturnType = typeof(CaseInsensitiveComparer))]
	[Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = "get_Default", ReturnType = typeof(CaseInsensitiveHashCodeProvider))]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000EE0")]
	public static string ExpandEnvironmentVariables(string name) { }

	[Address(RVA = "0x14F54A0", Offset = "0x14F46A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A570")]
	[Token(Token = "0x6000EED")]
	internal static void FailFast(string message, Exception exception, string errorSource) { }

	[Address(RVA = "0x14F5490", Offset = "0x14F4690", Length = "0x8")]
	[CalledBy(Type = typeof(ExecutionContext), Member = "OnAsyncLocalContextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ExecutionContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A570")]
	[Token(Token = "0x6000EEC")]
	public static void FailFast(string message, Exception exception) { }

	[Address(RVA = "0x14F6260", Offset = "0x14F5460", Length = "0x22F")]
	[CalledBy(Type = "Edgegap.RelayCredentialsFromArgs", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A620")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ECF")]
	public static string get_CommandLine() { }

	[Address(RVA = "0x14F6490", Offset = "0x14F5690", Length = "0x7")]
	[CalledBy(Type = typeof(Directory), Member = "GetCurrentDirectory", ReturnType = typeof(string))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.FileSystemWatcher", Member = "get_FullPath", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
	[Token(Token = "0x6000ED0")]
	public static string get_CurrentDirectory() { }

	[Address(RVA = "0x364370", Offset = "0x363570", Length = "0x23")]
	[CallerCount(Count = 179)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED1")]
	public static int get_CurrentManagedThreadId() { }

	[Address(RVA = "0x14F64A0", Offset = "0x14F56A0", Length = "0x5")]
	[CalledBy(Type = typeof(Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BA70")]
	[Token(Token = "0x6000ED2")]
	public static bool get_HasShutdownStarted() { }

	[Address(RVA = "0x13B9D60", Offset = "0x13B8F60", Length = "0x5")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EEF")]
	public static bool get_Is64BitOperatingSystem() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EF0")]
	public static bool get_Is64BitProcess() { }

	[Address(RVA = "0x14F64B0", Offset = "0x14F56B0", Length = "0x14")]
	[CalledBy(Type = typeof(Marshal), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Path), Member = "InsecureGetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Path), Member = "GetInvalidFileNameChars", ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Path), Member = "GetInvalidPathChars", ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Path), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Path), Member = "CanonicalizePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EF2")]
	internal static bool get_IsRunningOnWindows() { }

	[Address(RVA = "0x14F64D0", Offset = "0x14F56D0", Length = "0x27")]
	[CalledBy(Type = typeof(WindowsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(WindowsAccountType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
	[CalledBy(Type = typeof(WindowsIdentity), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EF7")]
	internal static bool get_IsUnix() { }

	[Address(RVA = "0x14F6500", Offset = "0x14F5700", Length = "0x5")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BA80")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ED3")]
	public static string get_MachineName() { }

	[Address(RVA = "0x14F6510", Offset = "0x14F5710", Length = "0x76")]
	[CallerCount(Count = 67)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AB10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000ED5")]
	public static string get_NewLine() { }

	[Address(RVA = "0x14F6590", Offset = "0x14F5790", Length = "0x29E")]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "CanSecure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "ProtectMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "IsUserProtected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Path), Member = "get_StringComparison", ReturnType = typeof(StringComparison))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "IsMachineProtected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Path), Member = "get_IsCaseSensitive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Path), Member = "get_IsWindows", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "get_IsWindows", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Path), Member = "GetRelativePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AB40")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000ED8")]
	public static OperatingSystem get_OSVersion() { }

	[Address(RVA = "0x14F6830", Offset = "0x14F5A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[CompilerGenerated]
	[Token(Token = "0x6000ED6")]
	internal static PlatformID get_Platform() { }

	[Address(RVA = "0x14F6840", Offset = "0x14F5A40", Length = "0x5")]
	[CalledBy(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ThreadPoolGlobals), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BB10")]
	[Token(Token = "0x6000EF1")]
	public static int get_ProcessorCount() { }

	[Address(RVA = "0x14F6850", Offset = "0x14F5A50", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EDA")]
	public static string get_StackTrace() { }

	[Address(RVA = "0x14F68C0", Offset = "0x14F5AC0", Length = "0x24A")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BDF0")]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AC10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000EDB")]
	public static string get_SystemDirectory() { }

	[Address(RVA = "0x14F6B10", Offset = "0x14F5D10", Length = "0x5")]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BB20")]
	[Token(Token = "0x6000EDC")]
	public static int get_TickCount() { }

	[Address(RVA = "0x14F6500", Offset = "0x14F5700", Length = "0x5")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BA80")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EDD")]
	public static string get_UserDomainName() { }

	[Address(RVA = "0x14F6B20", Offset = "0x14F5D20", Length = "0x5")]
	[CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.Protocol.Ntlm.Type2Message"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BB30")]
	[Token(Token = "0x6000EDE")]
	public static string get_UserName() { }

	[Address(RVA = "0x14F54B0", Offset = "0x14F46B0", Length = "0x5")]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.LaunchController", Member = "GetCommandLineArgs", ReturnType = "System.Collections.Generic.Dictionary`2<String, String>")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "GetCommandLineArgs", ReturnType = "System.Collections.Generic.Dictionary`2<String, String>")]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A620")]
	[Token(Token = "0x6000EE1")]
	public static String[] GetCommandLineArgs() { }

	[Address(RVA = "0x14F54D0", Offset = "0x14F46D0", Length = "0x7")]
	[CalledBy(Type = typeof(MonoIO), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "CreateDefaultProviderImpl", ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[CalledBy(Type = "System.Uri", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.FileSystemWatcher", Member = "InitWatcher", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Utilities.Platform", Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.REPL.ReplInterpreterScriptLoader", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000EE4")]
	public static string GetEnvironmentVariable(string variable) { }

	[Address(RVA = "0x14F54C0", Offset = "0x14F46C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A710")]
	[Token(Token = "0x6000EF3")]
	private static String[] GetEnvironmentVariableNames() { }

	[Address(RVA = "0x14F55D0", Offset = "0x14F47D0", Length = "0xCE")]
	[CalledBy(Type = "System.Diagnostics.ProcessStartInfo", Member = "get_EnvironmentVariables", ReturnType = "System.Collections.Specialized.StringDictionary")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A710")]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EE6")]
	public static IDictionary GetEnvironmentVariables() { }

	[Address(RVA = "0x14F54E0", Offset = "0x14F46E0", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = "get_Default", ReturnType = typeof(CaseInsensitiveHashCodeProvider))]
	[Calls(Type = typeof(CaseInsensitiveComparer), Member = "get_Default", ReturnType = typeof(CaseInsensitiveComparer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IHashCodeProvider), typeof(IComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A710")]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EE5")]
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	[Address(RVA = "0x14F56A0", Offset = "0x14F48A0", Length = "0x35")]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "InitializeQuickLinks", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_TrustedRootCertificates", ReturnType = "Mono.Security.X509.X509CertificateCollection")]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_LocalMachine", ReturnType = "Mono.Security.X509.X509Stores")]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_CurrentUser", ReturnType = "Mono.Security.X509.X509Stores")]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_LocalMachinePath", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<AutoSaveLoop>d__85", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoScreenshot>d__24", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_CurrentUserPath", ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AC10")]
	[Calls(Type = typeof(Environment), Member = "UnixGetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EE7")]
	public static string GetFolderPath(SpecialFolder folder) { }

	[Address(RVA = "0x14F56E0", Offset = "0x14F48E0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18003CC40")]
	[Calls(Type = typeof(Environment), Member = "UnixGetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AC10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EE9")]
	public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option) { }

	[Address(RVA = "0x13B9D60", Offset = "0x13B8F60", Length = "0x5")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EEE")]
	private static bool GetIs64BitOperatingSystem() { }

	[Address(RVA = "0x14F5730", Offset = "0x14F4930", Length = "0x5")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A7D0")]
	[Token(Token = "0x6000EF4")]
	internal static string GetMachineConfigPath() { }

	[Address(RVA = "0x14F5740", Offset = "0x14F4940", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AB10")]
	[Token(Token = "0x6000ED4")]
	private static string GetNewLine() { }

	[Address(RVA = "0x14F5750", Offset = "0x14F4950", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AB40")]
	[Token(Token = "0x6000ED7")]
	internal static string GetOSVersionString() { }

	[Address(RVA = "0x14F5760", Offset = "0x14F4960", Length = "0x5")]
	[CalledBy(Type = typeof(Thread), Member = "SetStartHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = "GetProcessDefaultStackSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020ABD0")]
	[Token(Token = "0x6000EF6")]
	internal static int GetPageSize() { }

	[Address(RVA = "0x14F58C0", Offset = "0x14F4AC0", Length = "0x63")]
	[CallerCount(Count = 151)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Token(Token = "0x6000ECD")]
	internal static string GetResourceString(string key, Object[] values) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ECC")]
	internal static string GetResourceString(string key) { }

	[Address(RVA = "0x14F5770", Offset = "0x14F4970", Length = "0x149")]
	[CalledBy(Type = typeof(Encoding), Member = "get_EncodingName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000ECE")]
	internal static string GetResourceStringEncodingName(int codePage) { }

	[Address(RVA = "0x14F5930", Offset = "0x14F4B30", Length = "0x8B")]
	[CalledBy(Type = typeof(Exception), Member = "get_StackTrace", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Exception), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Exception), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EF8")]
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }

	[Address(RVA = "0x14F59C0", Offset = "0x14F4BC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AC10")]
	[Token(Token = "0x6000EE8")]
	private static string GetWindowsFolderPath(int folder) { }

	[Address(RVA = "0x14F6B30", Offset = "0x14F5D30", Length = "0x9C")]
	[CalledBy(Type = typeof(ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Environment), Member = "get_SystemDirectory", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "GetEnvironmentVariablesNoCase", ReturnType = typeof(Hashtable))]
	[CalledBy(Type = typeof(Environment), Member = "GetEnvironmentVariables", ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(Environment), Member = "ReadXdgUserDir", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "UnixGetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "SearchTerminfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "get_UseManagedCollation", ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BCB0")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeMarshal), Member = "MarshalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SafeStringMarshal))]
	[Token(Token = "0x6000EE3")]
	internal static string internalGetEnvironmentVariable(string variable) { }

	[Address(RVA = "0x14F6BD0", Offset = "0x14F5DD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BCB0")]
	[Token(Token = "0x6000EE2")]
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	[Address(RVA = "0x14F6BE0", Offset = "0x14F5DE0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BDF0")]
	[Token(Token = "0x6000EF5")]
	internal static string internalGetHome() { }

	[Address(RVA = "0x14F59D0", Offset = "0x14F4BD0", Length = "0x32C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "StartsWithOrdinalUnchecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000EEA")]
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	[Address(RVA = "0x14F5D00", Offset = "0x14F4F00", Length = "0x240")]
	[CalledBy(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder), typeof(SpecialFolderOption)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020BDF0")]
	[Calls(Type = typeof(Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000EEB")]
	internal static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option) { }

}

