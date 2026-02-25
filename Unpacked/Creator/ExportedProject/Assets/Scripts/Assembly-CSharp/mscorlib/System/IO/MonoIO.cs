namespace System.IO;

[Token(Token = "0x200065D")]
internal static class MonoIO
{
	[Token(Token = "0x40019E2")]
	public static readonly IntPtr InvalidHandle; //Field offset: 0x0
	[Token(Token = "0x40019E3")]
	private static bool dump_handles; //Field offset: 0x8

	[Token(Token = "0x1700074C")]
	public static char AltDirectorySeparatorChar
	{
		[Address(RVA = "0x1478500", Offset = "0x1477700", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802133D0")]
		[Token(Token = "0x6002F4D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000749")]
	public static IntPtr ConsoleError
	{
		[Address(RVA = "0x1478510", Offset = "0x1477710", Length = "0x5")]
		[CalledBy(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802133E0")]
		[Token(Token = "0x6002F48")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000748")]
	public static IntPtr ConsoleInput
	{
		[Address(RVA = "0x1478520", Offset = "0x1477720", Length = "0x5")]
		[CalledBy(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802133F0")]
		[Token(Token = "0x6002F47")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000747")]
	public static IntPtr ConsoleOutput
	{
		[Address(RVA = "0x1478530", Offset = "0x1477730", Length = "0x5")]
		[CalledBy(Type = typeof(Console), Member = "OpenStandardOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213400")]
		[Token(Token = "0x6002F46")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700074B")]
	public static char DirectorySeparatorChar
	{
		[Address(RVA = "0x1478540", Offset = "0x1477740", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213410")]
		[Token(Token = "0x6002F4C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700074D")]
	public static char PathSeparator
	{
		[Address(RVA = "0x1478550", Offset = "0x1477750", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213420")]
		[Token(Token = "0x6002F4E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700074A")]
	public static char VolumeSeparatorChar
	{
		[Address(RVA = "0x1478560", Offset = "0x1477760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213430")]
		[Token(Token = "0x6002F4B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1478480", Offset = "0x1477680", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002F51")]
	private static MonoIO() { }

	[Address(RVA = "0x1477300", Offset = "0x1476500", Length = "0x111")]
	[CalledBy(Type = "System.Diagnostics.AsyncStreamReader", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212510")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F3A")]
	internal static bool Cancel(SafeHandle safeHandle, out MonoIOError error) { }

	[Address(RVA = "0x14772F0", Offset = "0x14764F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212510")]
	[Token(Token = "0x6002F39")]
	private static bool Cancel_internal(IntPtr handle, out MonoIOError error) { }

	[Address(RVA = "0x1477420", Offset = "0x1476620", Length = "0x5")]
	[CalledBy(Type = typeof(SafeFileHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212520")]
	[Token(Token = "0x6002F3B")]
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	[Address(RVA = "0x1477430", Offset = "0x1476630", Length = "0x5")]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212760")]
	[Token(Token = "0x6002F49")]
	public static bool CreatePipe(out IntPtr read_handle, out IntPtr write_handle, out MonoIOError error) { }

	[Address(RVA = "0x13E7660", Offset = "0x13E6860", Length = "0x5")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F4F")]
	private static void DumpHandles() { }

	[Address(RVA = "0x1477440", Offset = "0x1476640", Length = "0x5")]
	[CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HandleRef), typeof(HandleRef), typeof(HandleRef), "Microsoft.Win32.SafeHandles.SafeProcessHandle&", typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802127D0")]
	[Token(Token = "0x6002F4A")]
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	[Address(RVA = "0x1477450", Offset = "0x1476650", Length = "0x5")]
	[CalledBy(Type = typeof(SafeFindHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212890")]
	[Token(Token = "0x6002F36")]
	public static bool FindCloseFile(IntPtr hnd) { }

	[Address(RVA = "0x1478500", Offset = "0x1477700", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802133D0")]
	[Token(Token = "0x6002F4D")]
	public static char get_AltDirectorySeparatorChar() { }

	[Address(RVA = "0x1478510", Offset = "0x1477710", Length = "0x5")]
	[CalledBy(Type = typeof(Console), Member = "OpenStandardError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802133E0")]
	[Token(Token = "0x6002F48")]
	public static IntPtr get_ConsoleError() { }

	[Address(RVA = "0x1478520", Offset = "0x1477720", Length = "0x5")]
	[CalledBy(Type = typeof(Console), Member = "OpenStandardInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802133F0")]
	[Token(Token = "0x6002F47")]
	public static IntPtr get_ConsoleInput() { }

	[Address(RVA = "0x1478530", Offset = "0x1477730", Length = "0x5")]
	[CalledBy(Type = typeof(Console), Member = "OpenStandardOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = typeof(ConsoleDriver), Member = "get_IsConsole", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213400")]
	[Token(Token = "0x6002F46")]
	public static IntPtr get_ConsoleOutput() { }

	[Address(RVA = "0x1478540", Offset = "0x1477740", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213410")]
	[Token(Token = "0x6002F4C")]
	public static char get_DirectorySeparatorChar() { }

	[Address(RVA = "0x1478550", Offset = "0x1477750", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213420")]
	[Token(Token = "0x6002F4E")]
	public static char get_PathSeparator() { }

	[Address(RVA = "0x1478560", Offset = "0x1477760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213430")]
	[Token(Token = "0x6002F4B")]
	public static char get_VolumeSeparatorChar() { }

	[Address(RVA = "0x1477460", Offset = "0x1476660", Length = "0x5")]
	[CalledBy(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212CD0")]
	[Token(Token = "0x6002F33")]
	public static string GetCurrentDirectory(out MonoIOError error) { }

	[Address(RVA = "0x1477B60", Offset = "0x1476D60", Length = "0xFA")]
	[CalledBy(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
	[CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HandleRef), typeof(HandleRef), typeof(HandleRef), "Microsoft.Win32.SafeHandles.SafeProcessHandle&", typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[Token(Token = "0x6002F31")]
	public static Exception GetException(MonoIOError error) { }

	[Address(RVA = "0x1477470", Offset = "0x1476670", Length = "0x6EB")]
	[CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoIO), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoIOError)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PathTooLongException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9F0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002F32")]
	public static Exception GetException(string path, MonoIOError error) { }

	[Address(RVA = "0x1477C60", Offset = "0x1476E60", Length = "0x10A")]
	[CalledBy(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool), typeof(FileOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212F50")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F35")]
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	[Address(RVA = "0x1477D70", Offset = "0x1476F70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212F50")]
	[Token(Token = "0x6002F34")]
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	[Address(RVA = "0x1477D80", Offset = "0x1476F80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212F60")]
	[Token(Token = "0x6002F42")]
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	[Address(RVA = "0x1477D90", Offset = "0x1476F90", Length = "0x10F")]
	[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212F60")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F43")]
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	[Address(RVA = "0x1477EB0", Offset = "0x14770B0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802130E0")]
	[Token(Token = "0x6002F38")]
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	[Address(RVA = "0x1477EA0", Offset = "0x14770A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802130E0")]
	[Token(Token = "0x6002F37")]
	private static IntPtr Open(Char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	[Address(RVA = "0x1477F40", Offset = "0x1477140", Length = "0x13E")]
	[CalledBy(Type = typeof(FileStream), Member = "ReadData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213270")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F3D")]
	public static int Read(SafeHandle safeHandle, Byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	[Address(RVA = "0x1478080", Offset = "0x1477280", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213270")]
	[Token(Token = "0x6002F3C")]
	private static int Read(IntPtr handle, Byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	[Address(RVA = "0x1478090", Offset = "0x1477290", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213310")]
	[Token(Token = "0x6002F50")]
	public static bool RemapPath(string path, out string newPath) { }

	[Address(RVA = "0x14781E0", Offset = "0x14773E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213320")]
	[Token(Token = "0x6002F40")]
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	[Address(RVA = "0x14780A0", Offset = "0x14772A0", Length = "0x135")]
	[CalledBy(Type = typeof(FileStream), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFileHandle), typeof(FileAccess), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213320")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F41")]
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	[Address(RVA = "0x14781F0", Offset = "0x14773F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213330")]
	[Token(Token = "0x6002F44")]
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	[Address(RVA = "0x1478200", Offset = "0x1477400", Length = "0x125")]
	[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213330")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F45")]
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	[Address(RVA = "0x1478330", Offset = "0x1477530", Length = "0x13E")]
	[CalledBy(Type = typeof(FileStream), Member = "WriteInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "FlushBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213340")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002F3F")]
	public static int Write(SafeHandle safeHandle, Byte[] src, int src_offset, int count, out MonoIOError error) { }

	[Address(RVA = "0x1478470", Offset = "0x1477670", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180213340")]
	[Token(Token = "0x6002F3E")]
	private static int Write(IntPtr handle, in Byte[] src, int src_offset, int count, out MonoIOError error) { }

}

