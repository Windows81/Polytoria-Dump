namespace SimpleFileBrowser;

[Token(Token = "0x2000018")]
public static class FileBrowserHelpers
{

	[Address(RVA = "0x1540620", Offset = "0x153F820", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D2")]
	public static void AppendBytesToFile(string targetPath, Byte[] bytes) { }

	[Address(RVA = "0x1540740", Offset = "0x153F940", Length = "0x1FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000D4")]
	private static void AppendFileToFile(string targetPath, string sourceFileToAppend) { }

	[Address(RVA = "0x1540940", Offset = "0x153FB40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "AppendAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000D3")]
	public static void AppendTextToFile(string targetPath, string text) { }

	[Address(RVA = "0x1540B00", Offset = "0x153FD00", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowserHelpers), Member = "CopyDirectoryRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000D8")]
	public static void CopyDirectory(string sourcePath, string destinationPath) { }

	[Address(RVA = "0x1540950", Offset = "0x153FB50", Length = "0x1AB")]
	[CalledBy(Type = typeof(FileBrowserHelpers), Member = "CopyDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserHelpers), Member = "CopyDirectoryRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles", ReturnType = typeof(FileInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileInfo), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(FileInfo))]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetDirectories", ReturnType = typeof(DirectoryInfo[]))]
	[Calls(Type = typeof(FileBrowserHelpers), Member = "CopyDirectoryRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectoryInfo), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000D9")]
	private static void CopyDirectoryRecursively(DirectoryInfo sourceDirectory, string destinationPath) { }

	[Address(RVA = "0x1540B70", Offset = "0x153FD70", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000D7")]
	public static void CopyFile(string sourcePath, string destinationPath) { }

	[Address(RVA = "0x1540B80", Offset = "0x153FD80", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60000CE")]
	public static string CreateFileInDirectory(string directoryPath, string filename) { }

	[Address(RVA = "0x1540C50", Offset = "0x153FE50", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Token(Token = "0x60000CF")]
	public static string CreateFolderInDirectory(string directoryPath, string folderName) { }

	[Address(RVA = "0x1540CC0", Offset = "0x153FEC0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000DF")]
	public static void DeleteDirectory(string path) { }

	[Address(RVA = "0x1540CD0", Offset = "0x153FED0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000DE")]
	public static void DeleteFile(string path) { }

	[Address(RVA = "0x1540CE0", Offset = "0x153FEE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000CA")]
	public static bool DirectoryExists(string path) { }

	[Address(RVA = "0x1540CF0", Offset = "0x153FEF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000C9")]
	public static bool FileExists(string path) { }

	[Address(RVA = "0x1540D00", Offset = "0x153FF00", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60000CC")]
	public static string GetDirectoryName(string path) { }

	[Address(RVA = "0x1540D50", Offset = "0x153FF50", Length = "0x321")]
	[CalledBy(Type = typeof(FileBrowser), Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_Attributes", ReturnType = typeof(FileAttributes))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileBrowser), Member = "GetExtensionFromFilename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFileSystemInfos", ReturnType = typeof(FileSystemInfo[]))]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000CD")]
	public static FileSystemEntry[] GetEntriesInDirectory(string path, bool extractOnlyLastSuffixFromExtensions) { }

	[Address(RVA = "0x1541080", Offset = "0x1540280", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60000E0")]
	public static string GetFilename(string path) { }

	[Address(RVA = "0x15410D0", Offset = "0x15402D0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileInfo), Member = "get_Length", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E1")]
	public static long GetFilesize(string path) { }

	[Address(RVA = "0x1541140", Offset = "0x1540340", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemInfo), Member = "get_LastWriteTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E2")]
	public static DateTime GetLastModifiedDate(string path) { }

	[Address(RVA = "0x15411B0", Offset = "0x15403B0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000CB")]
	public static bool IsDirectory(string path) { }

	[Address(RVA = "0x1541240", Offset = "0x1540440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000DB")]
	public static void MoveDirectory(string sourcePath, string destinationPath) { }

	[Address(RVA = "0x1541250", Offset = "0x1540450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000DA")]
	public static void MoveFile(string sourcePath, string destinationPath) { }

	[Address(RVA = "0x1541260", Offset = "0x1540460", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "ReadAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x60000D5")]
	public static Byte[] ReadBytesFromFile(string sourcePath) { }

	[Address(RVA = "0x1541270", Offset = "0x1540470", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "ReadAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60000D6")]
	public static string ReadTextFromFile(string sourcePath) { }

	[Address(RVA = "0x1541280", Offset = "0x1540480", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DirectoryInfo), Member = "get_Parent", ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DD")]
	public static string RenameDirectory(string path, string newName) { }

	[Address(RVA = "0x1541360", Offset = "0x1540560", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000DC")]
	public static string RenameFile(string path, string newName) { }

	[Address(RVA = "0x15413E0", Offset = "0x15405E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "WriteAllBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60000D0")]
	public static void WriteBytesToFile(string targetPath, Byte[] bytes) { }

	[Address(RVA = "0x15413F0", Offset = "0x15405F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "WriteAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000D1")]
	public static void WriteTextToFile(string targetPath, string text) { }

}

