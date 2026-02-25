namespace System.IO;

[Token(Token = "0x2000621")]
internal static class FileSystem
{
	[Token(Token = "0x2000622")]
	private class UnitySafeFindHandle : SafeFindHandle
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40018ED")]
		private readonly IntPtr m_Handle; //Field offset: 0x20

		[Token(Token = "0x170006EF")]
		public IntPtr Handle
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CBE")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170006F0")]
		public virtual bool IsInvalid
		{
			[Address(RVA = "0x9E74F0", Offset = "0x9E66F0", Length = "0x9")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CBF")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x146B410", Offset = "0x146A610", Length = "0x26")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002CBD")]
		public UnitySafeFindHandle(IntPtr handle) { }

		[Address(RVA = "0x146B3F0", Offset = "0x146A5F0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212B70")]
		[Token(Token = "0x6002CC0")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CBE")]
		public IntPtr get_Handle() { }

		[Address(RVA = "0x9E74F0", Offset = "0x9E66F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CBF")]
		public virtual bool get_IsInvalid() { }

	}


	[Address(RVA = "0x1456A60", Offset = "0x1455C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212530")]
	[Token(Token = "0x6002CB6")]
	private static void BrokeredCopyFile(string sourcePath, string destPath, bool overwrite, ref int error) { }

	[Address(RVA = "0x1456A70", Offset = "0x1455C70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802126B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002CB2")]
	private static bool BrokeredCreateDirectory(string path) { }

	[Address(RVA = "0x1456A70", Offset = "0x1455C70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802126B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002CB8")]
	private static bool BrokeredDeleteFile(string path) { }

	[Address(RVA = "0x1456A80", Offset = "0x1455C80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212A30")]
	[Token(Token = "0x6002CB9")]
	private static IntPtr BrokeredFindFirstFile(string searchPath, ref string resultFilePath, ref uint attributes) { }

	[Address(RVA = "0x1456A90", Offset = "0x1455C90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212B90")]
	[Token(Token = "0x6002CBA")]
	private static bool BrokeredFindNextFile(IntPtr handle, ref string resultFilePath, ref uint attributes) { }

	[Address(RVA = "0x1456AA0", Offset = "0x1455CA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212D60")]
	[Token(Token = "0x6002CB4")]
	private static bool BrokeredGetFileAttributes(string path, ref WIN32_FILE_ATTRIBUTE_DATA data) { }

	[Address(RVA = "0x1456AB0", Offset = "0x1455CB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212F70")]
	[Token(Token = "0x6002CB7")]
	private static bool BrokeredMoveFile(string sourceFullPath, string destFullPath) { }

	[Address(RVA = "0x1456AC0", Offset = "0x1455CC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802131A0")]
	[Token(Token = "0x6002CB5")]
	private static IntPtr BrokeredOpenFile(string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, int dwFlagsAndAttributes) { }

	[Address(RVA = "0x1456A70", Offset = "0x1455C70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802126B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002CB3")]
	private static bool BrokeredRemoveDirectory(string path) { }

	[Address(RVA = "0x1456AD0", Offset = "0x1455CD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212B70")]
	[Token(Token = "0x6002CBB")]
	private static int BrokeredSafeFindHandleDispose(IntPtr handle) { }

	[Address(RVA = "0x1456AE0", Offset = "0x1455CE0", Length = "0x24C")]
	[CalledBy(Type = typeof(File), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileInfo), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(FileInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Kernel32), Member = "CreateFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FileShare), typeof(FileMode), typeof(int)}, ReturnType = typeof(SafeFileHandle))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(UnauthorizedAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212530")]
	[Calls(Type = typeof(Kernel32), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C97")]
	public static void CopyFile(string sourceFullPath, string destFullPath, bool overwrite) { }

	[Address(RVA = "0x1456D30", Offset = "0x1455F30", Length = "0x59A")]
	[CalledBy(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(FileSystem), Member = "FileExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802126B0")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Kernel32), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SECURITY_ATTRIBUTES&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(PathInternal), Member = "GetRootLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C98")]
	public static void CreateDirectory(string fullPath) { }

	[Address(RVA = "0x14572D0", Offset = "0x14564D0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileSystem), Member = "UnityDeleteFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002C99")]
	public static void DeleteFile(string fullPath) { }

	[Address(RVA = "0x1457360", Offset = "0x1456560", Length = "0x45")]
	[CalledBy(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C9A")]
	public static bool DirectoryExists(string fullPath) { }

	[Address(RVA = "0x14573B0", Offset = "0x14565B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C9B")]
	private static bool DirectoryExists(string path, out int lastError) { }

	[Address(RVA = "0x1457400", Offset = "0x1456600", Length = "0x47")]
	[CalledBy(Type = typeof(FileSystem), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[Token(Token = "0x6002C9D")]
	public static bool FileExists(string fullPath) { }

	[Address(RVA = "0x1457450", Offset = "0x1456650", Length = "0x443")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WIN32_FILE_ATTRIBUTE_DATA), Member = "PopulateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystem), Member = "UnityFindFirstFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(SafeFindHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212D60")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Kernel32), Member = "GetFileAttributesEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GET_FILEEX_INFO_LEVELS), typeof(WIN32_FILE_ATTRIBUTE_DATA&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DisableMediaInsertionPrompt), Member = "Create", ReturnType = typeof(DisableMediaInsertionPrompt))]
	[Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Kernel32), Member = "SetThreadErrorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C9C")]
	internal static int FillAttributeInfo(string path, ref WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound) { }

	[Address(RVA = "0x14578A0", Offset = "0x1456AA0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002C9E")]
	public static FileAttributes GetAttributes(string fullPath) { }

	[Address(RVA = "0x1457910", Offset = "0x1456B10", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FILE_TIME), Member = "ToDateTimeOffset", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002C9F")]
	public static DateTimeOffset GetCreationTime(string fullPath) { }

	[Address(RVA = "0x14579A0", Offset = "0x1456BA0", Length = "0x141")]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FileSystem), Member = "UnityFindFirstFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(SafeFindHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002CA4")]
	private static void GetFindData(string fullPath, ref WIN32_FIND_DATA findData) { }

	[Address(RVA = "0x1457AF0", Offset = "0x1456CF0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FILE_TIME), Member = "ToDateTimeOffset", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002CA0")]
	public static DateTimeOffset GetLastWriteTime(string fullPath) { }

	[Address(RVA = "0x1453B00", Offset = "0x1452D00", Length = "0x7")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DriveInfoInternal), Member = "GetLogicalDrives", ReturnType = typeof(String[]))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002CA8")]
	public static String[] GetLogicalDrives() { }

	[Address(RVA = "0x1457B80", Offset = "0x1456D80", Length = "0x16")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002CA5")]
	private static bool IsNameSurrogateReparsePoint(ref WIN32_FIND_DATA data) { }

	[Address(RVA = "0x1457BA0", Offset = "0x1456DA0", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystem), Member = "UnityMoveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Win32Marshal), Member = "MakeHRFromErrorCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CA1")]
	public static void MoveDirectory(string sourceFullPath, string destFullPath) { }

	[Address(RVA = "0x1457CC0", Offset = "0x1456EC0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystem), Member = "UnityMoveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForLastWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002CA2")]
	public static void MoveFile(string sourceFullPath, string destFullPath) { }

	[Address(RVA = "0x1458640", Offset = "0x1457840", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(FileSystem), Member = "GetFindData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PathInternal), Member = "EnsureExtendedPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystem), Member = "RemoveDirectoryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CA3")]
	public static void RemoveDirectory(string fullPath, bool recursive) { }

	[Address(RVA = "0x1457D10", Offset = "0x1456F10", Length = "0x11C")]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileSystem), Member = "UnityRemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002CA7")]
	private static void RemoveDirectoryInternal(string fullPath, bool topLevel, bool allowDirectoryNotEmpty = false) { }

	[Address(RVA = "0x1457E30", Offset = "0x1457030", Length = "0x80C")]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(WIN32_FIND_DATA), Member = "SetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystem), Member = "UnityDeleteFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Kernel32), Member = "FindNextFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFindHandle), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(FileSystem), Member = "RemoveDirectoryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212B90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FileSystem), Member = "UnityRemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForLastWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Kernel32), Member = "DeleteVolumeMountPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FixedBufferExtensions), Member = "GetStringFromFixedBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FixedBufferExtensions), Member = "FixedBufferEqualsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WIN32_FIND_DATA), Member = "get_cFileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(FileSystem), Member = "UnityFindFirstFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(SafeFindHandle))]
	[Calls(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002CA6")]
	private static void RemoveDirectoryRecursive(string fullPath, ref WIN32_FIND_DATA findData, bool topLevel) { }

	[Address(RVA = "0x1458710", Offset = "0x1457910", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002CBC")]
	private static string RemoveExtendedPathPrefix(string path) { }

	[Address(RVA = "0x1458780", Offset = "0x1457980", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel32), Member = "CopyFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212530")]
	[Token(Token = "0x6002CAD")]
	private static int UnityCopyFile(string sourceFullPath, string destFullPath, bool failIfExists) { }

	[Address(RVA = "0x14587E0", Offset = "0x14579E0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SECURITY_ATTRIBUTES&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802126B0")]
	[Token(Token = "0x6002CA9")]
	private static bool UnityCreateDirectory(string name) { }

	[Address(RVA = "0x1458880", Offset = "0x1457A80", Length = "0xCF")]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CreateDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "CreateFile_IntPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FileShare), typeof(FileMode), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802131A0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002CAC")]
	internal static IntPtr UnityCreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

	[Address(RVA = "0x1458950", Offset = "0x1457B50", Length = "0xD5")]
	[CalledBy(Type = typeof(FileSystem), Member = "DeleteFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "DeleteFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802126B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002CAE")]
	private static bool UnityDeleteFile(string path) { }

	[Address(RVA = "0x1458A30", Offset = "0x1457C30", Length = "0x1AA")]
	[CalledBy(Type = typeof(FileSystem), Member = "FillAttributeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FILE_ATTRIBUTE_DATA&), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileSystem), Member = "GetFindData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(WIN32_FIND_DATA), Member = "SetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212A30")]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Kernel32), Member = "FindFirstFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(SafeFindHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002CB0")]
	private static SafeFindHandle UnityFindFirstFile(string path, ref WIN32_FIND_DATA findData) { }

	[Address(RVA = "0x1458BE0", Offset = "0x1457DE0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212B90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(WIN32_FIND_DATA), Member = "SetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Kernel32), Member = "FindNextFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeFindHandle), typeof(WIN32_FIND_DATA&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6002CB1")]
	private static bool UnityFindNextFile(SafeFindHandle handle, ref WIN32_FIND_DATA findData) { }

	[Address(RVA = "0x1458CE0", Offset = "0x1457EE0", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Kernel32), Member = "GetFileAttributesEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GET_FILEEX_INFO_LEVELS), typeof(WIN32_FILE_ATTRIBUTE_DATA&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212D60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002CAB")]
	private static bool UnityGetFileAttributesEx(string path, ref WIN32_FILE_ATTRIBUTE_DATA data) { }

	[Address(RVA = "0x1458E40", Offset = "0x1458040", Length = "0x94")]
	[CalledBy(Type = typeof(FileSystem), Member = "MoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "MoveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "MoveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180212F70")]
	[Token(Token = "0x6002CAF")]
	private static bool UnityMoveFile(string sourceFullPath, string destFullPath) { }

	[Address(RVA = "0x1458EE0", Offset = "0x14580E0", Length = "0xD5")]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "RemoveDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802126B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002CAA")]
	private static bool UnityRemoveDirectory(string fullPath) { }

}

